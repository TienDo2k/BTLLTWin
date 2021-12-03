using System;
using System.Collections.Generic;

#nullable disable

namespace BTLLTWin.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            DichVuKhachHangs = new HashSet<DichVuKhachHang>();
            HoaDons = new HashSet<HoaDon>();
        }

        public string MaKh { get; set; }
        public string TenKh { get; set; }
        public string SoCmnd { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }

        public virtual ICollection<DichVuKhachHang> DichVuKhachHangs { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
