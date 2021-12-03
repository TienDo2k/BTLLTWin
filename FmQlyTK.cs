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


namespace BTLLTWin
{
    public partial class formtaikhoan : Form
    {
        BTLLTWinContext db = new BTLLTWinContext();


        public formtaikhoan()
        {
            InitializeComponent();
        }

        #region
        void LoadData()
        {
            var query = from p in db.TaiKhoans
                        select new
                        {
                            p.MaNv,
                            p.MatKhau,
                        };
            dgvtaikhoan.DataSource = query.ToList();
        }
        bool ValidData1()
        {
            if (String.IsNullOrEmpty(cbmanv.Text))
            {
                MessageBox.Show("Không bỏ trống mã nhân viên!");
                return false;           
            }
            else
                return true;
        }
        bool ValidData2()
        {
            if (String.IsNullOrEmpty(cbmanv.Text))
            {
                MessageBox.Show("Không bỏ trống mã nhân viên!");
                return false;           
            }
            else if (String.IsNullOrEmpty(txtmk.Text))
            {
                MessageBox.Show("Không bỏ trống mật khẩu!");
                return false;
            }    
            else
                return true;
        }
        #endregion
        public delegate void Data(string text);
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

        private void formtaikhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void formtaikhoan_Load(object sender, EventArgs e)
        {
            LoadData();
            txtcv.Visible = false;
            var a = from p in db.NhanViens
                    where p.ChucVu != "Nhân viên"
                    select p;
            cbmanv.DataSource = a.ToList();
            cbmanv.DisplayMember = "MaNV";
            cbmanv.ValueMember = "MaNV";        }

        private void butthem_Click(object sender, EventArgs e)
        {
            if (ValidData2())
            {
                NhanVien validNV = db.NhanViens.SingleOrDefault(nv => nv.MaNv == cbmanv.Text);
                if (validNV != null)
                {
                    if (validNV.ChucVu != "Nhân viên")
                    {
                        if (ValidData2())
                        {
                            TaiKhoan validTK = db.TaiKhoans.SingleOrDefault(sp => sp.MaNv == cbmanv.Text);
                            if (validTK == null)
                            {
                                TaiKhoan tk = new TaiKhoan();
                                tk.MaNv = cbmanv.Text;
                                tk.MatKhau = txtmk.Text;
                                db.TaiKhoans.Add(tk);
                                db.SaveChanges();
                                MessageBox.Show("Thêm thành công!", "Xác nhận", MessageBoxButtons.OK,MessageBoxIcon.Information);
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tạo được tài khoản cho chức vụ nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Nhân viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void butsua_Click(object sender, EventArgs e)
        {
            if (ValidData2())
            {
                DialogResult dlr = MessageBox.Show("Bạn muốn sửa bản ghi?",
                "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    TaiKhoan validNV = db.TaiKhoans.SingleOrDefault(sp => sp.MaNv == cbmanv.Text);
                    if (validNV != null)
                    {
                        validNV.MatKhau = txtmk.Text;
                        db.SaveChanges();
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên Không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }    
            }
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            if (ValidData1())
            {
                DialogResult dlr = MessageBox.Show("Bạn muốn xoá bản ghi?",
               "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    TaiKhoan tkXoa = (from t in db.TaiKhoans
                                      where t.MaNv == cbmanv.Text
                                      select t).FirstOrDefault();
                    if (tkXoa != null)
                    {
                        db.TaiKhoans.Remove(tkXoa);
                        db.SaveChanges();
                        MessageBox.Show("Xóa thành công !", "Xác nhận xoá", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void dgvtaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index>=0)
            {
                cbmanv.Text = dgvtaikhoan.Rows[index].Cells[0].Value.ToString();
                txtmk.Text = dgvtaikhoan.Rows[index].Cells[1].Value.ToString();
            }
        }

        private void dgvtaikhoan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           if (e.ColumnIndex == 1 && e.Value != null )
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }    
        }

      
    }
}
