using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BTLLTWin.Models;
using System.Globalization;

namespace BTLLTWin
{

    public partial class DichVuKH : Form
    {
        BTLLTWinContext db = new BTLLTWinContext();
        public delegate void Data(string text);
        public void funData(string txt)
        {
            txtcv.Text = txt;
        }
        public DichVuKH()
        {
            InitializeComponent();
        }
        #region Kiểm tra dữ liệu hợp lệ
        private void btThanhToan_Click(object sender, EventArgs e)
        {
            frmThanhToanDichVu frm = new frmThanhToanDichVu();
            Data data = new Data(frm.funData);
            data(txtcv.Text);
            frm.Show();
            Visible = false;
        }

        private void txtSl_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtSl, "");
        }
        private void txtMaSp_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMaSp, "");
        }

        private void txtTenSp_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTenSp, "");
        }
        private bool ValidData()
        {

            if (txtSl.Text == "" && int.Parse(txtSl.Text) < 0)
            {
                errorProvider1.SetError(txtSl, "Vui nhập số lượng mua!");
                txtSl.Focus();
                return false;
            }
            return true;
        }
        #endregion

     

        private void DichVuKH_Load(object sender, EventArgs e)
        {
            dtNgay.Format = DateTimePickerFormat.Custom;
            dtNgay.CustomFormat = "dd-MM-yyyy";
            Loadmenu();
            LoadDVKH();
            LoadKH();
            txtcv.Visible = false;

        }
        private void LoadKH()
        {
            var a = from kh in db.KhachHangs
                    select new
                    {
                        kh.MaKh,
                        kh.TenKh,
                    };
            kh.DataSource = a.ToList();
        }

        private void LoadDVKH()
        {
            var a = from dv in db.DichVuKhachHangs
                    select new
                    {
                        dv.MaDichVu,
                        dv.MaDichVuNavigation.TenDichVu,
                        dv.MaKh,
                        dv.MaKhNavigation.TenKh,
                        dv.SoLuong,
                        dv.MaDichVuNavigation.DonGia,
                        dv.NgaySuDung,
                        Thanhtien = dv.MaDichVuNavigation.DonGia * dv.SoLuong,
                        dv.TinhTrang,
                    };
            bh.DataSource = a.ToList();
        }

        private void Loadmenu()
        {
            var query = from menu in db.MenuDichVus
                        select new
                        {
                            menu.MaDichVu,
                            menu.TenDichVu,
                            menu.DonGia,
                            menu.Slc,
                        };
            menu.DataSource = query.ToList();
        }

        private void menu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.menu.Rows[e.RowIndex];
                txtMaSp.Text = row.Cells[0].Value.ToString();
                txtTenSp.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            var query = from s in db.DichVuKhachHangs
                        where s.MaDichVu == txtMaSp.Text && s.MaKh == txtMaKh.Text
                        select s;
            if (!query.Any())
            {
                MessageBox.Show("Mã muốn xóa không tồn tại", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaSp.Focus();
                return;
            }
            else
            {
                DialogResult tl = MessageBox.Show("Bạn muốn xóa k", "Thông báo ", MessageBoxButtons.YesNo);
                if (tl == DialogResult.Yes)
                {
                    if (dtNgay.Value >= DateTime.Today.Date)
                    {

                        var ktratt = db.DichVuKhachHangs.SingleOrDefault(
                           menu => menu.MaDichVu == txtMaSp.Text && menu.MaKh==txtMaKh.Text );
                        if(ktratt.TinhTrang.Equals("Đã thanh toán")== true) 
                        { 
                            
                            MessageBox.Show("Đã thanh toán! K thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            var tinhsl = db.MenuDichVus.SingleOrDefault(
                                menu => menu.MaDichVu == txtMaSp.Text);
                            tinhsl.Slc = tinhsl.Slc + int.Parse(txtSl.Text);
                            db.DichVuKhachHangs.Remove(query.SingleOrDefault());
                            db.SaveChanges();
                            reset();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không cùng ngày sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?",
                  "Error", MessageBoxButtons.OK) == DialogResult.OK)
            {
                formtrangchu form = new formtrangchu();
                Data data = new Data(form.funData);
                data(txtcv.Text);
                form.Show();
                Visible = false;
            }
        }

      
        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidData())
                {
                    if (dtNgay.Value >= DateTime.Today.Date)
                    {
                        var tinhsl = db.MenuDichVus.SingleOrDefault(
                                    menu => menu.MaDichVu == txtMaSp.Text);
                        if (tinhsl.Slc > int.Parse(txtSl.Text))
                        {
                            var a = from dv in db.DichVuKhachHangs select dv;

                            int max = 0;
                            if (db.DichVuKhachHangs.Select(x => x).Count() > 0)
                            {
                                max = db.DichVuKhachHangs.Max(a => a.Id);
                            }
                            DichVuKhachHang DvuMoi = new DichVuKhachHang();
                            DvuMoi.Id = max + 1;
                            DvuMoi.MaDichVu = txtMaSp.Text;
                            DvuMoi.MaKh = txtMaKh.Text;
                            DvuMoi.SoLuong = int.Parse(txtSl.Text);
                            DvuMoi.NgaySuDung = dtNgay.Value;
                            DvuMoi.TinhTrang = "Chưa thanh toán";
                            db.DichVuKhachHangs.Add(DvuMoi);
                            tinhsl.Slc = tinhsl.Slc - int.Parse(txtSl.Text);
                            db.SaveChanges();
                             reset();
                        }
                        else { MessageBox.Show("Dịch vụ này đã hết !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else
                    {
                        MessageBox.Show("Kiểm tra lại ngày mua !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch { MessageBox.Show("Thêm không thành công ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void reset()
        {
            LoadDVKH();
            Loadmenu();
            txtMaSp.Clear();
            txtTenSp.Clear();
            txtMaKh.Clear();
            txtTenkh.Clear();
            txtSl.Clear();
            dtNgay.Value = DateTime.Now;
        }

        private void bh_CellContentClick(object sender, DataGridViewCellEventArgs a)
        {
            if (a.RowIndex >= 0)
            {
                DataGridViewRow row = this.bh.Rows[a.RowIndex];
                txtMaSp.Text = row.Cells[0].Value.ToString();
                txtTenSp.Text = row.Cells[1].Value.ToString();
                txtMaKh.Text = row.Cells[2].Value.ToString();
                txtTenkh.Text = row.Cells[3].Value.ToString();
                txtSl.Text = row.Cells[4].Value.ToString();
                dtNgay.Text = Convert.ToDateTime(row.Cells[6].Value.ToString()).ToShortDateString();

            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                if (dtNgay.Value >= DateTime.Today.Date)
                {
                    var query = from s in db.DichVuKhachHangs
                                where s.MaKh == txtMaKh.Text && s.MaDichVu == txtMaSp.Text
                                select s;
                    if (!query.Any())
                    {
                        MessageBox.Show("Mã muốn sửa không tồn tại", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaSp.Focus();
                        return;
                    }
                    else
                    {
                        // cập nhật số lượng bảng MenuDichVu
                        var tinhsl = db.MenuDichVus.SingleOrDefault(
                                    menu => menu.MaDichVu == txtMaSp.Text);
                        DichVuKhachHang Dvkh = query.SingleOrDefault(menu => menu.MaDichVu == txtMaSp.Text);
                        // cập nhật số lượng bảng MenuDichVu
                        if (tinhsl.Slc > int.Parse(txtSl.Text))
                        {
                            if (Dvkh.SoLuong < int.Parse(txtSl.Text))
                                tinhsl.Slc = tinhsl.Slc - (-Dvkh.SoLuong + int.Parse(txtSl.Text));
                            else
                                tinhsl.Slc = tinhsl.Slc - (Dvkh.SoLuong - int.Parse(txtSl.Text));
                            DichVuKhachHang DvSua = query.SingleOrDefault();
                            DvSua.NgaySuDung = dtNgay.Value;
                            DvSua.SoLuong = int.Parse(txtSl.Text);
                            db.SaveChanges();
                            LoadDVKH();
                            Loadmenu();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại ngày mua !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            txtMaSp.Clear();
            txtTenSp.Clear();
            txtMaKh.Clear();
            txtTenkh.Clear();
            txtSl.Clear();
            dtNgay.Value = DateTime.Now;

        }

        private void kh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.kh.Rows[e.RowIndex];
                txtMaKh.Text = row.Cells[0].Value.ToString();
                txtTenkh.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
