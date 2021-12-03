using BTLLTWin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace BTLLTWin
{
    public partial class FrmDatDVNCC : Form
    {
        public FrmDatDVNCC()
        {
            InitializeComponent();
        }
        public delegate void Data(string text);
        public void funData(string txt)
        {
            txtcv.Text = txt;
        }
        BTLLTWinContext db = new BTLLTWinContext();
        private bool ValidData()
        {
            if (txtMaDat.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã đặt ");
                txtMaDat.Focus();
                return false;
            }
            return true;

        }
        private void HienThiDuLieu()
        {

            var query = from s in db.DatDichVus
                        select new
                        {
                            s.MaDatDv,
                            s.MaNcc,
                            s.MaDichVu,
                            s.NgayDatDv,
                            s.Sld,
                            s.DonGia,
                            s.TrangThai
                        };

            dataGridView1.DataSource = query.ToList();
        }
        private void FrmDatDVNCC_Load(object sender, EventArgs e)
        {

            CbSLDV.Items.Add("1");
            CbSLDV.Items.Add("2");
            CbSLDV.Items.Add("3");
            CbSLDV.Items.Add("4");
            CbSLDV.Items.Add("5");

            CbSLDV.SelectedIndex = 0;

            HienThiDuLieu();
        }
     
        private void btThem_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                DatDichVu ddv = new DatDichVu();

                var query = from s in db.DatDichVus
                            where s.MaDatDv == txtMaDat.Text
                            select s;


                if (query.Any())
                {
                    MessageBox.Show("Mã đặt đã tồn tại");
                    return;

                }
                FrmThemDVNCC form2 = new FrmThemDVNCC(txtMaDat.Text, CbSLDV.Text);
                Data data = new Data(form2.funData);
                data(txtcv.Text);
                Visible = false;
                form2.Show();
            }


        }
     
        private void btXoa_Click(object sender, EventArgs e)
        {
            var query = from s in db.DatDichVus
                        where s.MaDatDv == txtMaDat.Text
                        select s;


            if (query.Any())
            {
                do
                {
                    DatDichVu ddvXoa = query.FirstOrDefault();

                    if (ddvXoa.TrangThai == "Chưa")
                    {
                      
                            db.DatDichVus.Remove(ddvXoa);
                            db.SaveChanges();
                            HienThiDuLieu();
                       
                    }
                    else
                    {
                        
                            var cc = query.FirstOrDefault();
                            var query2 = from s in db.MenuDichVus
                                         where s.MaDichVu == cc.MaDichVu
                                         select s;
                            var dv = query2.FirstOrDefault();
                            
                            if (dv.Slc - cc.Sld < 0)
                            {
                                MessageBox.Show("Không thể xóa vì số lượng có không đủ để xóa");
                                return;
                            }
                            else
                            {
                                dv.Slc = dv.Slc - cc.Sld;
                                db.DatDichVus.Remove(ddvXoa);
                            }
                            db.SaveChanges();
                            HienThiDuLieu();
                        
                    }

                    } while (query.Any());
            }
            else
            {
                MessageBox.Show("Mã xóa không tồn tại");
                return;
            }
            HienThiDuLieu();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            var query = from s in db.DatDichVus
                        where s.MaDatDv == txtMaDat.Text
                        select s;
            if (!query.Any())
            {
                MessageBox.Show("Không tồn tại mã cần tìm");
                return;

            }
            else
            {
                dataGridView1.DataSource = query.ToList();
            }
            //if (ValidData())
            //{
            //    DatDichVu ddv = new DatDichVu();

            //    var query = from s in db.DatDichVus
            //                where s.MaDatDv == txtMaDat.Text
            //                select s;


            //    if (!query.Any())
            //    {
            //        MessageBox.Show("Không có mã đặt cần tìm");
            //        return;

            //    }
            //    FrmTimKiemDatDVNCC form2 = new FrmTimKiemDatDVNCC(txtMaDat.Text);
            //    this.Hide();
            //    form2.Show();
            //}
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSuaDatDVNCC form1 = new FrmSuaDatDVNCC();
            form1.Show();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                this.Hide();
                formtrangchu form1 = new formtrangchu();
                form1.Show();
            }
            else
            {

                HienThiDuLieu();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                DatDichVu ddv = new DatDichVu();

                var query = from s in db.DatDichVus
                            where s.MaDatDv == txtMaDat.Text
                            select s;


                if (!query.Any())
                {
                    MessageBox.Show("Không có mã đặt");
                    return;

                }
                FrmXuatHoaDonDVNCC form2 = new FrmXuatHoaDonDVNCC(txtMaDat.Text);
                this.Hide();
                form2.Show();

            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
                int index = e.RowIndex;
                txtMaDat.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                
            
        }
    }
}
