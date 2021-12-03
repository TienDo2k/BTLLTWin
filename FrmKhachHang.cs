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
    public partial class FrmKhachHang : Form
    {
        public FrmKhachHang()
        {
            InitializeComponent();
        }
        public delegate void Data(string text);
        public void funData(string txt)
        {
            txtcv.Text = txt;
        }
        BTLLTWinContext db = new BTLLTWinContext();
        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }
        private bool ValidData()
        {
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng");
                txtMaKH.Focus();
                return false;
            }
            if (txtTenKH.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng");
                txtTenKH.Focus();
                return false;
            }

            if (txtSoCMND.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số CMND");
                txtSoCMND.Focus();
                return false;
            }
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại");
                txtSDT.Focus();
                return false;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ");
                txtDiaChi.Focus();
                return false;
            }
            return true;

        }
        private void HienThiDuLieu()
        {

            var query = from s in db.KhachHangs
                        select new
                        {
                            s.MaKh,
                            s.TenKh,
                            s.SoCmnd,
                            s.Sdt,
                            s.DiaChi
                        };
            //Hiển thị lên datagrid view
            dataGridView1.DataSource = query.ToList();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                KhachHang kh = new KhachHang();
                var query1 = from s in db.KhachHangs
                             where s.MaKh == txtMaKH.Text
                             select s;


                if (query1.Any())
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại");
                    return;
                }
                else
                {
                    kh.MaKh = txtMaKH.Text;
                    kh.TenKh = txtTenKH.Text;
                    kh.SoCmnd = txtSoCMND.Text;
                    kh.Sdt = txtSDT.Text;
                    kh.DiaChi = txtDiaChi.Text;

                    db.KhachHangs.Add(kh);
                    db.SaveChanges();
                    HienThiDuLieu();
                }

            }
        }

        private void FrmKhachHang_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            txtMaKH.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtTenKH.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtSoCMND.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                {
                    var query = from s in db.KhachHangs
                                where s.MaKh == txtMaKH.Text
                                select s;

                    if (!query.Any())
                    {
                        MessageBox.Show("Mã muốn sửa không tồn tại");
                        return;

                    }
                    else
                    {
                        KhachHang khSua = query.SingleOrDefault();
                        khSua.TenKh = txtTenKH.Text;
                        khSua.SoCmnd = txtSoCMND.Text;
                        khSua.Sdt = txtSDT.Text;
                        khSua.DiaChi = txtDiaChi.Text;
                        db.SaveChanges();
                        HienThiDuLieu();
                    }
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            var query = from s in db.KhachHangs
                        where s.MaKh == txtMaKH.Text
                        select s;

            if (!query.Any())
            {
                MessageBox.Show("Mã muốn xóa không tồn tại");
                return;

            }

            KhachHang khXoa = (from s in db.KhachHangs
                          where s.MaKh == txtMaKH.Text
                          select s).FirstOrDefault();

            DialogResult tl = MessageBox.Show("Bạn muốn xóa", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                db.KhachHangs.Remove(khXoa);

                db.SaveChanges();

                HienThiDuLieu();
            }
            else
            {
                txtMaKH.Clear();
                HienThiDuLieu();
            }
        }

        private void txtTim_Click(object sender, EventArgs e)
        {
            var query = from s in db.KhachHangs
                        where s.MaKh == txtMaKH.Text
                        select s;

            if (!query.Any())
            {
                MessageBox.Show("Mã muốn tìm không tồn tại");
                return;

            }
            else
            {
                var query1 = from s in db.KhachHangs
                            where s.MaKh == txtMaKH.Text
                            select new
                            {
                                s.MaKh,
                                s.TenKh,
                                s.SoCmnd,
                                s.Sdt,
                                s.DiaChi
                            };
                //Hiển thị lên datagrid view
                dataGridView1.DataSource = query1.ToList();
            }
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSoCMND.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            HienThiDuLieu();
            txtMaKH.Focus();
            HienThiDuLieu();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                formtrangchu form = new formtrangchu();
                Data data = new Data(form.funData);
                data(txtcv.Text);
                form.Show();
                Visible = false;
            }
            else
            {

                HienThiDuLieu();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
