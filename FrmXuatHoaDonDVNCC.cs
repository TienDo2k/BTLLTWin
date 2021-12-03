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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace BTLLTWin
{
    public partial class FrmXuatHoaDonDVNCC : Form
    {
        public delegate void Data(string text);
        public void funData(string txt)
        {
            txtcv.Text = txt;
        }
        BTLLTWinContext db = new BTLLTWinContext();
        public FrmXuatHoaDonDVNCC()
        {
            InitializeComponent();
        }

        private string MaDat;
        private void HienThiDuLieu()
        {

            var query = from s in db.DatDichVus
                        where s.MaDatDv == txtMaDat.Text
                        select new
                        {
                            s.MaDichVu,                                                  
                            s.Sld,
                            s.DonGia,
                            s.NgayDatDv,
                            s.MaNcc
                            
                        };

            dataGridView1.DataSource = query.ToList();
        }
        private void FrmXuatHoaDonDVNCC_Load(object sender, EventArgs e)
        {
            txtMaDat.Text = MaDat;
            var query2 = from s in db.DatDichVus
                         where s.MaDichVu == txtMaDat.Text
                         select s;
            var dv = query2.FirstOrDefault();

            HienThiDuLieu();
            //var query3 = from ct in db.DatDichVus
            //            where MaDat == txtMaDat.Text
            //            select new
            //            {
                           
            //                ThanhTien = ct.Sld * ct.DonGia
            //            };
            //dataGridView1.DataSource = query3.ToList();
            //Tính tổng tiền phiếu xuất
            double tongtien = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                double tt = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value)* Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                tongtien += tt;
            }
            txtTongTien.Text = tongtien.ToString();
        }
        public FrmXuatHoaDonDVNCC(string MaDat)
        {
            InitializeComponent();
            this.MaDat = MaDat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                Visible = false;
                FrmDatDVNCC form1 = new FrmDatDVNCC();
                Data data = new Data(form1.funData);
                data(txtcv.Text);
                form1.Show();
            }
            else
            {


            }
        }

        private void btInHoaDon_Click(object sender, EventArgs e)
        {
            String filename = "HD";
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
                Phrase phrase5 = new Phrase("Mã hóa đơn :" + txtMaDat.Text, fontHearder);
                Paragraph a = new Paragraph();
                a.Alignment = Element.ALIGN_CENTER;
                a.Add(b);

                Phrase phrase2 = new Phrase("\n HÓA ĐƠN ĐẶT DỊCH VỤ NHÀ CUNG CẤP ", fontHearder);
                PdfPCell pdfPCell2 = new PdfPCell(phrase2);
                pdfPCell2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell2.Colspan = 3;
                pdfPCell2.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfPCell2.PaddingBottom = 25;
                //pdfPCell2.PaddingLeft = ;
                table.AddCell(pdfPCell2);

                Phrase phrase4 = new Phrase("Mã hóa đơn :" + txtMaDat.Text, fontHearder);
                PdfPCell pdfPCell4 = new PdfPCell(phrase4);
                pdfPCell4.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell4.Colspan = 3;
                pdfPCell4.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfPCell4.PaddingBottom = 25;
                //pdfPCell2.PaddingLeft = ;
                table.AddCell(pdfPCell4);

                //table Sản phẩm
                PdfPTable tableProduct = new PdfPTable(dataGridView1.ColumnCount);
                tableProduct.DefaultCell.PaddingBottom = 10;
                tableProduct.DefaultCell.PaddingTop = 10;
                tableProduct.WidthPercentage = 90;
                tableProduct.HorizontalAlignment = Element.ALIGN_CENTER;
                tableProduct.DefaultCell.BorderWidth = 1;

                //add headertext
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    PdfPCell pdfPCell = new PdfPCell(new Phrase(column.HeaderText, fontBold));
                    pdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfPCell.PaddingBottom = 4;
                    tableProduct.AddCell(pdfPCell);
                }

                // add cell
                foreach (DataGridViewRow row in dataGridView1.Rows)
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

                Phrase phrase3 = new Phrase("Tổng tiền thanh toán :" + txtTongTien.Text, fontHearder);
                PdfPCell pdfPCell3 = new PdfPCell(phrase3);
                pdfPCell3.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell3.Colspan = 3;
                pdfPCell3.HorizontalAlignment = Element.ALIGN_RIGHT;
                pdfPCell3.PaddingBottom = 25;
                pdfPCell3.PaddingRight = 20;
                table1.AddCell(pdfPCell3);

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
