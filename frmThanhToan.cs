using BTLLTWin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace BTLLTWin
{
  
    public partial class frmThanhToan : Form
    {
        BTLLTWinContext db = new BTLLTWinContext();

        public frmThanhToan()
        {
            InitializeComponent();
        }
        public delegate void Data(string text);
        public void funData(string txt)
        {
            txtcv.Text = txt;
        }
        private int tinhNgay()
        {
            var query = from h in db.HoaDons
                        select new
                        {
                            h.NgayDen,
                            h.NgayDi
                        };
            int TongSoNgay = 0;
            foreach (var item in query)
            {
                DateTime ngayDen = Convert.ToDateTime(item.NgayDen);
                DateTime ngayDi = Convert.ToDateTime(item.NgayDi);
                TimeSpan Time = ngayDi - ngayDen;
                TongSoNgay = Time.Days;
            }
            return TongSoNgay;
        }

        private void HienThi()
        {
            var query = from h in db.HoaDons
                            join k in db.KhachHangs on h.MaKh equals k.MaKh
                            join p in db.Phongs on h.MaPhong equals p.MaPhong                            
                            where h.TtthanhToan != "Đã thanh toán"
                            select new
                            {
                                MaHD = h.MaHd,
                                MaKH = k.MaKh,
                                TenKH = k.TenKh,
                                TenPhong = p.TenPhong,
                                NgayDen = h.NgayDen,
                                NgayDi = h.NgayDi,
                                //TenDV = d.MaDichVuNavigation.TenDichVu,
                                //TienDVu = d.MaDichVuNavigation.DonGia * d.SoLuong,
                                TienPhong  = /*d.MaDichVuNavigation.DonGia * d.SoLuong +*/ tinhNgay() * p.Gia,
                            };
                dgvThanhToan.DataSource = query.ToList();
                    
                var listKH = from h in db.HoaDons
                             join k in db.KhachHangs on h.MaKh equals k.MaKh
                             join p in db.Phongs on h.MaPhong equals p.MaPhong
                             where h.TtthanhToan != "Đã thanh toán"
                             select k;
                //cbTenKH.DataSource = listKH.ToList();
                //cbTenKH.DisplayMember = "TenKH";
                txtTongTien.Text = "0";
        }
        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            HienThi();
            //if(cbTenKH.SelectedValue == null)
            //{
            //    btnThanhToan.Enabled = false;
            //}
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {            
            frmQuanLyHoaDon frm = new frmQuanLyHoaDon();
            Data data = new Data(frm.funData);
            data(txtcv.Text);
            frm.Show(); Visible = false;
            
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult select = MessageBox.Show("Bạn có muốn thanh toán ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (select == DialogResult.Yes)
                {
                    string keyword = txt_tim.Text.Trim();
                    var update1 = db.HoaDons.Where(c => c.TtthanhToan== "Chưa Thanh Toán" && c.MaKhNavigation.TenKh.Contains(keyword));
                    foreach (var item in update1) { item.TtthanhToan = "Đã Thanh Toán"; }
                    db.SaveChanges();
                    //var tim = from k in db.KhachHangs
                    //          join d in db.HoaDons on k.MaKh equals d.MaKh
                    //          where d.TtthanhToan == "Đã thanh toán"
                    //          where k.TenKh.Contains(keyword)
                    //          select new
                    //          {
                    //              d.MaDichVuNavigation.TenDichVu,
                    //              d.NgaySuDung,
                    //              d.SoLuong,
                    //              d.MaDichVuNavigation.DonGia,
                    //              Tongtien = d.SoLuong * d.MaDichVuNavigation.DonGia,
                    //          };
                    //dgvThanhToan.DataSource = tim.ToList();

                    DialogResult temp = MessageBox.Show("Bạn có muốn in hóa đơn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (temp == DialogResult.Yes)
                    {
                        InHoaDon();
                    }

                    var tim = from h in db.HoaDons
                                join k in db.KhachHangs on h.MaKh equals k.MaKh
                                join p in db.Phongs on h.MaPhong equals p.MaPhong
                                where h.TtthanhToan != "Đã thanh toán" && k.TenKh.Contains(keyword)
                                select new
                                {
                                    MaHD = h.MaHd,
                                    MaKH = k.MaKh,
                                    TenKH = k.TenKh,
                                    TenPhong = p.TenPhong,
                                    NgayDen = h.NgayDen,
                                    NgayDi = h.NgayDi,                                    
                                    TienPhong = /*d.MaDichVuNavigation.DonGia * d.SoLuong +*/ tinhNgay() * p.Gia,
                                };
                    dgvThanhToan.DataSource = tim.ToList();

                    var query = from h in db.HoaDons
                                join k in db.KhachHangs on h.MaKh equals k.MaKh
                                join p in db.Phongs on h.MaPhong equals p.MaPhong
                                where k.MaKh == txtMaKH.Text
                                select p;
                    var phong = query.FirstOrDefault();
                    phong.TinhTrang = "Empty";                   
                    
                    db.SaveChanges();
                    HienThi();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể thanh toán", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbTenKH_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if(cb.SelectedValue != null)
            {
                KhachHang kh = cb.SelectedValue as KhachHang;
                txtMaKH.Text = kh.MaKh.ToString();
                //txtTongTien.Text = dgvThanhToan.Rows[cbTenKH.SelectedIndex].Cells[8].Value.ToString();
            }
        }

        private void dgvThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvThanhToan.CurrentRow.Index;
            txtMaKH.Text = dgvThanhToan.Rows[index].Cells[1].Value.ToString();
            txt_tim.Text = dgvThanhToan.Rows[index].Cells[2].Value.ToString();
            txtTongTien.Text = dgvThanhToan.Rows[index].Cells[6].Value.ToString();
        }        

        private void InHoaDon()
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
                Paragraph a = new Paragraph();
                a.Alignment = Element.ALIGN_CENTER;
                a.Add(b);

                Phrase phrase2 = new Phrase("\n HÓA ĐƠN TIỀN PHÒNG ", fontHearder);
                PdfPCell pdfPCell2 = new PdfPCell(phrase2);
                pdfPCell2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell2.Colspan = 3;
                pdfPCell2.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfPCell2.PaddingBottom = 25;
                //pdfPCell2.PaddingLeft = ;
                table.AddCell(pdfPCell2);

                //table Sản phẩm
                PdfPTable tableProduct = new PdfPTable(dgvThanhToan.ColumnCount);
                tableProduct.DefaultCell.PaddingBottom = 10;
                tableProduct.DefaultCell.PaddingTop = 10;
                tableProduct.WidthPercentage = 90;
                tableProduct.HorizontalAlignment = Element.ALIGN_CENTER;
                tableProduct.DefaultCell.BorderWidth = 1;

                //add headertext
                foreach (DataGridViewColumn column in dgvThanhToan.Columns)
                {
                    PdfPCell pdfPCell = new PdfPCell(new Phrase(column.HeaderText, fontBold));
                    pdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfPCell.PaddingBottom = 4;
                    tableProduct.AddCell(pdfPCell);
                }

                // add cell
                foreach (DataGridViewRow row in dgvThanhToan.Rows)
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
        private void bt_tim_Click(object sender, EventArgs e)
        {
            if (txt_tim.Text == "")
            {
                errorProvider1.SetError(txt_tim, "Bạn phải nhập tên tên khách hàng cần tìm!");
                txt_tim.Focus();
                return;
            }

            string keyword = txt_tim.Text.Trim();
            var tim = from h in db.HoaDons
                        join k in db.KhachHangs on h.MaKh equals k.MaKh
                        join p in db.Phongs on h.MaPhong equals p.MaPhong
                        where h.TtthanhToan != "Đã thanh toán" && k.TenKh.Contains(keyword)
                        select new
                        {
                            MaHD = h.MaHd,
                            MaKH = k.MaKh,
                            TenKH = k.TenKh,
                            TenPhong = p.TenPhong,
                            NgayDen = h.NgayDen,
                            NgayDi = h.NgayDi,                            
                            TienPhong = /*d.MaDichVuNavigation.DonGia * d.SoLuong +*/ tinhNgay() * p.Gia,
                        };

            if (tim.Count() == 0)
            {
                MessageBox.Show("Khách hàng không tồn tại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_tim.Focus();
                txt_tim.SelectAll();
            }
            else
            {
                dgvThanhToan.DataSource = tim.ToList();
                double tongtien = 0;
                for (int i = 0; i < dgvThanhToan.Rows.Count; i++)
                {
                    double tt = Convert.ToDouble(dgvThanhToan.Rows[i].Cells[6].Value);
                    tongtien += tt;
                }
                txtTongTien.Text = tongtien.ToString();
            }
        }

        private void txt_tim_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txt_tim, "");
        }
    }
}
