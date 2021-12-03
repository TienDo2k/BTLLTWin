using BTLLTWin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLLTWin
{
    public partial class frmQuanLyHoaDon : Form
    {
        BTLLTWinContext db = new BTLLTWinContext();

        public frmQuanLyHoaDon()
        {
            InitializeComponent();
        }
        public delegate void Data(string text);
        public void funData(string txt)
        {
            txtcv.Text = txt;
        }
        private void frmQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            dtpNgayDen.Format = DateTimePickerFormat.Custom;
            dtpNgayDen.CustomFormat = "dd-MM-yyyy";
            dtpNgayDi.Format = DateTimePickerFormat.Custom;
            dtpNgayDi.CustomFormat = "dd-MM-yyyy";
            HienThi();
        }

        #region Kiểm tra dữ liệu hợp lệ
        private void txtMaHD_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMaHD, "");
        }


        #endregion

        private bool ValidData()
        {
            if (txtMaHD.Text == "")
            {
                errorProvider1.SetError(txtMaHD, "Bạn phải nhập mã hóa đơn!");
                txtMaHD.Focus();
                return false;
            }
            //if(dtpNgayDen.Value< DateTime.Today.Date )
            //{
            //    MessageBox.Show("Kiểm tra ngày đến  ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    dtpNgayDen.Focus();
               
            //    return false;
            //}
            //else
            //{
                if (dtpNgayDen.Value > dtpNgayDi.Value)
                {
                    MessageBox.Show("Kiểm tra ngày di  ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpNgayDi.Focus();
                    return false;
                }
            //}   
            return true;
        }

        private int tinhNgay()
        {
            var query = from h in db.HoaDons
                        select new
                        {
                            h.NgayDen,
                            h.NgayDi
                        };
            int TongSoNgay = 0;
            foreach (var item in query)
            {
                DateTime ngayDen = Convert.ToDateTime(item.NgayDen);
                DateTime ngayDi = Convert.ToDateTime(item.NgayDi);
                TimeSpan Time = ngayDi - ngayDen;
                TongSoNgay = Time.Days;
            }
            return TongSoNgay;
        }

        private void HienThi()
        {
            var query = from h in db.HoaDons
                        select new
                        {
                            MaHD = h.MaHd,
                            TenKH = h.MaKhNavigation.TenKh,
                            TenPhong = h.MaPhongNavigation.TenPhong,
                            TenDV = "Không",
                            NgayDen = h.NgayDen,
                            NgayDi = h.NgayDi,
                            TongTien =  tinhNgay() * h.MaPhongNavigation.Gia,
                            ThanhToan = h.TtthanhToan,
                        };
            var list2 = query.ToList();
            foreach (var i in list2) {

                var query1 = from h in db.HoaDons
                             join d in db.DichVuKhachHangs on h.MaKh equals d.MaKh
                             where  h.MaHd.CompareTo(i.MaHD)==0 && d.TinhTrang.Equals("Chưa thanh toán")
                            select new
                        {
                            MaHD = h.MaHd,
                            TenKH = h.MaKhNavigation.TenKh,
                            TenPhong = h.MaPhongNavigation.TenPhong,
                            TenDV = d.MaDichVuNavigation.TenDichVu,
                            NgayDen = h.NgayDen,
                            NgayDi = h.NgayDi,
                            TongTien = d.MaDichVuNavigation.DonGia * d.SoLuong + tinhNgay() * h.MaPhongNavigation.Gia,
                            ThanhToan = h.TtthanhToan,
                        };
                var list1 = query1.ToList();
                //Bạn sử dụng cú pháp Union của Linq để gộp 2 list :
                var unionList = list2.Union(list1).ToList();
                //var unionList = list1.Concat(list2);
                dgvHoaDon.DataSource = unionList.ToList();
            } 
            var listMaPhong = from p in db.Phongs
                                  select p;
                cbMaPhong.DataSource = listMaPhong.ToList();
                cbMaPhong.DisplayMember = "TenPhong";
                cbMaPhong.ValueMember = "MaPhong";

                var listMaKH = from k in db.KhachHangs
                               select k;
                cbMaKH.DataSource = listMaKH.ToList();
                cbMaKH.DisplayMember = "TenKH";
                cbMaKH.ValueMember = "MaKH";
          

        }  

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                HoaDon hd = db.HoaDons.FirstOrDefault(h => h.MaHd == txtMaHD.Text);
                if (hd != null)
                {
                    errorProvider1.SetError(txtMaHD, "Mã hóa đơn đã tồn tại !");
                    txtMaHD.Clear();
                    txtMaHD.Focus();
                    return;
                }

                hd = new HoaDon();
                hd.MaHd = txtMaHD.Text;
                hd.MaKh = cbMaKH.SelectedValue.ToString();
                hd.MaPhong = cbMaPhong.SelectedValue.ToString();
                hd.NgayDen = dtpNgayDen.Value;
                hd.NgayDi = dtpNgayDi.Value;
                hd.TtthanhToan = cbThanhToan.Text;
                db.HoaDons.Add(hd);
                db.SaveChanges();

                HienThi();
                MessageBox.Show("Thêm hóa đơn thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                HoaDon hd = db.HoaDons.FirstOrDefault(h => h.MaHd == txtMaHD.Text);
                if (hd == null)
                {
                    errorProvider1.SetError(txtMaHD, "Mã hóa đơn không tồn tại !");
                    txtMaHD.Clear();
                    txtMaHD.Focus();
                    return;
                }

                hd.MaKh = cbMaKH.SelectedValue.ToString();
                hd.MaPhong = cbMaPhong.SelectedValue.ToString();
                hd.NgayDen = dtpNgayDen.Value;
                hd.NgayDi = dtpNgayDi.Value;
                hd.TtthanhToan = cbThanhToan.Text;
                DialogResult select = MessageBox.Show("Bạn có muốn lưu thông tin vừa chỉnh sửa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (select == DialogResult.Yes)
                {
                    db.SaveChanges();
                    HienThi();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                HoaDon hd = db.HoaDons.FirstOrDefault(h => h.MaHd == txtMaHD.Text);

                if (hd == null)
                {
                    errorProvider1.SetError(txtMaHD, "Mã phòng hóa đơn tồn tại !");
                    txtMaHD.Clear();
                    txtMaHD.Focus();
                    return;
                }

                DialogResult select = MessageBox.Show("Bạn có muốn xóa hóa đơn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (select == DialogResult.Yes)
                {
                    db.HoaDons.Remove(hd);
                    db.SaveChanges();
                    HienThi();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult select = MessageBox.Show("Bạn có muốn đóng form?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (select == DialogResult.Yes)
            {
                formtrangchu form = new formtrangchu();
                Data data = new Data(form.funData);
                data(txtcv.Text);
                form.Show();
                Visible = false;
            }
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvHoaDon.CurrentRow.Index;
            txtMaHD.Text = dgvHoaDon.Rows[index].Cells[0].Value.ToString();
            cbMaKH.Text = dgvHoaDon.Rows[index].Cells[1].Value.ToString();
            cbMaPhong.Text = dgvHoaDon.Rows[index].Cells[2].Value.ToString();
            dtpNgayDen.Text = dgvHoaDon.Rows[index].Cells[4].Value.ToString();
            dtpNgayDi.Text = dgvHoaDon.Rows[index].Cells[5].Value.ToString();
            cbThanhToan.Text = dgvHoaDon.Rows[index].Cells[7].Value.ToString();
        }

        private void btTTPhong_Click(object sender, EventArgs e)
        {
            frmThanhToan frm = new frmThanhToan();
            Data data = new Data(frm.funData);
            data(txtcv.Text);
            frm.Show();
            Visible = false;
        }

        private void btTTDv_Click(object sender, EventArgs e)
        {
            frmThanhToanDichVu frm = new frmThanhToanDichVu();
            Data data = new Data(frm.funData);
            data(txtcv.Text);
            frm.Show();
            Visible = false;
        }
       
        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
