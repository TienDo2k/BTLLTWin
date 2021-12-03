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
    public partial class FrmSuaDatDVNCC : Form
    {
        BTLLTWinContext db = new BTLLTWinContext();

        public FrmSuaDatDVNCC()
        {
            InitializeComponent();
        }

        private void FrmSuaDatDVNCC_Load(object sender, EventArgs e)
        {
            var combo = from l in db.MenuDichVus
                        select l;
            cbTenDV.DataSource = combo.ToList();
            cbTenDV.DisplayMember = "TenDichVu";
            cbTenDV.ValueMember = "MaDichVu";
            var combo1 = from k in db.NhaCcs
                         select k;
            cbTenNCC.DataSource = combo1.ToList();
            cbTenNCC.DisplayMember = "TenNCC";
            cbTenNCC.ValueMember = "MaNCC";
            dtNgayDat.Value = DateTime.Now.Date;
            HienThiDuLieu();


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
        private bool ValidData2()
        {
            if (txtMaDat.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã đặt ");
                txtMaDat.Focus();
                return false;
            }

            if (txtSL.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng đặt ");
                txtSL.Focus();
                return false;
            }
            else
            {
                try
                {
                    int.Parse(txtSL.Text);

                    if (int.Parse(txtSL.Text) <= 0)
                    {
                        MessageBox.Show("Bạn phải nhập số lượng >0 ");
                        txtSL.Focus();
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("Bạn phải nhập số lượng phải là số tự nhiên ");
                    txtSL.Focus();
                    return false;
                }
                if (txtDG.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập đơn giá ");
                    txtDG.Focus();
                    return false;
                }
                else
                {
                    try
                    {
                        float.Parse(txtDG.Text);

                        if (int.Parse(txtDG.Text) <= 0)
                        {
                            MessageBox.Show("Bạn phải nhập đơn giá >0 ");
                            txtDG.Focus();
                            return false;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Bạn phải nhập số lượng phải là số nguyên ");
                        txtDG.Focus();
                        return false;
                    }

                }
            }

            return true;

        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            if (ValidData2())
            {
                DatDichVu ddv = new DatDichVu();

                var query = from s in db.DatDichVus
                            where s.MaDatDv == txtMaDat.Text
                            select s;


                if (!query.Any())
                {
                    MessageBox.Show("Mã đặt dịch vụ cần sửa không tồn tại");
                    return;

                }

                DatDichVu ddvSua = query.FirstOrDefault();

                if (ddvSua.TrangThai == "Chưa")
                {

                    ddvSua.MaNcc = cbTenNCC.SelectedValue.ToString();
                    ddvSua.MaDichVu = cbTenDV.SelectedValue.ToString();
                    ddvSua.NgayDatDv = dtNgayDat.Value;
                    ddvSua.Sld = int.Parse(txtSL.Text);
                    ddvSua.DonGia = float.Parse(txtDG.Text);
                    if (dtNgayDat.Value > DateTime.Now.Date)
                    {
                        ddvSua.TrangThai = "Chưa";

                    }
                    else
                    {
                        ddvSua.TrangThai = "Cập nhật";
                        var query3 = from s in db.MenuDichVus
                                     where s.MaDichVu == cbTenDV.SelectedValue.ToString()
                                     select s;
                        var dvt = query3.FirstOrDefault();
                        dvt.Slc = dvt.Slc + int.Parse(txtSL.Text);
                    }
                }
                else
                {
                    var query2 = from s in db.MenuDichVus
                                 where s.MaDichVu == cbTenDV.SelectedValue.ToString()
                                 select s;
                    var dv = query2.FirstOrDefault();
                    var cc = query.FirstOrDefault();
                    if (dv.Slc - cc.Sld + int.Parse(txtSL.Text) < 0)
                    {
                        MessageBox.Show("không thể cập nhật vì số lượng có lúc sau <0");
                        return;
                    }

                    dv.Slc = dv.Slc - cc.Sld + int.Parse(txtSL.Text);
                    ddvSua.Sld = int.Parse(txtSL.Text);
                    ddvSua.DonGia = float.Parse(txtDG.Text);

                }

                db.SaveChanges();
                HienThiDuLieu();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            txtMaDat.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            cbTenNCC.SelectedValue = dataGridView1.Rows[index].Cells[1].Value.ToString();
            cbTenDV.SelectedValue = dataGridView1.Rows[index].Cells[2].Value.ToString();
            dtNgayDat.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtSL.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            txtDG.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
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
               
                FrmDatDVNCC form1 = new FrmDatDVNCC();
                Data data = new Data(form1.funData);
                data(txtcv.Text);
                form1.Show();
                Visible = false;
            }
            else
            {


            }
        }
    }
}
