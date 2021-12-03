using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using BTLLTWin.Models;

namespace BTLLTWin
{
    public partial class formtrangchu : Form
    {
        BTLLTWinContext db = new BTLLTWinContext();
        public formtrangchu()
        {
            InitializeComponent();
        }
        public delegate void Data(string text);
        public void funData(string txt)
        {
            txtcv.Text = txt; 
        }
        private void butdangxuat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn đăng xuát?",
            "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                this.Hide();
                formdangnhap form1 = new formdangnhap();
                form1.Show();
            }
        }
     
        private void buttaikhoan_Click(object sender, EventArgs e)
        {
            formtaikhoan form = new formtaikhoan();
            Data data = new Data(form.funData);
            data(txtcv.Text);
            this.Hide();
            form.Show();
        }
        private void formtrangchu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void butnhanvien_Click(object sender, EventArgs e)
        {
            FrmNhanVien form = new FrmNhanVien();
            Data data = new Data(form.funData);
            data(txtcv.Text);
            this.Hide();
            form.Show();
        }

        private void butphong_Click(object sender, EventArgs e)
        {
            formdatphong form = new formdatphong();
            Data data = new Data(form.funData);
            data(txtcv.Text);
            this.Hide();
            form.Show();
        }

        private void btDVKH_Click(object sender, EventArgs e)
        {
            
        }

        private void btMenuDV_Click(object sender, EventArgs e)
        {
            MenuDV form = new MenuDV();
            Data data = new Data(form.funData);
            data(txtcv.Text);
            this.Hide();
            form.Show();
        }

        private void btHd_Click(object sender, EventArgs e)
        {
            frmQuanLyHoaDon form = new frmQuanLyHoaDon();
            Data data = new Data(form.funData);
            data(txtcv.Text);
            this.Hide();
            form.Show();
        }

        private void btVt_Click(object sender, EventArgs e)
        {
            FrmThietbivattu form = new FrmThietbivattu();
            Data data = new Data(form.funData);
            data(txtcv.Text);
            this.Hide();
            form.Show();
        }

        private void btQlyKh_Click(object sender, EventArgs e)
        {
            FrmKhachHang form = new FrmKhachHang();
            Data data = new Data(form.funData);
            data(txtcv.Text);
            this.Hide();
            form.Show();
        }

        private void btQlyPhong_Click(object sender, EventArgs e)
        {
            frmQuanLyPhong form = new frmQuanLyPhong();
            Data data = new Data(form.funData);
            data(txtcv.Text);
            this.Hide();
            form.Show();
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            frmThanhToan form = new frmThanhToan();
            Data data = new Data(form.funData);
            data(txtcv.Text);
            this.Hide();
            form.Show();
        }

        private void btDatNCC_Click(object sender, EventArgs e)
        {
            FrmDatDVNCC form = new FrmDatDVNCC();
            Data data = new Data(form.funData);
            data(txtcv.Text);
            this.Hide();
            form.Show();
        }

        private void btNCC_Click(object sender, EventArgs e)
        {
            FrmNhacungcap form = new FrmNhacungcap();
            Data data = new Data(form.funData);
            data(txtcv.Text);
            this.Hide();
            form.Show();
        }

        private void formtrangchu_Load(object sender, EventArgs e)
        {
            txtcv.Visible = false;
           if(txtcv.Text=="Lễ tân")
            {
                QLY.Visible = false;
            }
            else
            {
                LeTan.Visible = false;
            }
        }

        private void thanhToánSauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DichVuKH form = new DichVuKH();
            Data data = new Data(form.funData);
            data(txtcv.Text);
            this.Hide();
            form.Show();
        }

        private void thanhToánTrựcTiếpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHDDV form = new frmHDDV();
            Data data = new Data(form.funData);
            data(txtcv.Text);
            this.Hide();
            form.Show();
        }

        private void hóaĐơnDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHDDV form = new frmHDDV();
            Data data = new Data(form.funData);
            data(txtcv.Text);
            this.Hide();
            form.Show();
        }

        private void thanhToánTrựcTiếpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHDDV form = new frmHDDV();
            Data data = new Data(form.funData);
            data(txtcv.Text);
            this.Hide();
            form.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
