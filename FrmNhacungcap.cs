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
    public partial class FrmNhacungcap : Form
    {
        BTLLTWinContext db = new BTLLTWinContext();
        public FrmNhacungcap()
        {
            InitializeComponent();
        }
        public delegate void Data(string text);
    
        public void funData(string txt)
        {
            txtcv.Text = txt;
        }
        private void HienThiDuLieu()
        {
            var query = from s in db.NhaCcs
                        select new
                        {
                            s.MaNcc,
                            s.TenNcc,
                            s.DiaChi,
                        };
            dtvnhacc.DataSource = query.ToList();
            txt_mancc.Clear();
            txt_tenncc.Clear();
            txt_diachincc.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtcv.Visible = false;
            HienThiDuLieu();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            NhaCc ncc = new NhaCc();
            ncc.MaNcc = txt_mancc.Text;
            ncc.TenNcc = txt_tenncc.Text;
            ncc.DiaChi = txt_diachincc.Text;



            NhaCc mancc = db.NhaCcs.SingleOrDefault(n => n.MaNcc == txt_mancc.Text);
          
            if (mancc == null)
            {
                db.NhaCcs.Add(ncc);
                db.SaveChanges();
                HienThiDuLieu();
            }
            else
            {
                MessageBox.Show("Trùng mã nhà cung cấp!!!", "Lỗi Nhập", MessageBoxButtons.OK);
                txt_mancc.Focus();
                txt_mancc.SelectAll();
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            NhaCc nccxoa = (from x in db.NhaCcs
                                  where x.MaNcc == txt_mancc.Text
                                  select x).FirstOrDefault();
            if (nccxoa != null)
            {
                if (MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN XÓA?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.NhaCcs.Remove(nccxoa);
                    db.SaveChanges();
                    HienThiDuLieu();
                }
            }
            else
            {
                MessageBox.Show("MÃ NCC KHÔNG TỒN TẠI!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_mancc.Focus();
                txt_mancc.SelectAll();
            }
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
            NhaCc nccsua = db.NhaCcs.SingleOrDefault(s => s.MaNcc == txt_mancc.Text);
            if (nccsua != null)
            {
                nccsua.MaNcc = txt_mancc.Text;
                nccsua.TenNcc = txt_tenncc.Text;
                nccsua.DiaChi = txt_diachincc.Text;
               
                db.SaveChanges();
                HienThiDuLieu();
            }
            else
            {
                MessageBox.Show("MÃ NCC KHÔNG TỒN TẠI!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_mancc.Focus();
                txt_mancc.SelectAll();
            }
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            string keyword = txt_tim.Text.Trim();

            var query = from s in db.NhaCcs
                        where s.TenNcc.Contains(keyword)
                        select new
                        {
                            s.MaNcc,
                            s.TenNcc,
                            s.DiaChi
                        };
            dtvnhacc.DataSource = query.ToList();
        }

        private void dataCellclick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
           
            txt_mancc.Text = dtvnhacc.Rows[index].Cells[0].Value.ToString();
            txt_tenncc.Text = dtvnhacc.Rows[index].Cells[1].Value.ToString();
            txt_diachincc.Text = dtvnhacc.Rows[index].Cells[2].Value.ToString();
       
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            txt_mancc.Clear();
            txt_tenncc.Clear();
            txt_diachincc.Clear();
            HienThiDuLieu();
        }
    }
}
