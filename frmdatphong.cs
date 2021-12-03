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
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace BTLLTWin
{
    public partial class formdatphong : Form
    {
        BTLLTWinContext db = new BTLLTWinContext();
        public formdatphong()
        {
            InitializeComponent();
        }
        #region
        
        void LoadData()
        {
            var query = from p in db.DatPhongs
                        select new
                        {
                            p.SoCmnd,
                            p.HoTen,
                            p.Sdt,
                            p.NgayDatPhong,
                            p.NgayDi,
                            p.MaPhong,
                            p.TinhTrangDp
                        };
            dgvdatphong.DataSource = query.ToList();
        }
        void LoadData2()
        {
            var list = from p in db.Phongs
                        where p.TinhTrang == "Empty"
                        select new
                        {
                            p.MaPhong,
                            p.LoaiPhong,
                            p.TinhTrang,
                            p.Gia,
                            p.SoNguoiToiDa
                        };
            dgvphong.DataSource = list.ToList();
        }
        void LoadData3()
        {
            var list = from p in db.KhachHangs
                       select new
                       {
                           p.MaKh,
                           p.SoCmnd,
                           p.TenKh,
                           p.Sdt,
                           p.DiaChi,
                       };
            dgvkhachhang.DataSource = list.ToList();
        }
        void lammoi()
        {
            LoadData();
            LoadData2();
            LoadData3();
            txthoten.Clear();
            txtsocmnd.Clear();
            txtsdt.Clear();
            txtdiachi.Clear();
            dtpdatphong.Value = DateTime.Now;
            dtpngaydi.Value = dtpdatphong.Value.AddDays(1);
            txtmaphong.Clear();
            txtsocmnd.Focus();
        }
        bool ValidData1()
        {
            if(String.IsNullOrEmpty(txtsocmnd.Text))
            {
                MessageBox.Show("Không bỏ trống số cmnd!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (String.IsNullOrEmpty(txthoten.Text))
            {
                MessageBox.Show("Không bỏ trống họ tên!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (String.IsNullOrEmpty(txtsdt.Text))
            {
                MessageBox.Show("Không bỏ trống sđt!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (String.IsNullOrEmpty(txtdiachi.Text))
            {
                MessageBox.Show("Không bỏ trống địa chỉ!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            return true;
        }
        bool ValidData2()
        {
            if (String.IsNullOrEmpty(txtmaphong.Text))
            {
                MessageBox.Show("Không bỏ trống mã phòng!","Thông báo!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
            else
                return true;
        }
        string Tangma()
        {
            string ma = "";
            int count = 0;
            count = dgvkhachhang.Rows.Count;
            string chuoi1 = "";
            int chuoi2 = 0;
            chuoi1 = Convert.ToString(dgvkhachhang.Rows[count - 1].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi1.Remove(0, 2)));
            if (chuoi2 + 1 < 10)
            {
                ma = "KH0" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100 && chuoi2 + 1 >= 10)
            {
                ma = "KH" + (chuoi2 + 1).ToString();
            }
            return ma;
        }
        #endregion
        public delegate void Data(string text);
        private void formdatphong_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadData2();
            LoadData3();
            txtsocmnd.Focus();
            txtcv.Visible = false;
            dtpdatphong.Format = DateTimePickerFormat.Custom;
            dtpdatphong.CustomFormat = "dd-MM-yyyy";
            dtpngaydi.Format = DateTimePickerFormat.Custom;
            dtpngaydi.CustomFormat = "dd-MM-yyyy";
            dtpdatphong.Value = DateTime.Today;
            dtpngaydi.Value = dtpdatphong.Value.AddDays(1);
           
        }
        public void funData(string txt)
        {
            txtcv.Text = txt;
        }
        private void butthoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát?",
            "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                formtrangchu form = new formtrangchu();
                Data data = new Data(form.funData);
                data(txtcv.Text);
                this.Hide();
                form.Show();
            }
        }

        private void butdatphong_Click(object sender, EventArgs e)
        {
            DateTime t1 = dtpdatphong.Value.Date;
            DateTime t2 = dtpngaydi.Value.Date;
            if (ValidData1())
            {
                KhachHang validKH = db.KhachHangs.SingleOrDefault(k => k.SoCmnd == txtsocmnd.Text);
                if(validKH == null)
                {
                    KhachHang kh = new KhachHang();
                    kh.MaKh = Tangma();
                    kh.TenKh = txthoten.Text;
                    kh.SoCmnd = txtsocmnd.Text;
                    kh.Sdt = txtsdt.Text;
                    kh.DiaChi = txtdiachi.Text;
                    db.KhachHangs.Add(kh);
                    db.SaveChanges();
                    MessageBox.Show("Khách hàng mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData3();
                    if (ValidData2())
                    {
                        if (t1==DateTime.Today.Date && t1<t2)
                        {
                            Phong validP = db.Phongs.SingleOrDefault(p => p.MaPhong == txtmaphong.Text);
                            if (validP != null)
                            {
                                if (validP.TinhTrang == "Empty")
                                {
                                    int max = 0;
                                    if (db.DatPhongs.Select(x => x).Count() > 0)
                                    {
                                        max = db.DatPhongs.Max(a => a.Id);
                                    }
                                    DatPhong dp = new DatPhong();
                                    dp.Id = max + 1;
                                    dp.SoCmnd = txtsocmnd.Text;
                                    dp.HoTen = txthoten.Text;
                                    dp.Sdt = txtsdt.Text;
                                    dp.NgayDatPhong = dtpdatphong.Value;
                                    dp.NgayDi = dtpngaydi.Value;
                                    dp.MaPhong = txtmaphong.Text;
                                    dp.TinhTrangDp = "Chưa trả phòng";
                                    validP.TinhTrang = "Use";
                                    db.DatPhongs.Add(dp);
                                    db.SaveChanges();
                                    LoadData();
                                    LoadData2();
                                    MessageBox.Show("Đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtmaphong.Clear();
                                }
                                else
                                {
                                    MessageBox.Show("Phòng đã cho thuê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Mã phòng Không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không thể đặt phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                if (validKH != null)
                {
                    if (ValidData2())
                    {
                        if (t1==DateTime.Today.Date && t1<t2)
                        {
                            Phong validP = db.Phongs.SingleOrDefault(p => p.MaPhong == txtmaphong.Text);
                            if (validP != null)
                            {
                                if (validP.TinhTrang == "Empty")
                                {
                                    int max = 0;
                                    if (db.DatPhongs.Select(x => x).Count() > 0)
                                    {
                                        max = db.DatPhongs.Max(a => a.Id);
                                    }
                                    DatPhong dp = new DatPhong();
                                    dp.Id = max + 1;
                                    dp.SoCmnd = txtsocmnd.Text;
                                    dp.HoTen = txthoten.Text;
                                    dp.Sdt = txtsdt.Text;
                                    dp.NgayDatPhong = dtpdatphong.Value;
                                    dp.NgayDi = dtpngaydi.Value;
                                    dp.MaPhong = txtmaphong.Text;
                                    dp.TinhTrangDp = "Chưa trả phòng";
                                    validP.TinhTrang = "Use";
                                    db.DatPhongs.Add(dp);
                                    db.SaveChanges();
                                    LoadData();
                                    LoadData2();
                                    MessageBox.Show("Đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtmaphong.Clear();
                                }
                                else if(validP.TinhTrang == "Use")
                                {
                                    MessageBox.Show("Phòng đã cho thuê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Mã phòng Không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không thể đặt phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }    
        }
        private void buttraphong_Click(object sender, EventArgs e)
        {
            if (ValidData2())
            {
                DatPhong pXoa = (from t in db.DatPhongs
                                 where t.MaPhong == txtmaphong.Text
                                 select t).FirstOrDefault();
                if (pXoa!=null)
                {
                    if (pXoa.NgayDatPhong.Date == DateTime.Today.Date)
                    {
                            Phong validP = db.Phongs.SingleOrDefault(sp => sp.MaPhong == txtmaphong.Text);
                            if (validP != null)
                            {
                                if (validP.TinhTrang == "Use")
                                {
                                    db.DatPhongs.Remove(pXoa);
                                    validP.TinhTrang = "Empty";
                                    db.SaveChanges();
                                    lammoi();   
                                MessageBox.Show("Hủy đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);    
                                }
                            else
                            {
                                MessageBox.Show("Phòng trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            }
                    }
                    else
                    {
                        MessageBox.Show("Không thể hủy đặt phòng. Vui lòng thanh toán !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                Phong pXoa1 = (from t in db.Phongs
                               where t.MaPhong == txtmaphong.Text
                               select t).FirstOrDefault();
                if (pXoa == null && pXoa1 != null)
                {
                    MessageBox.Show("Phòng trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if(pXoa == null && pXoa1 == null)
                {
                    MessageBox.Show("Mã phòng Không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttim_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtsocmnd.Text))
            {
                MessageBox.Show("Không bỏ trống số cmnd!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DatPhong ptim = (from t in db.DatPhongs
                                 where t.SoCmnd == txtsocmnd.Text
                                 select t).FirstOrDefault();
                if (ptim != null)
                {
                    var query = from p in db.DatPhongs
                                where p.SoCmnd == txtsocmnd.Text
                                select new
                                {
                                    p.SoCmnd,
                                    p.HoTen,
                                    p.Sdt,
                                    p.NgayDatPhong,
                                    p.NgayDi,
                                    p.MaPhong,
                                    p.TinhTrangDp
                                };
                    dgvdatphong.DataSource = query.ToList();
                }
                else
                {
                    MessageBox.Show("Người này chưa đặt phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                KhachHang ktim = (from k in db.KhachHangs
                                 where k.SoCmnd == txtsocmnd.Text
                                 select k).FirstOrDefault();
                if (ktim != null)
                {
                    var query1 = from a in db.KhachHangs
                                 where a.SoCmnd == txtsocmnd.Text
                                 select new
                                 {
                                     a.MaKh,
                                     a.SoCmnd,
                                     a.TenKh,
                                     a.Sdt,
                                     a.DiaChi,
                                 };
                    dgvkhachhang.DataSource = query1.ToList();
                }    
                else
                {
                    MessageBox.Show("Người này không có trong KhachHang!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }
        }

        private void dgvphong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if( index >= 0 )
            {
                txtmaphong.Text = dgvphong.Rows[index].Cells[0].Value.ToString();
            }
        }

        private void dgvdatphong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if( index >= 0 )
            {
                txtsocmnd.Text = dgvdatphong.Rows[index].Cells[0].Value.ToString();
                txthoten.Text = dgvdatphong.Rows[index].Cells[1].Value.ToString();
                txtsdt.Text = dgvdatphong.Rows[index].Cells[2].Value.ToString();
                dtpdatphong.Text = dgvdatphong.Rows[index].Cells[3].Value.ToString();
                dtpngaydi.Text = dgvdatphong.Rows[index].Cells[4].Value.ToString();
                txtmaphong.Text = dgvdatphong.Rows[index].Cells[5].Value.ToString();;
            }
        }

        private void butlammoi_Click(object sender, EventArgs e)
        {
            lammoi();
        }

        private void dgvkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtsocmnd.Text = dgvkhachhang.Rows[index].Cells[1].Value.ToString();
                txthoten.Text = dgvkhachhang.Rows[index].Cells[2].Value.ToString();
                txtsdt.Text = dgvkhachhang.Rows[index].Cells[3].Value.ToString();
                txtdiachi.Text = dgvkhachhang.Rows[index].Cells[4].Value.ToString();
            }
        }

        private void butgiahan_Click(object sender, EventArgs e)
        {
            DateTime t1 = dtpdatphong.Value.Date;
            DateTime t2 = dtpngaydi.Value.Date;
            if (ValidData2())
            {
                DialogResult dlr = MessageBox.Show("Bạn muốn gia hạn?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    DatPhong validP = db.DatPhongs.SingleOrDefault(sp => sp.MaPhong == txtmaphong.Text);
                    if (validP != null)
                    {
                        if( validP.NgayDi >= DateTime.Today.Date && t2 > DateTime.Today.Date && t2 > t1 && validP.NgayDi != t2)
                        {
                            validP.NgayDi = dtpngaydi.Value;
                            db.SaveChanges();
                            MessageBox.Show("Gia hạn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Không thể gia hạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phòng còn trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}