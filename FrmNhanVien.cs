
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
    public partial class FrmNhanVien : Form
    {
        public delegate void Data(string text);
        public void funData(string txt)
        {
            txtcv.Text = txt;
        }
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        BTLLTWinContext db = new BTLLTWinContext();
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            cbChucVu.Items.Add("Nhân viên");
            cbChucVu.Items.Add("Lễ tân");
            cbChucVu.Items.Add("Quản lý");
            cbChucVu.SelectedIndex = 0;
            rdNam.Checked = true;
            txtMaNV.Focus();


        }

        private void HienThiDuLieu()
        {

            var query = from s in db.NhanViens
                        select new
                        {
                            s.MaNv,
                            s.TenNv,
                            s.GioiTinh,
                            s.DienThoai,
                            s.DiaChi,
                            s.Email,
                            s.ChucVu
                        };
            //Hiển thị lên datagrid view
            dataGridView1.DataSource = query.ToList();
            
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                NhanVien nv = new NhanVien();
                var query1 = from s in db.NhanViens
                             where s.MaNv == txtMaNV.Text
                             select s;


                if (query1.Any())
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại");
                    return;
                }
                else
                {
                    nv.MaNv = txtMaNV.Text;
                    nv.TenNv = txtTenNV.Text;
                    if (rdNam.Checked == true) { nv.GioiTinh = "Nam"; }
                    else nv.GioiTinh = "Nữ";
                    nv.DienThoai = txtSDT.Text;
                    nv.DiaChi = txtDiaChi.Text;
                    var keyword = "@gmail.com";
                    if (!txtEmail.Text.Contains(keyword))
                    {
                        MessageBox.Show("Email không đúng định dạng");
                        return;
                    }
                    nv.Email = txtEmail.Text;
                    if (cbChucVu.SelectedIndex == 0) nv.ChucVu = "Nhân viên";
                    if (cbChucVu.SelectedIndex == 1) nv.ChucVu = "Lễ tân";
                    if (cbChucVu.SelectedIndex == 2) nv.ChucVu = "Quản lý";

                    db.NhanViens.Add(nv);
                    db.SaveChanges();
                    HienThiDuLieu();
                }
            }
    }

        private bool ValidData()
        {
            
                if (txtMaNV.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập mã ");
                    txtMaNV.Focus();
                    return false;
                }
                if (txtTenNV.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập tên ");
                    txtTenNV.Focus();
                    return false;
                }

                if (txtSDT.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập số điện thoại");
                    txtSDT.Focus();
                    return false;
                }
                if (txtDiaChi.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập địa chỉ");
                    txtDiaChi.Focus();
                    return false;
                }
                if (txtEmail.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập Email");
                    txtEmail.Focus();
                    return false;
                }
                return true;

            }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                {
                    var query = from s in db.NhanViens
                                where s.MaNv == txtMaNV.Text
                                select s;

                    if (!query.Any())
                    {
                        MessageBox.Show("Mã muốn sửa không tồn tại");
                        return;

                    }
                    else
                    {
                        NhanVien nvSua = query.SingleOrDefault();
                        nvSua.TenNv = txtTenNV.Text;
                        
                        if (rdNam.Checked == true) { nvSua.GioiTinh = "Nam"; }
                        else nvSua.GioiTinh = "Nữ";
                        nvSua.DienThoai = txtSDT.Text;
                        nvSua.DiaChi = txtDiaChi.Text;
                        nvSua.Email = txtEmail.Text;
                        if (cbChucVu.SelectedIndex == 0) nvSua.ChucVu = "Nhân viên";
                        if (cbChucVu.SelectedIndex == 1) nvSua.ChucVu = "Lễ tân";
                        if (cbChucVu.SelectedIndex == 2) nvSua.ChucVu = "Quản lý";
                        db.SaveChanges();
                        HienThiDuLieu();
                    }
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            var query = from s in db.NhanViens
                        where s.MaNv == txtMaNV.Text
                        select s;

            if (!query.Any())
            {
                MessageBox.Show("Mã muốn xóa không tồn tại");
                return;

            }

            NhanVien nvXoa = (from s in db.NhanViens
                               where s.MaNv == txtMaNV.Text
                               select s).FirstOrDefault();

            DialogResult tl = MessageBox.Show("Bạn muốn xóa", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                db.NhanViens.Remove(nvXoa);

                db.SaveChanges();

                HienThiDuLieu();
            }
            else
            {
                txtMaNV.Clear();
                HienThiDuLieu();
            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            var query = from s in db.NhanViens
                        where s.MaNv == txtMaNV.Text
                        select s;

            if (!query.Any())
            {
                MessageBox.Show("Mã muốn tìm không tồn tại");
                return;

            }
            else
            {
                var query1 = from s in db.NhanViens
                             where s.MaNv == txtMaNV.Text
                             select new
                             {
                                 s.MaNv,
                                 s.TenNv,
                                 s.GioiTinh,
                                 s.DienThoai,
                                 s.DiaChi,
                                 s.Email,
                                 s.ChucVu
                             };
                //Hiển thị lên datagrid view
                dataGridView1.DataSource = query1.ToList();
            }
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            rdNam.Checked = true;
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            cbChucVu.SelectedIndex = 0;
            HienThiDuLieu();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            txtMaNV.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtTenNV.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            if (dataGridView1.Rows[index].Cells[2].Value.ToString() == "Nam") { rdNam.Checked = true; }
            else rdNu.Checked = true;
            txtSDT.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            if (dataGridView1.Rows[index].Cells[6].Value.ToString() == "Nhân viên") cbChucVu.SelectedIndex = 0;
            if (dataGridView1.Rows[index].Cells[6].Value.ToString() == "Lễ tân") cbChucVu.SelectedIndex = 1;
            if (dataGridView1.Rows[index].Cells[6].Value.ToString() == "Quản lý") cbChucVu.SelectedIndex = 2;
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                formtrangchu form = new formtrangchu();
                Data data = new Data(form.funData);
                data(txtcv.Text);
                form.Show();
                Visible = false;
            }
            else
            {

                HienThiDuLieu();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    }
