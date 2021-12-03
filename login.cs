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
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace BTLLTWin
{
    public partial class formdangnhap : Form
    {
        BTLLTWinContext db = new BTLLTWinContext();

        public formdangnhap()
        {
            InitializeComponent();
        }
        #region
        bool ValidData()
        {
            if (String.IsNullOrEmpty(txttk.Text))
            {
                MessageBox.Show("Không bỏ trống tài khoản!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            else if (String.IsNullOrEmpty(txtmk.Text))
            {
                MessageBox.Show("Không bỏ trống mật khẩu!","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }
        #endregion
        public delegate void Data(string text);
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn thoát?",
            "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void butdangnhap_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                NhanVien nv = (from n in db.NhanViens
                               where n.MaNv == txttk.Text
                               select n).FirstOrDefault();
                TaiKhoan tk = (from a in db.TaiKhoans
                               where a.MaNv == txttk.Text
                               select a).FirstOrDefault();
                if (nv != null)
                {
                    string b = nv.ChucVu.ToString();
                    formtrangchu form = new formtrangchu();
                    Data data = new Data(form.funData);
                    data(b);
                    if (tk != null)
                    {
                        if (tk.MatKhau == txtmk.Text)
                        {
                            this.Hide();
                            form.Show();
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Nhân viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }
        }
        private void formdangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void formdangnhap_Enter(object sender, EventArgs e)
        {
            butdangnhap_Click(sender,e);
        }

       
    }
}
