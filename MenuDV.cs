using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTLLTWin.Models;

namespace BTLLTWin
{
    public partial class MenuDV : Form
    {
        BTLLTWinContext db = new BTLLTWinContext();
        public MenuDV()
        {
            InitializeComponent();
        }
        #region Kiểm tra dữ liệu người dùng nhập



        private void txtDonGia_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtDonGia, "");
        }

        private void txtTenDv_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTenDv, "");
        }

        private void txtMaDV_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMaDV, "");
        }
        private bool ValidData()
        {
            if (txtMaDV.Text == "")
            {
                errorProvider1.SetError(txtMaDV, "Bạn phải nhập mã sản phẩm!");
                txtMaDV.Focus();
                return false;
            }
            if (txtTenDv.Text == "")
            {
                errorProvider1.SetError(txtTenDv, "Bạn phải nhập tên sản phẩm!");
                txtTenDv.Focus();
                return false;
            }
            if (txtDonGia.Text == "")
            {
                errorProvider1.SetError(txtDonGia, "Bạn phải nhập đơn giá sản phẩm!");
                txtDonGia.Focus();
                return false;
            }
            else
            {
                try
                {
                    double.Parse(txtDonGia.Text);
                    if (double.Parse(txtDonGia.Text) < 0)
                    {
                        errorProvider1.SetError(txtDonGia, "Bạn phải nhập đơn giá >0 !");
                        txtDonGia.Focus();
                        txtDonGia.SelectAll();
                        return false;
                    }
                }
                catch
                {
                    errorProvider1.SetError(txtDonGia, "Bạn phải nhập đơn giá là số !");
                    txtDonGia.Focus();
                    txtDonGia.SelectAll();
                    return false;
                }
            }

            return true;
        }

        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {

            HienThiDuLieu();
            txtcv.Visible = false;
        }
        public delegate void Data(string text);
        public void funData(string txt)
        {
            txtcv.Text = txt;
        }
        private void HienThiDuLieu()
        {
            //Lấy dữ liệu từ bảng Sản phẩm
            var a = from s in db.MenuDichVus
                    select new
                    {
                        s.MaDichVu,
                        s.TenDichVu,
                        s.DonGia,
                        s.Slc,

                    };
            //Hiển thị lên datagrid view
            Menu.DataSource = a.ToList();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidData()) {
                    var query = from s in db.MenuDichVus
                                where s.MaDichVu == txtMaDV.Text
                                select s;
                    MenuDichVu DvuMoi = new MenuDichVu();
                    DvuMoi.MaDichVu = txtMaDV.Text;
                    DvuMoi.TenDichVu = txtTenDv.Text;
                    DvuMoi.DonGia = double.Parse(txtDonGia.Text);
                    db.MenuDichVus.Add(DvuMoi);
                    db.SaveChanges();
                    HienThiDuLieu();
                }
            }
            catch { MessageBox.Show("Mã dịch vụ đã tồn tại đã tồn tại", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error); } 
        } 

        private void btXoa_Click(object sender, EventArgs e)
        {
            var query = from s in db.MenuDichVus
                        where s.MaDichVu == txtMaDV.Text
                        select s;
            if (!query.Any())
            {
                // kiểm tra mã xóa có tồn tại k 
                MessageBox.Show("Mã muốn xóa không tồn tại", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaDV.Focus();
                return;
            }
            else
            {
                // kiểm tra xem có muốn xóa hay k 
                DialogResult tl = MessageBox.Show("Bạn muốn xóa k", "Thông báo ", MessageBoxButtons.YesNo);
                if (tl == DialogResult.Yes)
                {
                    //SanPham Spxoa = db.NhanViens.SingleOrDefault(sp => sp.MaSp == txtMa.Text);
                    db.MenuDichVus.Remove(query.SingleOrDefault());
                    db.SaveChanges();
                    HienThiDuLieu();
                }
            }
        }

        private void Menu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Menu.Rows[e.RowIndex];
                txtMaDV.Text = row.Cells[0].Value.ToString();
                txtTenDv.Text = row.Cells[1].Value.ToString();
                txtDonGia.Text = row.Cells[2].Value.ToString();
                txtSl.Text = row.Cells[3].Value.ToString();
            }
        }

        private void BtSua_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                var query = from s in db.MenuDichVus
                            where s.MaDichVu == txtMaDV.Text
                            select s;
                if (!query.Any())
                {
                    MessageBox.Show("Mã muốn sửa không tồn tại", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MenuDichVu menuSua = query.SingleOrDefault();
                    menuSua.MaDichVu = txtMaDV.Text;
                    menuSua.TenDichVu = txtTenDv.Text;
                    menuSua.DonGia = double.Parse(txtDonGia.Text);
                    menuSua.Slc = int.Parse(txtSl.Text);
                    db.SaveChanges();
                    HienThiDuLieu();
                }
            }

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?",
                 "Error", MessageBoxButtons.OK) == DialogResult.OK) { 
                formtrangchu form = new formtrangchu();
                Data data = new Data(form.funData);
                data(txtcv.Text);
                this.Hide();
                form.Show();
            }
        }

        private void btnDVKH_Click(object sender, EventArgs e)
        {
            DichVuKH d = new DichVuKH();
            d.Show();
            Visible = false;

        }
    }
}
