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
using System.Text.RegularExpressions;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;

namespace BTLLTWin
{
    public partial class FrmBaoTri : Form
    {
        BTLLTWinContext db = new BTLLTWinContext();
        public delegate void Data(string text);

        public void funData(string txt)
        {
            txtcv.Text = txt;
        }

        public FrmBaoTri()
        {
            InitializeComponent();
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

            if (txt_phongsd.Text == "")
            {
                errorProvider1.SetError(txt_phongsd, "Bạn phải nhập phòng sử dụng!");
                txt_phongsd.Focus();
                return false;
            }
            if (txt_noidung.Text == "")
            {
                errorProvider1.SetError(txt_noidung, "Bạn phải nhập nội dung bảo trì!");
                txt_noidung.Focus();
                return false;
            }
            if (txt_chuki.Text == "")
            {
                errorProvider1.SetError(txt_chuki, "Bạn phải nhập tình trạng!");
                txt_chuki.Focus();
                return false;
            }
            return true;
        }
        private void bt_baotri_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                int count = 0;
                count = dtv_baotri.Rows.Count;
                string chuoi = "";
                int chuoi2 = 0;
                chuoi = Convert.ToString(dtv_baotri.Rows[count - 1].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                if (chuoi2 + 1 < 10)
                    txt_mabaotri.Text = "BT0" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txt_mabaotri.Text = "BT" + (chuoi2 + 1).ToString();

                BaoTri bt = new BaoTri();
                    bt.MaBaoTri = txt_mabaotri.Text;
                    bt.MaPhong = txt_phongsd.Text;
                    bt.MaVatTu = txt_mavt.Text;
                    bt.TenVatTu = txt_tenvt.Text;
                    bt.NgayBaoTri = dt_thoigian.Value;
                    bt.NoiDung = txt_noidung.Text;
                    bt.ChuKi = int.Parse(txt_chuki.Text);
                    bt.NgayBaoTriKeTiep = dt_thoigian.Value.AddMonths(bt.ChuKi);
                    BaoTri mabt = db.BaoTris.SingleOrDefault(n => n.MaBaoTri == txt_mabaotri.Text);

                if (mabt == null)
                { 
                   
                    db.BaoTris.Add(bt);
                    db.SaveChanges();
                    HienThiDuLieu();
                }
                else
                {
                    MessageBox.Show("Trùng mã bảo trì!!!", "Lỗi Nhap", MessageBoxButtons.OK);
                    txt_mabaotri.Focus();
                    txt_mabaotri.SelectAll();
                }
                
            }
        }
       
        private void HienThiDuLieu()
        {
            var query = from s in db.BaoTris
                        select new
                        {
                            s.MaBaoTri,
                            s.NgayBaoTri,
                            s.MaVatTu,
                            s.TenVatTu,
                            s.MaPhong,
                            s.NoiDung,
                            s.ChuKi,
                            s.NgayBaoTriKeTiep,
                            

                        };
            dtv_baotri.DataSource = query.ToList();
            txt_mavt.Clear();
            txt_tenvt.Clear();
            txt_chuki.Clear();
            txt_noidung.Clear();
            txt_mabaotri.Clear();
            txt_phongsd.Clear();
        }
        private void LoadVatTu()
        {
            var query = from v in db.ThietBiVatTus
                        select new
                        {
                            v.MaVatTu,
                            v.TenVatTu,
                            v.MaPhong
                        };
            dtv_thietbi.DataSource = query.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
        
            FrmThietbivattu form1 = new FrmThietbivattu();
            Data data = new Data(form1.funData);
            data(txtcv.Text);
            form1.Show();
            Visible = false;
        }

        private void bt_lichsu_Click(object sender, EventArgs e)
        {
            string keyword = txt_tenvt.Text.Trim();
            dtv_baotri.DataSource = db.BaoTris.Where(emp => emp.TenVatTu.Contains(keyword)).ToList();
        }

        private void dtv_thietbi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FrmBaoTri_Load(object sender, EventArgs e)
        {
            dt_thoigian.Format = DateTimePickerFormat.Custom;
            dt_thoigian.CustomFormat = "dd-MM-yyyy";
            dtpthoigian.Format = DateTimePickerFormat.Custom;
            dtpthoigian.CustomFormat = "dd-MM-yyyy";
            LoadVatTu();
            HienThiDuLieu();
        }

        private void dataCellclick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txt_mavt.Text = dtv_thietbi.Rows[index].Cells[0].Value.ToString();
            txt_tenvt.Text = dtv_thietbi.Rows[index].Cells[1].Value.ToString();
            txt_phongsd.Text = dtv_thietbi.Rows[index].Cells[2].Value.ToString();
        }

        private void dtv_baotri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void databtCellclick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txt_mabaotri.Text = dtv_baotri.Rows[index].Cells[0].Value.ToString();
                dt_thoigian.Text = dtv_baotri.Rows[index].Cells[1].Value.ToString();
                txt_mavt.Text = dtv_baotri.Rows[index].Cells[2].Value.ToString();
                txt_tenvt.Text = dtv_baotri.Rows[index].Cells[3].Value.ToString();
                txt_phongsd.Text = dtv_baotri.Rows[index].Cells[4].Value.ToString();
                txt_noidung.Text = dtv_baotri.Rows[index].Cells[5].Value.ToString();
                txt_chuki.Text = dtv_baotri.Rows[index].Cells[6].Value.ToString();
                dtpthoigian.Text = dtv_baotri.Rows[index].Cells[7].Value.ToString();
            }
        }

        private void txt_phongsd_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_mavt_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txt_mavt, "");
        }

        private void txt_tenvt_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txt_tenvt, "");
        }

        private void txt_phongsd_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txt_phongsd, "");
        }

        private void txt_noidung_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txt_noidung, "");
        }

        private void txt_chuki_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txt_chuki, "");
        }
        private static bool IsNumber(string val)
        {
             if (val != "")
                     return Regex.IsMatch(val, @"^[0-9]\d*\.?[0]*$");
                     else return true;
        }
        private void txt_chuki_TextChanged_1(object sender, EventArgs e)
        {
            if (IsNumber(txt_chuki.Text) != true)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ, không được nhập ký tự", "Thông báo");
                txt_chuki.Text = "";
            }
        }

        private void txt_mabaotri_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txt_mabaotri.Clear();
            txt_mavt.Clear();
            txt_tenvt.Clear();
            txt_noidung.Clear();
            txt_phongsd.Clear();
            txt_chuki.Clear();
            HienThiDuLieu();
            txt_mabaotri.Focus();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            String filename = "PBT";
            var savefile = new SaveFileDialog();
            savefile.FileName = filename;
            savefile.DefaultExt = ".pdf";
            if (savefile.ShowDialog() == DialogResult.OK)
            { // set up để thêm dữ liệu
                iTextSharp.text.Document document = new iTextSharp.text.Document(PageSize.A4, 10f, 20f, 20f, 20f);
                Stream stream = new FileStream(savefile.FileName, FileMode.Create);
                PdfWriter.GetInstance(document, stream);
                document.Open();

                PdfPTable table = new PdfPTable(2);
                PdfPTable table1 = new PdfPTable(2);
                float[] columnsWidth = { 1, 1 };
                table.SetWidths(columnsWidth);
                table.DefaultCell.BorderWidth = 0;
                table.DefaultCell.Padding = 10;
                table.WidthPercentage = 100;
                table.HorizontalAlignment = Element.ALIGN_CENTER;
                // font chữ
                string FontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                BaseFont bf = BaseFont.CreateFont(FontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font fontHearder = new iTextSharp.text.Font(bf, 15, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font fontBold = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font font8 = new iTextSharp.text.Font(bf, 8, iTextSharp.text.Font.NORMAL);

                Chunk b = new Chunk(" NHÀ NGHỈ BÌNH YÊN \n", fontHearder);
                Paragraph a = new Paragraph();
                a.Alignment = Element.ALIGN_CENTER;
                a.Add(b);

                Phrase phrase2 = new Phrase("\n PHIẾU BẢO TRÌ VÂT TƯ, THIẾT BỊ ", fontHearder);
                PdfPCell pdfPCell2 = new PdfPCell(phrase2);
                pdfPCell2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell2.Colspan = 3;
                pdfPCell2.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfPCell2.PaddingBottom = 25;
                //pdfPCell2.PaddingLeft = ;
                table.AddCell(pdfPCell2);

                //table Sản phẩm
                PdfPTable tableProduct = new PdfPTable(dtv_baotri.ColumnCount);
                tableProduct.DefaultCell.PaddingBottom = 10;
                tableProduct.DefaultCell.PaddingTop = 10;
                tableProduct.WidthPercentage = 90;
                tableProduct.HorizontalAlignment = Element.ALIGN_CENTER;
                tableProduct.DefaultCell.BorderWidth = 1;

                //add headertext
                foreach (DataGridViewColumn column in dtv_baotri.Columns)
                {
                    PdfPCell pdfPCell = new PdfPCell(new Phrase(column.HeaderText, fontBold));
                    pdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfPCell.PaddingBottom = 4;
                    tableProduct.AddCell(pdfPCell);
                }

                // add cell
                foreach (DataGridViewRow row in dtv_baotri.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        PdfPCell pdfPCell = new PdfPCell(new Phrase(cell.Value.ToString(), font));
                        pdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfPCell.PaddingBottom = 4;
                        tableProduct.AddCell(pdfPCell);
                    }
                }

                Paragraph parablank = new Paragraph(" ", font);
                document.Add(a);
                document.Add(table);
                document.Add(parablank);
                document.Add(tableProduct);
                document.Add(parablank);
                document.Add(table1);
                document.Close();
                stream.Close();
                MessageBox.Show("In hóa đơn thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    System.Diagnostics.Process.Start("explorer.exe", savefile.FileName);
                }
                catch (Exception)
                {
                    System.Diagnostics.Process.Start("msedge.exe", savefile.FileName);

                }

            }

        }
    }
}
