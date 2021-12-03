using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BTLLTWin.Models;
namespace BTLLTWin
{
    public partial class FrmThietbivattu : Form
    {
        public delegate void Data(string text);
        public void funData(string txt)
        {
            txtcv.Text = txt;
        }
        private LichSuChuyenDo lichsu;
        public LichSuChuyenDo getLichsu()
        {
            return this.lichsu;
        }
        public void setLichSuChuyenDO(LichSuChuyenDo _lichsu)
        {
            this.lichsu = _lichsu;
        }
        BTLLTWinContext db = new BTLLTWinContext();

        public FrmThietbivattu()
        {
            InitializeComponent();
            lichsu = new LichSuChuyenDo();

        }
        private void bt_luu_Click(object sender, EventArgs e)
        {

            if (ValidData())
            {
                ThietBiVatTu tbvt = new ThietBiVatTu();
                int max = 0;
                if (db.ThietBiVatTus.Select(x => x).Count() > 0)
                {
                    max = db.ThietBiVatTus.Max(a => a.Id);
                }
                tbvt.Id = max + 1;
                tbvt.MaPhong = txt_phongsd.Text;
                tbvt.MaVatTu = txt_mavt.Text;
                tbvt.TenVatTu = txt_tenvt.Text;
                tbvt.NgayChuyenVao = dtpthoigian.Value;
                tbvt.Sl = int.Parse(txt_soluong.Text);
                tbvt.TinhTrang = txt_tinhtrang.Text;
                tbvt.TriGia = float.Parse(txt_trigia.Text);
                db.ThietBiVatTus.Add(tbvt);
                db.SaveChanges();
                LichSuChuyenDo lich = new LichSuChuyenDo();
                int max1 = 0;
                if (db.LichSuChuyenDos.Select(x => x).Count() > 0)
                {
                    max1 = db.LichSuChuyenDos.Max(a => a.MaLichSu);
                }
                lich.Id = tbvt.Id;
                lich.MaLichSu = max1 + 1;
                lich.MaVatTu = txt_mavt.Text;
                lich.MaPhong = txt_phongsd.Text;
                lich.TenVatTu = txt_tenvt.Text;
                lich.NgayChuyenVao = dtpthoigian.Value;
                lich.Sl = Int32.Parse(txt_soluong.Text);
                lich.TinhTrang = txt_tinhtrang.Text;
                lich.TriGia = Double.Parse(txt_trigia.Text);
                db.LichSuChuyenDos.Add(lich);
                db.SaveChanges();
                HienThiDuLieu();
            }


        }

        public void lsu1()
        {
            LichSuChuyenDo lich = new LichSuChuyenDo();
            int max = 0;
            if (db.LichSuChuyenDos.Select(x => x).Count() > 0)
            {
                max = db.LichSuChuyenDos.Max(a => a.MaLichSu);
            }
            lich.Id = Int32.Parse(txt_id.Text);
            lich.MaLichSu = max + 1;
            lich.MaVatTu = txt_mavt.Text;
            lich.MaPhong = txt_phongchuyendi.Text;
            lich.TenVatTu = txt_tenvt.Text;
            lich.NgayChuyenVao = dtpthoigian.Value;
            lich.Sl = Int32.Parse(txt_soluong.Text);
            lich.TinhTrang = txt_tinhtrang.Text;
            lich.TriGia = Double.Parse(txt_trigia.Text);
            db.LichSuChuyenDos.Add(lich);
            db.SaveChanges();
        }
        private void LoadPhong()
        {
            var query = from p in db.Phongs
                        select new
                        {
                            p.MaPhong,
                            p.TenPhong,
                            p.LoaiPhong
                        };
            dtvphong.DataSource = query.ToList();
        }
        private void HienThiDuLieu()
        {
            var query = from s in db.ThietBiVatTus
                        select new
                        {
                            s.Id,
                            s.MaVatTu,
                            s.TenVatTu,
                            s.Sl,
                            s.TriGia,
                            s.NgayChuyenVao,
                            s.TinhTrang,
                            s.MaPhong

                        };
            dtvthietbi.DataSource = query.ToList();
            txt_id.Clear();
            txt_mavt.Clear();
            txt_tenvt.Clear();
            txt_soluong.Clear();
            txt_trigia.Clear();
            txt_tinhtrang.Clear();
            txt_phongsd.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpthoigian.Format = DateTimePickerFormat.Custom;
            dtpthoigian.CustomFormat = "dd-MM-yyyy";
            dtvthietbi.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            HienThiDuLieu();
            LoadPhong();

        }

        private void dataCellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            if (index >= 0)
            {
                txt_id.Text = dtvthietbi.Rows[index].Cells[0].Value.ToString();
                txt_mavt.Text = dtvthietbi.Rows[index].Cells[1].Value.ToString();
                txt_tenvt.Text = dtvthietbi.Rows[index].Cells[2].Value.ToString();
                txt_soluong.Text = dtvthietbi.Rows[index].Cells[3].Value.ToString();
                txt_trigia.Text = dtvthietbi.Rows[index].Cells[4].Value.ToString();
                dtpthoigian.Text = dtvthietbi.Rows[index].Cells[5].Value.ToString();
                txt_tinhtrang.Text = dtvthietbi.Rows[index].Cells[6].Value.ToString();
                txt_phongsd.Text = dtvthietbi.Rows[index].Cells[7].Value.ToString();
            }
        }
        private bool ValidData()
        {
            if (txt_mavt.Text == "")
            {
                errorProvider1.SetError(txt_mavt, "Bạn phải nhập mã vật tư!");
                txt_mavt.Focus();
                return false;
            }
            if (txt_tenvt.Text == "")
            {
                errorProvider1.SetError(txt_tenvt, "Bạn phải nhập tên vật tư!");
                txt_tenvt.Focus();
                return false;
            }

            if (txt_soluong.Text == "")
            {
                errorProvider1.SetError(txt_soluong, "Bạn phải nhập số lượng!");
                txt_soluong.Focus();
                return false;
            }
            if (txt_trigia.Text == "")
            {
                errorProvider1.SetError(txt_trigia, "Bạn phải nhập trị giá!");
                txt_trigia.Focus();
                return false;
            }
            if (txt_tinhtrang.Text == "")
            {
                errorProvider1.SetError(txt_tinhtrang, "Bạn phải nhập tình trạng!");
                txt_tenvt.Focus();
                return false;
            }
            return true;
        }
        private void bt_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN THOÁT?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                formtrangchu form = new formtrangchu();
                Data data = new Data(form.funData);
                data(txtcv.Text);
                form.Show();
                Visible = false;
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                ThietBiVatTu vtsua = db.ThietBiVatTus.SingleOrDefault(s => s.Id == Int32.Parse(txt_id.Text));
                if (vtsua != null)
                {
                    vtsua.MaVatTu = txt_mavt.Text;
                    vtsua.MaPhong = txt_phongsd.Text;
                    vtsua.TenVatTu = txt_tenvt.Text;
                    vtsua.NgayChuyenVao = dtpthoigian.Value;
                    vtsua.Sl = int.Parse(txt_soluong.Text);
                    vtsua.TinhTrang = txt_tinhtrang.Text;
                    vtsua.TriGia = float.Parse(txt_trigia.Text);
                    db.SaveChanges();
                    HienThiDuLieu();
                }
                else
                {
                    MessageBox.Show("MÃ VẬT TƯ KHÔNG TỒN TẠI!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_mavt.Focus();
                    txt_mavt.SelectAll();
                }
            }
        }

        private void txt_mavt_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txt_mavt, "");
        }

        private void txt_tenvt_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txt_tenvt, "");
        }
        private void txt_trigia_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txt_trigia, "");
        }

        private void txt_soluong_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txt_soluong, "");
        }

        private void txt_tinhtrang_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txt_tinhtrang, "");
        }

        private void dtvphong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtvphong.Rows[e.RowIndex];
                txt_phongsd.Text = row.Cells[0].Value.ToString();
            }
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_mavt.Clear();
            txt_tenvt.Clear();
            txt_soluong.Clear();
            txt_trigia.Clear();
            txt_tinhtrang.Clear();
            HienThiDuLieu();
            txt_mavt.Focus();
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            string keyword = txt_tenvt.Text.Trim();

            var query = from s in db.ThietBiVatTus
                        where s.TenVatTu.Contains(keyword)
                        select new
                        {
                            s.Id,
                            s.MaVatTu,
                            s.TenVatTu,
                            s.Sl,
                            s.TriGia,
                            s.NgayChuyenVao,
                            s.TinhTrang,
                            s.MaPhong
                        };
            dtvthietbi.DataSource = query.ToList();
        }

        private void bt_baotri_Click(object sender, EventArgs e)
        {
            FrmBaoTri frm = new FrmBaoTri();
            Data data = new Data(frm.funData);
            data(txtcv.Text);
            frm.Show();
            Visible = false;
        }

        private void bt_lichsu_Click(object sender, EventArgs e)
        {
            FrmChuyenVatTu frm1 = new FrmChuyenVatTu();
            Data data = new Data(frm1.funData);
            data(txtcv.Text);
            frm1.Show();
            Visible = false;
        }

        private void bt_chuyenvt_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                try
                {
                    ThietBiVatTu vtsua = db.ThietBiVatTus.SingleOrDefault(s => s.Id == Int32.Parse(txt_id.Text));
                    if (vtsua != null)    
                    {
                        if (Int32.Parse(txt_soluongchuyen.Text) <= 0)
                        {
                            MessageBox.Show("Số lượng chuyển phải >0", "Thông báo", MessageBoxButtons.OK);
                        }
                       else if (Int32.Parse(txt_soluongchuyen.Text) == int.Parse(txt_soluong.Text))
                        {
                            LichSu1();
                            vtsua.Sl = Int32.Parse(txt_soluong.Text);
                            vtsua.MaPhong = txt_phongchuyendi.Text;
                            vtsua.NgayChuyenVao = dtpthoigian.Value;
                            db.SaveChanges();
                            lsu1();
                            HienThiDuLieu();
                        }
                        else
                        {
                            // LichSu1();
                            vtsua.Sl = int.Parse(txt_soluongchuyen.Text);
                            vtsua.MaPhong = txt_phongchuyendi.Text;
                            vtsua.NgayChuyenVao = dtpthoigian.Value;
                            db.SaveChanges();
                            ThietBiVatTu vt = new ThietBiVatTu();
                            int max = 0;
                            if (db.ThietBiVatTus.Select(x => x).Count() > 0)
                            {
                                max = db.ThietBiVatTus.Max(a => a.Id);
                            }
                            vt.Id = max + 1;
                            vt.MaPhong = txt_phongsd.Text;
                            vt.MaVatTu = txt_mavt.Text;
                            vt.TenVatTu = txt_tenvt.Text;
                            vt.NgayChuyenVao = dtpthoigian.Value;
                            vt.Sl =Int32.Parse(txt_soluong.Text) - Int32.Parse(txt_soluongchuyen.Text);
                            vt.TinhTrang = txt_tinhtrang.Text;
                            vt.TriGia = float.Parse(txt_trigia.Text);
                            db.ThietBiVatTus.Add(vt);
                            db.SaveChanges();
                            LichSuChuyenDo lich = new LichSuChuyenDo();
                            int max1 = 0;
                            if (db.LichSuChuyenDos.Select(x => x).Count() > 0)
                            {
                                max1 = db.LichSuChuyenDos.Max(a => a.MaLichSu);
                            }
                            lich.Id = vt.Id;
                            lich.MaLichSu = max1 + 1;
                            lich.MaVatTu = txt_mavt.Text;
                            lich.MaPhong = txt_phongchuyendi.Text;
                            lich.TenVatTu = txt_tenvt.Text;
                            lich.NgayChuyenVao = dtpthoigian.Value;
                            lich.Sl = Int32.Parse(txt_soluongchuyen.Text);
                            lich.TinhTrang = txt_tinhtrang.Text;
                            lich.TriGia = Double.Parse(txt_trigia.Text);
                            db.LichSuChuyenDos.Add(lich);
                            db.SaveChanges();
                            HienThiDuLieu();
                        }

                    }

                    else
                    {
                        MessageBox.Show("MÃ VẬT TƯ KHÔNG TỒN TẠI!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_mavt.Focus();
                        txt_mavt.SelectAll();
                    }
                }catch(Exception )
                {
                    MessageBox.Show("Chưa nhập phòng chuyển đi!!!", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
        private void LichSu1()
        {
            var query = from s in db.LichSuChuyenDos
                        where s.MaVatTu == txt_mavt.Text && s.MaPhong == txt_phongsd.Text
                        select s;         
            if (query != null)
            {
                
                LichSuChuyenDo ls = query.SingleOrDefault(s=>s.MaVatTu==txt_mavt.Text);
                if (ls != null)
                {
                    ls.NgayChuyenDi = dtpthoigian.Value;
                    ls.Sl = Int32.Parse(txt_soluong.Text);
                    db.SaveChanges();
                }

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
