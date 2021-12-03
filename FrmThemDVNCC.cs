
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

namespace BTLLTWin
{
    
    public partial class FrmThemDVNCC : Form 

    {
        private string MaDat, TenNCC, NgayDat, SLDV;
        
        public FrmThemDVNCC()
        {
            InitializeComponent();
        }
        private bool ValidData1()
        {
           
                if (dtNgayDat.Value < DateTime.Now.Date)
                {
                    MessageBox.Show("Ngày đặt phải là ngày hiện tại hoặc sau ngày hiện tại");
                    txtMaDat.Focus();
                    return false;
                }
            
            if (txtSL1.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng đặt ");
                txtSL1.Focus();
                return false;
            }
            else
            {
                try
                {
                    int.Parse(txtSL1.Text);

                    if (int.Parse(txtSL1.Text) <= 0)
                    {
                        MessageBox.Show("Bạn phải nhập số lượng >0 ");
                        txtSL1.Focus();
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("Bạn phải nhập số lượng phải là số tự nhiên ");
                    txtSL1.Focus();
                    return false;
                }
                if (txtDG1.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập đơn giá ");
                    txtDG1.Focus();
                    return false;
                }
                else
                {
                    try
                    {
                        float.Parse(txtDG1.Text);

                        if (int.Parse(txtDG1.Text) <= 0)
                        {
                            MessageBox.Show("Bạn phải nhập đơn giá >0 ");
                            txtDG1.Focus();
                            return false;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Bạn phải nhập số lượng phải là số nguyên ");
                        txtDG1.Focus();
                        return false;
                    }

                }
            }

            return true;

        }
        private bool ValidData2()
        {
            if (dtNgayDat.Value < DateTime.Now.Date)
            {
                MessageBox.Show("Ngày đặt phải là ngày hiện tại hoặc sau ngày hiện tại");
                txtMaDat.Focus();
                return false;
            }
            if (txtSL2.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng đặt ");
                txtSL2.Focus();
                return false;
            }
            else
            {
                try
                {
                    int.Parse(txtSL2.Text);

                    if (int.Parse(txtSL2.Text) <= 0)
                    {
                        MessageBox.Show("Bạn phải nhập số lượng >0 ");
                        txtSL2.Focus();
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("Bạn phải nhập số lượng phải là số tự nhiên ");
                    txtSL2.Focus();
                    return false;
                }
                if (txtDG2.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập đơn giá ");
                    txtDG2.Focus();
                    return false;
                }
                else
                {
                    try
                    {
                        float.Parse(txtDG2.Text);

                        if (int.Parse(txtDG2.Text) <= 0)
                        {
                            MessageBox.Show("Bạn phải nhập đơn giá >0 ");
                            txtDG2.Focus();
                            return false;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Bạn phải nhập số lượng phải là số nguyên ");
                        txtDG2.Focus();
                        return false;
                    }

                }
            }

            return true;

        }
        private bool ValidData3()
        {
            if (dtNgayDat.Value < DateTime.Now.Date)
            {
                MessageBox.Show("Ngày đặt phải là ngày hiện tại hoặc sau ngày hiện tại");
                txtMaDat.Focus();
                return false;
            }
            if (txtSL3.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng đặt ");
                txtSL3.Focus();
                return false;
            }
            else
            {
                try
                {
                    int.Parse(txtSL3.Text);

                    if (int.Parse(txtSL3.Text) <= 0)
                    {
                        MessageBox.Show("Bạn phải nhập số lượng >0 ");
                        txtSL3.Focus();
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("Bạn phải nhập số lượng phải là số tự nhiên ");
                    txtSL3.Focus();
                    return false;
                }
                if (txtDG3.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập đơn giá ");
                    txtDG3.Focus();
                    return false;
                }
                else
                {
                    try
                    {
                        float.Parse(txtDG3.Text);

                        if (int.Parse(txtDG3.Text) <= 0)
                        {
                            MessageBox.Show("Bạn phải nhập đơn giá >0 ");
                            txtDG3.Focus();
                            return false;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Bạn phải nhập số lượng phải là số nguyên ");
                        txtDG3.Focus();
                        return false;
                    }

                }
            }

            return true;

        }
        private bool ValidData4()
        {
            if (dtNgayDat.Value < DateTime.Now.Date)
            {
                MessageBox.Show("Ngày đặt phải là ngày hiện tại hoặc sau ngày hiện tại");
                txtMaDat.Focus();
                return false;
            }
            if (txtSL4.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng đặt ");
                txtSL4.Focus();
                return false;
            }
            else
            {
                try
                {
                    int.Parse(txtSL4.Text);

                    if (int.Parse(txtSL4.Text) <= 0)
                    {
                        MessageBox.Show("Bạn phải nhập số lượng >0 ");
                        txtSL4.Focus();
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("Bạn phải nhập số lượng phải là số tự nhiên ");
                    txtSL4.Focus();
                    return false;
                }
                if (txtDG4.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập đơn giá ");
                    txtDG4.Focus();
                    return false;
                }
                else
                {
                    try
                    {
                        float.Parse(txtDG4.Text);

                        if (int.Parse(txtDG4.Text) <= 0)
                        {
                            MessageBox.Show("Bạn phải nhập đơn giá >0 ");
                            txtDG4.Focus();
                            return false;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Bạn phải nhập số lượng phải là số nguyên ");
                        txtDG4.Focus();
                        return false;
                    }

                }
            }

            return true;

        }
        private bool ValidData5()
        {
            if (dtNgayDat.Value < DateTime.Now.Date)
            {
                MessageBox.Show("Ngày đặt phải là ngày hiện tại hoặc sau ngày hiện tại");
                txtMaDat.Focus();
                return false;
            }
            if (txtSL5.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng đặt ");
                txtSL5.Focus();
                return false;
            }
            else
            {
                try
                {
                    int.Parse(txtSL5.Text);

                    if (int.Parse(txtSL5.Text) <= 0)
                    {
                        MessageBox.Show("Bạn phải nhập số lượng >0 ");
                        txtSL5.Focus();
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("Bạn phải nhập số lượng phải là số tự nhiên ");
                    txtSL5.Focus();
                    return false;
                }
                if (txtDG5.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập đơn giá ");
                    txtDG5.Focus();
                    return false;
                }
                else
                {
                    try
                    {
                        float.Parse(txtDG5.Text);

                        if (int.Parse(txtDG5.Text) <= 0)
                        {
                            MessageBox.Show("Bạn phải nhập đơn giá >0 ");
                            txtDG5.Focus();
                            return false;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Bạn phải nhập số lượng phải là số nguyên ");
                        txtDG5.Focus();
                        return false;
                    }

                }
            }

            return true;

        }




        private void btThem_Click(object sender, EventArgs e)
        {
            if (SLDV == "1")
            {
                if (ValidData1())
                {
                    DatDichVu ddv = new DatDichVu();
                    ddv.MaDatDv = txtMaDat.Text;
                    ddv.MaNcc = cbTenNCC.SelectedValue.ToString();
                    ddv.MaDichVu = cbTenDV1.SelectedValue.ToString();
                    ddv.NgayDatDv = dtNgayDat.Value;
                    ddv.Sld = int.Parse(txtSL1.Text);
                    ddv.DonGia = float.Parse(txtDG1.Text);
                    if (dtNgayDat.Value > DateTime.Now.Date)
                    {
                        ddv.TrangThai = "Chưa";
                    }
                    else
                    {
                        ddv.TrangThai = "Cập nhật";

                        var query2 = from s in db.MenuDichVus
                                     where s.MaDichVu == cbTenDV1.SelectedValue.ToString()
                                     select s;
                        var dv = query2.FirstOrDefault();
                        dv.Slc = dv.Slc + int.Parse(txtSL1.Text);
                    }
                    db.DatDichVus.Add(ddv);
                    db.SaveChanges();
                    MessageBox.Show("Đã thêm thành công");
                    return;
                }                
            }
            if (SLDV == "2" && cbTenDV1.Text != cbTenDV2.Text)
            {
                if (ValidData1())
                {
                    DatDichVu ddv = new DatDichVu();
                    ddv.MaDatDv = txtMaDat.Text;
                    ddv.MaNcc = cbTenNCC.SelectedValue.ToString();
                    ddv.MaDichVu = cbTenDV1.SelectedValue.ToString();
                    ddv.NgayDatDv = dtNgayDat.Value;
                    ddv.Sld = int.Parse(txtSL1.Text);
                    ddv.DonGia = float.Parse(txtDG1.Text);
                    if (dtNgayDat.Value > DateTime.Now.Date)
                    {
                        ddv.TrangThai = "Chưa";
                    }
                    else
                    {
                        ddv.TrangThai = "Cập nhật";

                        var query2 = from s in db.MenuDichVus
                                     where s.MaDichVu == cbTenDV1.SelectedValue.ToString()
                                     select s;
                        var dv = query2.FirstOrDefault();
                        dv.Slc = dv.Slc + int.Parse(txtSL1.Text);
                    }
                    db.DatDichVus.Add(ddv);
                    db.SaveChanges();
                    if (ValidData2())
                    {
                        
                        ddv.MaDatDv = txtMaDat.Text;
                        ddv.MaNcc = cbTenNCC.SelectedValue.ToString();
                        ddv.MaDichVu = cbTenDV2.SelectedValue.ToString();
                        ddv.NgayDatDv = dtNgayDat.Value;
                        ddv.Sld = int.Parse(txtSL2.Text);
                        ddv.DonGia = float.Parse(txtDG2.Text);
                        if (dtNgayDat.Value > DateTime.Now.Date)
                        {
                            ddv.TrangThai = "Chưa";
                        }
                        else
                        {
                            ddv.TrangThai = "Cập nhật";

                            var query2 = from s in db.MenuDichVus
                                         where s.MaDichVu == cbTenDV2.SelectedValue.ToString()
                                         select s;
                            var dv = query2.FirstOrDefault();
                            dv.Slc = dv.Slc + int.Parse(txtSL2.Text);
                        }
                        db.DatDichVus.Add(ddv);
                        db.SaveChanges();
                        MessageBox.Show("Đã thêm thành công");
                        return;
                    }

                }
               
            }
            if(SLDV == "3" && cbTenDV1.Text != cbTenDV2.Text && cbTenDV1.Text != cbTenDV3.Text && cbTenDV2.Text != cbTenDV3.Text)
            {

                if (ValidData1())
                {
                    DatDichVu ddv = new DatDichVu();
                    ddv.MaDatDv = txtMaDat.Text;
                    ddv.MaNcc = cbTenNCC.SelectedValue.ToString();
                    ddv.MaDichVu = cbTenDV1.SelectedValue.ToString();
                    ddv.NgayDatDv = dtNgayDat.Value;
                    ddv.Sld = int.Parse(txtSL1.Text);
                    ddv.DonGia = float.Parse(txtDG1.Text);
                    if (dtNgayDat.Value > DateTime.Now.Date)
                    {
                        ddv.TrangThai = "Chưa";
                    }
                    else
                    {
                        ddv.TrangThai = "Cập nhật";

                        var query2 = from s in db.MenuDichVus
                                     where s.MaDichVu == cbTenDV1.SelectedValue.ToString()
                                     select s;
                        var dv = query2.FirstOrDefault();
                        dv.Slc = dv.Slc + int.Parse(txtSL1.Text);
                    }
                    db.DatDichVus.Add(ddv);
                    db.SaveChanges();
                    if (ValidData2())
                    {

                        ddv.MaDatDv = txtMaDat.Text;
                        ddv.MaNcc = cbTenNCC.SelectedValue.ToString();
                        ddv.MaDichVu = cbTenDV2.SelectedValue.ToString();
                        ddv.NgayDatDv = dtNgayDat.Value;
                        ddv.Sld = int.Parse(txtSL2.Text);
                        ddv.DonGia = float.Parse(txtDG2.Text);
                        if (dtNgayDat.Value > DateTime.Now.Date)
                        {
                            ddv.TrangThai = "Chưa";
                        }
                        else
                        {
                            ddv.TrangThai = "Cập nhật";

                            var query2 = from s in db.MenuDichVus
                                         where s.MaDichVu == cbTenDV2.SelectedValue.ToString()
                                         select s;
                            var dv = query2.FirstOrDefault();
                            dv.Slc = dv.Slc + int.Parse(txtSL2.Text);
                        }
                        db.DatDichVus.Add(ddv);
                        db.SaveChanges();
                        //MessageBox.Show("Đã thêm thành công");
                        //return;
                        if (ValidData3())
                        {

                            ddv.MaDatDv = txtMaDat.Text;
                            ddv.MaNcc = cbTenNCC.SelectedValue.ToString();
                            ddv.MaDichVu = cbTenDV3.SelectedValue.ToString();
                            ddv.NgayDatDv = dtNgayDat.Value;
                            ddv.Sld = int.Parse(txtSL3.Text);
                            ddv.DonGia = float.Parse(txtDG3.Text);
                            if (dtNgayDat.Value > DateTime.Now.Date)
                            {
                                ddv.TrangThai = "Chưa";
                            }
                            else
                            {
                                ddv.TrangThai = "Cập nhật";

                                var query2 = from s in db.MenuDichVus
                                             where s.MaDichVu == cbTenDV3.SelectedValue.ToString()
                                             select s;
                                var dv = query2.FirstOrDefault();
                                dv.Slc = dv.Slc + int.Parse(txtSL3.Text);
                            }
                            db.DatDichVus.Add(ddv);
                            db.SaveChanges();
                            MessageBox.Show("Đã thêm thành công");
                            return;
                        }
                    }

                }
  
            }
            if (SLDV == "4" && cbTenDV1.Text != cbTenDV2.Text && cbTenDV1.Text != cbTenDV3.Text && cbTenDV1.Text != cbTenDV4.Text
                && cbTenDV2.Text != cbTenDV3.Text && cbTenDV2.Text != cbTenDV4.Text 
                && cbTenDV3.Text != cbTenDV4.Text)
            {

                if (ValidData1())
                {
                    DatDichVu ddv = new DatDichVu();
                    ddv.MaDatDv = txtMaDat.Text;
                    ddv.MaNcc = cbTenNCC.SelectedValue.ToString();
                    ddv.MaDichVu = cbTenDV1.SelectedValue.ToString();
                    ddv.NgayDatDv = dtNgayDat.Value;
                    ddv.Sld = int.Parse(txtSL1.Text);
                    ddv.DonGia = float.Parse(txtDG1.Text);
                    if (dtNgayDat.Value > DateTime.Now.Date)
                    {
                        ddv.TrangThai = "Chưa";
                    }
                    else
                    {
                        ddv.TrangThai = "Cập nhật";

                        var query2 = from s in db.MenuDichVus
                                     where s.MaDichVu == cbTenDV1.SelectedValue.ToString()
                                     select s;
                        var dv = query2.FirstOrDefault();
                        dv.Slc = dv.Slc + int.Parse(txtSL1.Text);
                    }
                    db.DatDichVus.Add(ddv);
                    db.SaveChanges();
                    if (ValidData2())
                    {
                        
                        ddv.MaDatDv = txtMaDat.Text;
                        ddv.MaNcc = cbTenNCC.SelectedValue.ToString();
                        ddv.MaDichVu = cbTenDV2.SelectedValue.ToString();
                        ddv.NgayDatDv = dtNgayDat.Value;
                        ddv.Sld = int.Parse(txtSL2.Text);
                        ddv.DonGia = float.Parse(txtDG2.Text);
                        if (dtNgayDat.Value > DateTime.Now.Date)
                        {
                            ddv.TrangThai = "Chưa";
                        }
                        else
                        {
                            ddv.TrangThai = "Cập nhật";

                            var query2 = from s in db.MenuDichVus
                                         where s.MaDichVu == cbTenDV2.SelectedValue.ToString()
                                         select s;
                            var dv = query2.FirstOrDefault();
                            dv.Slc = dv.Slc + int.Parse(txtSL2.Text);
                        }
                        db.DatDichVus.Add(ddv);
                        db.SaveChanges();
                        //MessageBox.Show("Đã thêm thành công");
                        //return;
                        if (ValidData3())
                        {
                            
                            ddv.MaDatDv = txtMaDat.Text;
                            ddv.MaNcc = cbTenNCC.SelectedValue.ToString();
                            ddv.MaDichVu = cbTenDV3.SelectedValue.ToString();
                            ddv.NgayDatDv = dtNgayDat.Value;
                            ddv.Sld = int.Parse(txtSL3.Text);
                            ddv.DonGia = float.Parse(txtDG3.Text);
                            if (dtNgayDat.Value > DateTime.Now.Date)
                            {
                                ddv.TrangThai = "Chưa";
                            }
                            else
                            {
                                ddv.TrangThai = "Cập nhật";

                                var query2 = from s in db.MenuDichVus
                                             where s.MaDichVu == cbTenDV3.SelectedValue.ToString()
                                             select s;
                                var dv = query2.FirstOrDefault();
                                dv.Slc = dv.Slc + int.Parse(txtSL3.Text);
                            }
                            db.DatDichVus.Add(ddv);
                            db.SaveChanges();
                            if (ValidData4())
                            {
                               
                                ddv.MaDatDv = txtMaDat.Text;
                                ddv.MaNcc = cbTenNCC.SelectedValue.ToString();
                                ddv.MaDichVu = cbTenDV4.SelectedValue.ToString();
                                ddv.NgayDatDv = dtNgayDat.Value;
                                ddv.Sld = int.Parse(txtSL4.Text);
                                ddv.DonGia = float.Parse(txtDG4.Text);
                                if (dtNgayDat.Value > DateTime.Now.Date)
                                {
                                    ddv.TrangThai = "Chưa";
                                }
                                else
                                {
                                    ddv.TrangThai = "Cập nhật";

                                    var query2 = from s in db.MenuDichVus
                                                 where s.MaDichVu == cbTenDV4.SelectedValue.ToString()
                                                 select s;
                                    var dv = query2.FirstOrDefault();
                                    dv.Slc = dv.Slc + int.Parse(txtSL4.Text);
                                }
                                db.DatDichVus.Add(ddv);
                                db.SaveChanges();
                                MessageBox.Show("Đã thêm thành công");
                                return;

                            }
                        }
                    }

                }
                
               
            }
            if (SLDV == "5" && cbTenDV1.Text != cbTenDV2.Text && cbTenDV1.Text != cbTenDV3.Text && cbTenDV1.Text != cbTenDV4.Text && cbTenDV1.Text != cbTenDV5.Text
                && cbTenDV2.Text != cbTenDV3.Text && cbTenDV2.Text != cbTenDV4.Text && cbTenDV2.Text != cbTenDV5.Text
                && cbTenDV3.Text != cbTenDV4.Text && cbTenDV3.Text != cbTenDV5.Text && cbTenDV3.Text != cbTenDV5.Text)
            {

                if (ValidData1())
                {
                    DatDichVu ddv = new DatDichVu();
                    ddv.MaDatDv = txtMaDat.Text;
                    ddv.MaNcc = cbTenNCC.SelectedValue.ToString();
                    ddv.MaDichVu = cbTenDV1.SelectedValue.ToString();
                    ddv.NgayDatDv = dtNgayDat.Value;
                    ddv.Sld = int.Parse(txtSL1.Text);
                    ddv.DonGia = float.Parse(txtDG1.Text);
                    if (dtNgayDat.Value > DateTime.Now.Date)
                    {
                        ddv.TrangThai = "Chưa";
                    }
                    else
                    {
                        ddv.TrangThai = "Cập nhật";

                        var query2 = from s in db.MenuDichVus
                                     where s.MaDichVu == cbTenDV1.SelectedValue.ToString()
                                     select s;
                        var dv = query2.FirstOrDefault();
                        dv.Slc = dv.Slc + int.Parse(txtSL1.Text);
                    }
                    db.DatDichVus.Add(ddv);
                    db.SaveChanges();
                    if (ValidData3())
                    {
                       
                        ddv.MaDatDv = txtMaDat.Text;
                        ddv.MaNcc = cbTenNCC.SelectedValue.ToString();
                        ddv.MaDichVu = cbTenDV3.SelectedValue.ToString();
                        ddv.NgayDatDv = dtNgayDat.Value;
                        ddv.Sld = int.Parse(txtSL3.Text);
                        ddv.DonGia = float.Parse(txtDG3.Text);
                        if (dtNgayDat.Value > DateTime.Now.Date)
                        {
                            ddv.TrangThai = "Chưa";
                        }
                        else
                        {
                            ddv.TrangThai = "Cập nhật";

                            var query2 = from s in db.MenuDichVus
                                         where s.MaDichVu == cbTenDV3.SelectedValue.ToString()
                                         select s;
                            var dv = query2.FirstOrDefault();
                            dv.Slc = dv.Slc + int.Parse(txtSL3.Text);
                        }
                        db.DatDichVus.Add(ddv);
                        db.SaveChanges();
                        if (ValidData2())
                        {

                            ddv.MaDatDv = txtMaDat.Text;
                            ddv.MaNcc = cbTenNCC.SelectedValue.ToString();
                            ddv.MaDichVu = cbTenDV2.SelectedValue.ToString();
                            ddv.NgayDatDv = dtNgayDat.Value;
                            ddv.Sld = int.Parse(txtSL2.Text);
                            ddv.DonGia = float.Parse(txtDG2.Text);
                            if (dtNgayDat.Value > DateTime.Now.Date)
                            {
                                ddv.TrangThai = "Chưa";
                            }
                            else
                            {
                                ddv.TrangThai = "Cập nhật";

                                var query2 = from s in db.MenuDichVus
                                             where s.MaDichVu == cbTenDV2.SelectedValue.ToString()
                                             select s;
                                var dv = query2.FirstOrDefault();
                                dv.Slc = dv.Slc + int.Parse(txtSL2.Text);
                            }
                            db.DatDichVus.Add(ddv);
                            db.SaveChanges();
                            if (ValidData4())
                            {
                                
                                ddv.MaDatDv = txtMaDat.Text;
                                ddv.MaNcc = cbTenNCC.SelectedValue.ToString();
                                ddv.MaDichVu = cbTenDV4.SelectedValue.ToString();
                                ddv.NgayDatDv = dtNgayDat.Value;
                                ddv.Sld = int.Parse(txtSL4.Text);
                                ddv.DonGia = float.Parse(txtDG4.Text);
                                if (dtNgayDat.Value > DateTime.Now.Date)
                                {
                                    ddv.TrangThai = "Chưa";
                                }
                                else
                                {
                                    ddv.TrangThai = "Cập nhật";

                                    var query2 = from s in db.MenuDichVus
                                                 where s.MaDichVu == cbTenDV4.SelectedValue.ToString()
                                                 select s;
                                    var dv = query2.FirstOrDefault();
                                    dv.Slc = dv.Slc + int.Parse(txtSL4.Text);
                                }
                                db.DatDichVus.Add(ddv);
                                db.SaveChanges();
                                if (ValidData5())
                                {
                                    
                                    ddv.MaDatDv = txtMaDat.Text;
                                    ddv.MaNcc = cbTenNCC.SelectedValue.ToString();
                                    ddv.MaDichVu = cbTenDV5.SelectedValue.ToString();
                                    ddv.NgayDatDv = dtNgayDat.Value;
                                    ddv.Sld = int.Parse(txtSL5.Text);
                                    ddv.DonGia = float.Parse(txtDG5.Text);
                                    if (dtNgayDat.Value > DateTime.Now.Date)
                                    {
                                        ddv.TrangThai = "Chưa";
                                    }
                                    else
                                    {
                                        ddv.TrangThai = "Cập nhật";

                                        var query2 = from s in db.MenuDichVus
                                                     where s.MaDichVu == cbTenDV5.SelectedValue.ToString()
                                                     select s;
                                        var dv = query2.FirstOrDefault();
                                        dv.Slc = dv.Slc + int.Parse(txtSL5.Text);
                                    }
                                    db.DatDichVus.Add(ddv);
                                    db.SaveChanges();
                                    MessageBox.Show("Đã thêm thành công");
                                    return;

                                }


                            }
                        }

                    }
                }
 
            }
             else
            {
                MessageBox.Show("Các dịch vụ phải khác nhau");
                return;
            }
        }
        public delegate void Data(string text);

        public void funData(string txt)
        {
            txtcv.Text = txt;
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                Visible = false;
                FrmDatDVNCC form1 = new FrmDatDVNCC();
                form1.Show();
            }
            else
            {

                
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        BTLLTWinContext db = new BTLLTWinContext();
        private void FrmThemDVNCC_Load(object sender, EventArgs e)
        {
            txtMaDat.Text = MaDat;
            dtNgayDat.Value = DateTime.Now.Date;
            var combo1 = from k in db.NhaCcs
                         select k;
            cbTenNCC.DataSource = combo1.ToList();
            cbTenNCC.DisplayMember = "TenNCC";
            cbTenNCC.ValueMember = "MaNCC";
            if (SLDV =="1")
            {
                cbTenDV2.Enabled = false;
                txtSL2.Enabled = false;
                txtDG2.Enabled = false;
                cbTenDV3.Enabled = false;
                txtSL3.Enabled = false;
                txtDG3.Enabled = false;
                cbTenDV4.Enabled = false;
                txtSL4.Enabled = false;
                txtDG4.Enabled = false;
                cbTenDV5.Enabled = false;
                txtSL5.Enabled = false;
                txtDG5.Enabled = false;
            }
            if (SLDV == "2")
            {
                cbTenDV3.Enabled = false;
                txtSL3.Enabled = false;
                txtDG3.Enabled = false;
                cbTenDV4.Enabled = false;
                txtSL4.Enabled = false;
                txtDG4.Enabled = false;
                cbTenDV5.Enabled = false;
                txtSL5.Enabled = false;
                txtDG5.Enabled = false;
            }
            if (SLDV == "3")
            {
                cbTenDV4.Enabled = false;
                txtSL4.Enabled = false;
                txtDG4.Enabled = false;
                cbTenDV5.Enabled = false;
                txtSL5.Enabled = false;
                txtDG5.Enabled = false;
            }
            if (SLDV == "4")
            {
                cbTenDV5.Enabled = false;
                txtSL5.Enabled = false;
                txtDG5.Enabled = false;
            }
            var combo = from l in db.MenuDichVus
                        select l;
            cbTenDV1.DataSource = combo.ToList();
            cbTenDV1.DisplayMember = "TenDichVu";
            cbTenDV1.ValueMember = "MaDichVu";         
            cbTenDV2.DataSource = combo.ToList();
            cbTenDV2.DisplayMember = "TenDichVu";
            cbTenDV2.ValueMember = "MaDichVu";
            cbTenDV3.DataSource = combo.ToList();
            cbTenDV3.DisplayMember = "TenDichVu";
            cbTenDV3.ValueMember = "MaDichVu";
            cbTenDV4.DataSource = combo.ToList();
            cbTenDV4.DisplayMember = "TenDichVu";
            cbTenDV4.ValueMember = "MaDichVu";
            cbTenDV5.DataSource = combo.ToList();
            cbTenDV5.DisplayMember = "TenDichVu";
            cbTenDV5.ValueMember = "MaDichVu";
        }
        public FrmThemDVNCC(String MaDat,string SLDV)
        {
            InitializeComponent();
            this.MaDat = MaDat;       
            this.SLDV = SLDV;
            
        }
    }
}
