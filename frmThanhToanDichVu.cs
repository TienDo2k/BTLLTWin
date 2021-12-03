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
using BTLLTWin.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace BTLLTWin
{
    public partial class frmThanhToanDichVu : Form
    {
        BTLLTWinContext db = new BTLLTWinContext();
        public frmThanhToanDichVu()
        {
            InitializeComponent();
        }
        public delegate void Data(string text);
        public void funData(string txt)
        {
            txtcv.Text = txt;
        }
        private void frmThanhToanDichVu_Load(object sender, EventArgs e)
        {
            txtcv.Visible = false;
            HienThi();
            
        }

        private void HienThi()
        {
            var query = from k in db.KhachHangs

                        join d in db.DichVuKhachHangs on k.MaKh equals d.MaKh
                        where d.TinhTrang != "Đã thanh toán" 
                        select new
                        {
                            d.MaDichVuNavigation.TenDichVu,
                            d.NgaySuDung,
                            d.SoLuong,
                            d.MaDichVuNavigation.DonGia,
                            Tongtien = d.SoLuong * d.MaDichVuNavigation.DonGia,
                        };
            dvgTTDV.DataSource = query.ToList();
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            string keyword = txt_tim.Text.Trim();
            var tim = from k in db.KhachHangs
                      join d in db.DichVuKhachHangs on k.MaKh equals d.MaKh
                      where d.TinhTrang != "Đã thanh toán"
                      && k.TenKh.Contains(keyword)
                      select new
                      {    
                            d.MaDichVuNavigation.TenDichVu,
                            d.NgaySuDung,
                            d.SoLuong,
                            d.MaDichVuNavigation.DonGia,
                            Tongtien = d.SoLuong * d.MaDichVuNavigation.DonGia,
                      };
            if (tim.Count() == 0)
            {
                MessageBox.Show("Khách hàng không tồn tại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_tim.Focus();
                txt_tim.SelectAll();
            }
            else
            {
                dvgTTDV.DataSource = tim.ToList();
                double tongtien = 0;
                for (int i = 0; i < dvgTTDV.Rows.Count; i++)
                {
                    double tt = Convert.ToDouble(dvgTTDV.Rows[i].Cells[4].Value);
                    tongtien += tt;
                }
                txtTongTien.Text = tongtien.ToString();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            formtrangchu form = new formtrangchu();
            Data data = new Data(form.funData);
            data(txtcv.Text);
            form.Show();
            Visible = false;
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult select = MessageBox.Show("Bạn có muốn thanh toán ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (select == DialogResult.Yes)
                {
                    string keyword = txt_tim.Text.Trim();
                    var update1 = db.DichVuKhachHangs.Where(c => c.TinhTrang=="Chưa Thanh Toán" && c.MaKhNavigation.TenKh.Contains(keyword));
                    foreach ( var item in update1) { item.TinhTrang = "Đã Thanh Toán"; }
                    db.SaveChanges();
                    var tim = from k in db.KhachHangs
                              join d in db.DichVuKhachHangs on k.MaKh equals d.MaKh
                              where d.TinhTrang == "Đã thanh toán"
                              where k.TenKh.Contains(keyword)
                              select new
                              {
                                  d.MaDichVuNavigation.TenDichVu,
                                  d.NgaySuDung,
                                  d.SoLuong,
                                  d.MaDichVuNavigation.DonGia,
                                  Tongtien = d.SoLuong * d.MaDichVuNavigation.DonGia,
                              };
                    dvgTTDV.DataSource = tim.ToList();
                    DialogResult hoi = MessageBox.Show("Bạn có muốn lấy hóa đơn k ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (hoi == DialogResult.Yes)
                    {
                        inhd();
                    }

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Không thể thanh toán", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private void dvgTTDV_CellClick(object sender, DataGridViewCellEventArgs a)
        {
            var tim = from k in db.KhachHangs
                      join d in db.DichVuKhachHangs on k.MaKh equals d.MaKh
                      select new
                      {
                          k.TenKh
                      };
            string s = "";
            if (a.RowIndex >= 0)
            {
                DataGridViewRow row = this.dvgTTDV.Rows[a.RowIndex];
                s = row.Cells[0].Value.ToString();
            }
        }

        private void inhd()
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
                PdfPTable table3 = new PdfPTable(2);
                float[] columnsWidth = { 1, 1 };
                table.SetWidths(columnsWidth);
                table.DefaultCell.BorderWidth = 0;
                table.DefaultCell.Padding = 10;
                table.WidthPercentage = 100;
                table.HorizontalAlignment = Element.ALIGN_CENTER;
       
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

                Phrase phrase2 = new Phrase("\n HÓA ĐƠN DỊCH VỤ ", fontHearder);
                PdfPCell pdfPCell2 = new PdfPCell(phrase2);
                pdfPCell2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell2.Colspan = 2;
                pdfPCell2.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfPCell2.PaddingBottom = 25;
                table.AddCell(pdfPCell2);

                // lấy tên khách hàng 
                string ten = txt_tim.Text; 
                Phrase phrase4 = new Phrase("\n Tên Khách Hàng :\t" + ten, fontHearder);
                PdfPCell pdfPCell4 = new PdfPCell(phrase4);
                pdfPCell4.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell4.Colspan = 3;
                pdfPCell4.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfPCell4.PaddingBottom = 25;
                pdfPCell4.PaddingLeft = 15;
                table3.AddCell(pdfPCell4);

                //table Sản phẩm
                PdfPTable tableProduct = new PdfPTable(dvgTTDV.ColumnCount);
                tableProduct.DefaultCell.PaddingBottom = 10;
                tableProduct.DefaultCell.PaddingTop = 10;
                tableProduct.WidthPercentage = 90;
                tableProduct.HorizontalAlignment = Element.ALIGN_CENTER;
                tableProduct.DefaultCell.BorderWidth = 1;

                //add headertext
                foreach (DataGridViewColumn column in dvgTTDV.Columns)
                {
                    PdfPCell pdfPCell = new PdfPCell(new Phrase(column.HeaderText, fontBold));
                    pdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfPCell.PaddingBottom = 4;
                    tableProduct.AddCell(pdfPCell);
                }

                // add cell
                foreach (DataGridViewRow row in dvgTTDV.Rows)
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
                document.Add(table3);
                document.Add(parablank);
                document.Add(tableProduct);
                document.Add(parablank);
                document.Add(table1);
                document.Close();
                stream.Close();
                MessageBox.Show("In hóa đơn thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                try
                {
                    System.Diagnostics.Process.Start("explorer.exe", savefile.FileName); // XML NHẬP
                }
                catch (Exception)
                {
                    System.Diagnostics.Process.Start("msedge.exe", savefile.FileName);

                }
            }
        }

        private void txt_tim_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
