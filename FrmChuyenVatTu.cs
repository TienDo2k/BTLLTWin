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
    public partial class FrmChuyenVatTu : Form
    {
        
        BTLLTWinContext db = new BTLLTWinContext();
        public FrmChuyenVatTu()
        {
            InitializeComponent();
        }
        public delegate void Data(string text);
        public void funData(string txt)
        {
            txtcv.Text = txt;
        }
        private void bt_thoat_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN THOÁT?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                FrmThietbivattu form1 = new FrmThietbivattu();
                form1.Show();
                Visible = false;
            }

        }
        private void HienThiDuLieu()
        {
            var query = from s in db.LichSuChuyenDos
                        select new
                        {
                            s.MaLichSu,
                            s.MaVatTu,
                            s.TenVatTu,
                            s.Sl,
                            s.TriGia,
                            s.NgayChuyenVao,
                            s.NgayChuyenDi,
                            s.TinhTrang,
                            s.MaPhong
                        };
            dtv_lichsuchuyen.DataSource = query.ToList();
            
        }
        private void FrmChuyenVatTu_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            string keyword = txt_tenvt.Text.Trim();
            dtv_lichsuchuyen.DataSource = db.LichSuChuyenDos.Where(emp => emp.TenVatTu.Contains(keyword)).ToList();
        }

        private void dtv_lichsuchuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }
    }
}
