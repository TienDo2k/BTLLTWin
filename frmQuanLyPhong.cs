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
    public partial class frmQuanLyPhong : Form
    {
        BTLLTWinContext db = new BTLLTWinContext();
        public delegate void Data(string text);
        public void funData(string txt)
        {
            txtcv.Text = txt;
        }
        public frmQuanLyPhong()
        {
            InitializeComponent();
        }

        #region Kiểm tra dữ liệu nhập
        private void txtMaPhong_Validated_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMaPhong, "");
        }

        private void txtTenPhong_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTenPhong, "");
        }

        //private void txtLoaiPhong_Validated(object sender, EventArgs e)
        //{
        //    errorProvider1.SetError(txtLoaiPhong, "");
        //}

        private void txtGiaPhong_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtGiaPhong, "");
        }

        //private void txtTinhTrang_Validated(object sender, EventArgs e)
        //{
        //    errorProvider1.SetError(txtTinhTrang, "");
        //}

        //private void txtSLTD_Validated(object sender, EventArgs e)
        //{
        //    errorProvider1.SetError(txtSLTD, "");
        //} 
        #endregion

        private bool ValidData()
        {
            if (txtMaPhong.Text == "")
            {
                errorProvider1.SetError(txtMaPhong, "Bạn phải nhập mã phòng!");
                txtMaPhong.Focus();
                return false;
            }
            if (txtTenPhong.Text == "")
            {
                errorProvider1.SetError(txtTenPhong, "Bạn phải nhập tên phòng!");
                txtTenPhong.Focus();
                return false;
            }   
            if (txtGiaPhong.Text == "")
            {
                errorProvider1.SetError(txtGiaPhong, "Bạn phải nhập giá phòng!");
                txtGiaPhong.Focus();
                return false;
            }
            else
            {
                try
                {
                    int.Parse(txtGiaPhong.Text);
                    if (int.Parse(txtGiaPhong.Text) < 0)
                    {
                        errorProvider1.SetError(txtGiaPhong, "Bạn phải nhập giá phòng > 0 !");
                        txtGiaPhong.Focus();
                        txtGiaPhong.SelectAll();
                        return false;
                    }
                }
                catch
                {
                    errorProvider1.SetError(txtGiaPhong, "Bạn phải nhập giá phòng là số nguyên!");
                    txtGiaPhong.Focus();
                    txtGiaPhong.SelectAll();
                    return false;
                }
            }

            return true;
        }

        private void frmQuanLyPhong_Load(object sender, EventArgs e)
        {            
            HienThi();
        }

        private void HienThi()
        {
            var query = from p in db.Phongs
                        select new
                        {
                            p.MaPhong,
                            p.TenPhong,
                            p.LoaiPhong,
                            p.Gia,
                            p.TinhTrang,
                            p.SoNguoiToiDa
                        };
            dgvPhong.DataSource = query.ToList();           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {                
                Phong phongMoi = db.Phongs.FirstOrDefault(p => p.MaPhong == txtMaPhong.Text);
                if (phongMoi != null)
                {                    
                    errorProvider1.SetError(txtMaPhong, "Mã phòng đã tồn tại !");
                    txtMaPhong.Clear();
                    txtMaPhong.Focus();
                    return;
                }

                phongMoi = new Phong();              
                phongMoi.MaPhong = txtMaPhong.Text;
                phongMoi.TenPhong = txtTenPhong.Text;
                phongMoi.LoaiPhong = cbLoaiPhong.Text;
                phongMoi.Gia = int.Parse(txtGiaPhong.Text);
                phongMoi.TinhTrang = cbTinhTrang.Text;
                phongMoi.SoNguoiToiDa = int.Parse(cbSLTD.Text);
                
                db.Phongs.Add(phongMoi);
                
                db.SaveChanges();
                
                HienThi();
                MessageBox.Show("Thêm phòng mới thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            Phong phongMoi = db.Phongs.FirstOrDefault(p => p.MaPhong == txtMaPhong.Text);
            if (phongMoi == null)
            {
                errorProvider1.SetError(txtMaPhong, "Mã phòng không tồn tại !");
                txtMaPhong.Clear();
                txtMaPhong.Focus();
                return;
            }

            var query = from p in db.Phongs
                        where p.MaPhong == txtMaPhong.Text
                        select new
                        {
                            p.MaPhong,
                            p.TenPhong,
                            p.LoaiPhong,
                            p.Gia,
                            p.TinhTrang,
                            p.SoNguoiToiDa
                        };
            
            dgvPhong.DataSource = query.ToList();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {           
            if (ValidData())
            {
                Phong phongSua = db.Phongs.FirstOrDefault(p => p.MaPhong == txtMaPhong.Text);

                if (phongSua == null)
                {
                    errorProvider1.SetError(txtMaPhong, "Mã phòng không tồn tại !");
                    txtMaPhong.Clear();
                    txtMaPhong.Focus();
                    return;
                }

                phongSua.TenPhong = txtTenPhong.Text;
                phongSua.LoaiPhong = cbLoaiPhong.Text;
                phongSua.TinhTrang = cbTinhTrang.Text;
                phongSua.Gia = int.Parse(txtGiaPhong.Text);
                phongSua.SoNguoiToiDa = int.Parse(cbSLTD.Text);
                                
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
                

                Phong phongXoa = db.Phongs.FirstOrDefault(p => p.MaPhong == txtMaPhong.Text);

                if (phongXoa == null)
                {
                    errorProvider1.SetError(txtMaPhong, "Mã phòng không tồn tại !");
                    txtMaPhong.Clear();
                    txtMaPhong.Focus();
                    return;
                }
                
                DialogResult select = MessageBox.Show("Bạn có muốn xóa thông tin phòng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (select == DialogResult.Yes)
                {
                    try
                    {
                        HoaDon hd = db.HoaDons.FirstOrDefault(h => h.MaPhong == txtMaPhong.Text);
                        db.HoaDons.Remove(hd);
                        db.Phongs.Remove(phongXoa);
                        db.SaveChanges();
                        HienThi();
                    }
                    catch (Exception)
                    {
                        db.Phongs.Remove(phongXoa);
                        db.SaveChanges();
                        HienThi();
                    }

                }
            }            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult select = MessageBox.Show("Bạn có muốn đóng form?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(select == DialogResult.Yes)
            {
                formtrangchu form = new formtrangchu();
                Data data = new Data(form.funData);
                data(txtcv.Text);
                form.Show();
                Visible = false;
            }            
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvPhong.CurrentRow.Index;
            txtMaPhong.Text = dgvPhong.Rows[index].Cells[0].Value.ToString();
            txtTenPhong.Text = dgvPhong.Rows[index].Cells[1].Value.ToString(); 
            cbLoaiPhong.Text = dgvPhong.Rows[index].Cells[2].Value.ToString();
            txtGiaPhong.Text = dgvPhong.Rows[index].Cells[3].Value.ToString();
            cbTinhTrang.Text = dgvPhong.Rows[index].Cells[4].Value.ToString();
            cbSLTD.Text = dgvPhong.Rows[index].Cells[5].Value.ToString();            
        }

        private void cbLoaiPhong_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedIndex == 0)
            {
                txtGiaPhong.Text = "500000";
            }
            else
            {
                txtGiaPhong.Text = "800000";
            }
        }
    }
}
