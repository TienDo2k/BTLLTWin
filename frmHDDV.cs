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
    public partial class frmHDDV : Form
    {
        BTLLTWinContext db = new BTLLTWinContext();
        public delegate void Data(string text);
        public void funData(string txt)
        {
            txtcv.Text = txt;
        }
        public frmHDDV()
        {
            InitializeComponent();
        }

        private void dgvHd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHd.SelectedRows.Count > 0)
            {
                ChuyenDL.MaHd = dgvHd.SelectedRows[0].Cells[0].Value.ToString();
                TTTrucTiep d = new TTTrucTiep();
                Data data = new Data(d.funData);
                data(txtcv.Text);
                d.Show();
                Visible = false;
            }
        }

        private void frmHDDV_Load(object sender, EventArgs e)
        {
            dtpNgay.Format = DateTimePickerFormat.Custom;
            dtpNgay.CustomFormat = "dd-MM-yyyy";
            hienthi();
            
        }

        private void hienthi()
        {
            var query = from n in db.HddichVus
                        select new
                        {
                            n.MaHd,
                            n.TenHd,
                            n.NgayLap,
                        };
            dgvHd.DataSource = query.ToList();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (dtpNgay.Value < DateTime.Today.Date)
            {
                MessageBox.Show("Ngày không phù hợp", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                txtMaHD.Text = Tangma();
                HddichVu hd = new HddichVu();
                hd.MaHd = txtMaHD.Text;
                hd.TenHd = "HOÁ ĐƠN DỊCH VỤ";
                hd.NgayLap = dtpNgay.Value;
                db.HddichVus.Add(hd);
                db.SaveChanges();
                MessageBox.Show("Tạo hóa đơn " + txtMaHD.Text + " thành công", "Thông báo", MessageBoxButtons.OK);
                var query = from n in db.HddichVus
                            where n.MaHd== txtMaHD.Text
                            select new
                            {
                                n.MaHd,
                                n.TenHd,
                                n.NgayLap,
                            };
                dgvHd.DataSource = query.ToList();
            }
        }
        private string Tangma()
        {
           
            string ma = "";
            int count = 0;
            count = dgvHd.Rows.Count;
            string chuoi1 = "";
            int chuoi2 = 0;
            chuoi1 = Convert.ToString(dgvHd.Rows[count - 1].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi1.Remove(0, 2)));
            if (chuoi2 + 1 < 10)
            {
                ma = "HD0" + (chuoi2 + 1).ToString();
            }
            else if(chuoi2 + 1 < 100 && chuoi2+1>=10)
            {
                ma = "HD" + (chuoi2 + 1).ToString();
            }
            return ma;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvHd.SelectedRows.Count > 0)
            {
                ChuyenDL.MaHd = dgvHd.SelectedRows[0].Cells[0].Value.ToString();
                TTTrucTiep d = new TTTrucTiep();
                Data data = new Data(d.funData);
                data(txtcv.Text);
                d.Show();
                Visible = false;
            }
        }
    }
}
