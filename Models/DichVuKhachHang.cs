using System;
using System.Collections.Generic;

#nullable disable

namespace BTLLTWin.Models
{
    public partial class DichVuKhachHang
    {
        public string MaDichVu { get; set; }
        public DateTime NgaySuDung { get; set; }
        public string MaKh { get; set; }
        public string TinhTrang { get; set; }
        public int SoLuong { get; set; }
        public int Id { get; set; }

        public virtual MenuDichVu MaDichVuNavigation { get; set; }
        public virtual KhachHang MaKhNavigation { get; set; }
    }
}
