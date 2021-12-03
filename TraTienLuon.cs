using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTLLTWin.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace BTLLTWin
{
    public partial class TTTrucTiep : Form
    {
        BTLLTWinContext db = new BTLLTWinContext();
        public delegate void Data(string text);
        public void funData(string txt)
        {
            txtcv.Text = txt;
        }
        public TTTrucTiep()
        {
            InitializeComponent();
        }

        private void Loadmenu()
        {
            var query = from menu in db.MenuDichVus
                        select new
                        {
                            menu.MaDichVu,
                            menu.TenDichVu,
                            menu.DonGia,
                            menu.Slc,
                        };
            menu.DataSource = query.ToList();
            a.Text = ChuyenDL.MaHd.ToString();
        }

        private void LoadCTHD()
        {
            var query = from ct in db.CthddichVus
                        join hd in db.HddichVus on ct.MaHd equals hd.MaHd
                        where ct.MaHd == ChuyenDL.MaHd.ToString()
                        select new
                        {
                            ct.MaDichVuNavigation.TenDichVu,
                            ct.MaDichVuNavigation.DonGia,
                            ct.SoLuong,
                            ct.MaHdNavigation.NgayLap,
                            ThanhTien = ct.SoLuong * ct.MaDichVuNavigation.DonGia
                        };
            dgvHDdv.DataSource = query.ToList();
            //Tính tổng tiền phiếu xuất
            double tongtien = 0;
            for (int i = 0; i < dgvHDdv.Rows.Count; i++)
            {
                double tt = Convert.ToDouble(dgvHDdv.Rows[i].Cells[4].Value);
                tongtien += tt;
            }
            txtTongtien.Text = tongtien.ToString();
        }
        private void TTTrucTiep_Load(object sender, EventArgs e)
        {
            LoadCTHD();
            Loadmenu();
            txtcv.Visible = false;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?",
                "Error", MessageBoxButtons.OK) == DialogResult.OK)
            {
                formtrangchu form = new formtrangchu();
                Data data = new Data(form.funData);
                data(txtcv.Text);
                form.Show();
                Visible = false;
            }
        }

        private void menu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.menu.Rows[e.RowIndex];
                txtMa.Text = row.Cells[0].Value.ToString();
                txtTen.Text = row.Cells[1].Value.ToString();
            }
        }
        private void btMua_Click(object sender, EventArgs e)
        {
            try
            {
                var tinhsl = db.MenuDichVus.SingleOrDefault(
                                      menu => menu.MaDichVu == txtMa.Text);
                if (tinhsl.Slc > int.Parse(txtSL.Text))
                {
                    var a = from dv in db.CthddichVus select dv;

                    int max = 0;
                    if (db.CthddichVus.Select(x => x).Count() > 0)
                    {
                        max = db.CthddichVus.Max(a => a.Stt);
                    }
                    CthddichVu DvuMoi = new CthddichVu();
                    DvuMoi.MaHd = ChuyenDL.MaHd.ToString();
                    DvuMoi.Stt = max + 1;
                    DvuMoi.MaDichVu = txtMa.Text;
                    DvuMoi.SoLuong = int.Parse(txtSL.Text);
                    db.CthddichVus.Add(DvuMoi);
                    tinhsl.Slc = tinhsl.Slc - int.Parse(txtSL.Text);
                    db.SaveChanges();
                    MessageBox.Show("Thêm Thành Công !", "Thông báo ", MessageBoxButtons.OK);
                    LoadCTHD();
                    Loadmenu();
                }
                else { MessageBox.Show("Dịch vụ này đã hết !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch {; }
        }

        private void txtDs_Click(object sender, EventArgs e)
        {
            frmHDDV form1 = new frmHDDV();
            Data data = new Data(form1.funData);
            data(txtcv.Text);
            form1.Show();
            Visible = false;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn Chắc chắn muốn xóa không", "Thông báo ", MessageBoxButtons.YesNo);
            if (tl == DialogResult.Yes)
            {
                var query = from s in db.CthddichVus
                            where s.MaDichVuNavigation.TenDichVu == txtTen.Text && s.MaHd == a.Text
                            select s;
                var tinhsl = db.MenuDichVus.SingleOrDefault(
                                       menu => menu.TenDichVu == txtTen.Text);
                tinhsl.Slc = tinhsl.Slc + int.Parse(txtSL.Text);
                db.CthddichVus.RemoveRange(query.FirstOrDefault());
                db.SaveChanges();
                Loadmenu();
                LoadCTHD();
            }
        }

        private void dgvHDdv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvHDdv.Rows[e.RowIndex];
                //a.Text = row.Cells[0].Value.ToString(); 
              
                txtTen.Text = row.Cells[0].Value.ToString();
              
                 txtSL.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            // cập nhật số lượng bảng MenuDichVu

            var query = from s in db.CthddichVus
                        where s.MaDichVuNavigation.TenDichVu == txtTen.Text && s.MaHd == a.Text
                        select s;
            var tinhsl = db.MenuDichVus.FirstOrDefault(
                                   menu => menu.TenDichVu == txtTen.Text);
            CthddichVu Dvkh = query.SingleOrDefault(menu => menu.MaHd == a.Text);
            // cập nhật số lượng bảng MenuDichVu
            if (tinhsl.Slc > int.Parse(txtSL.Text))
            {
                if (Dvkh.SoLuong < int.Parse(txtSL.Text))
                    tinhsl.Slc = tinhsl.Slc - (-Dvkh.SoLuong + int.Parse(txtSL.Text));
                else
                    tinhsl.Slc = tinhsl.Slc - (Dvkh.SoLuong - int.Parse(txtSL.Text));
                CthddichVu DvSua = query.FirstOrDefault();
                DvSua.SoLuong = int.Parse(txtSL.Text);
                db.SaveChanges();
                LoadCTHD();
                Loadmenu();
            }
        }

        private void btIn_Click(object sender, EventArgs e)
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

                Chunk b = new Chunk(" NHÀ NGHỈ BÌNH YÊN \n" , fontHearder);
                Paragraph a = new Paragraph();
                a.Alignment = Element.ALIGN_CENTER;
                a.Add(b);

                Phrase phrase2 = new Phrase("\n HÓA ĐƠN DỊCH VỤ ", fontHearder);
                PdfPCell pdfPCell2 = new PdfPCell(phrase2);
                pdfPCell2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell2.Colspan = 3;
                pdfPCell2.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfPCell2.PaddingBottom = 25;
                //pdfPCell2.PaddingLeft = ;
                table.AddCell(pdfPCell2);

                //table Sản phẩm
                PdfPTable tableProduct = new PdfPTable(dgvHDdv.ColumnCount);
                tableProduct.DefaultCell.PaddingBottom = 10;
                tableProduct.DefaultCell.PaddingTop = 10;
                tableProduct.WidthPercentage = 90;
                tableProduct.HorizontalAlignment = Element.ALIGN_CENTER;
                tableProduct.DefaultCell.BorderWidth = 1;

                //add headertext
                foreach (DataGridViewColumn column in dgvHDdv.Columns)
                {
                    PdfPCell pdfPCell = new PdfPCell(new Phrase(column.HeaderText, fontBold));
                    pdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfPCell.PaddingBottom = 4;
                    tableProduct.AddCell(pdfPCell);
                }

                // add cell
                foreach (DataGridViewRow row in dgvHDdv.Rows)
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

                Phrase phrase3 = new Phrase("Tổng tiền thanh toán :" + txtTongtien.Text, fontHearder);
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
