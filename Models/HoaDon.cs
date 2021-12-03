using System;
using System.Collections.Generic;

#nullable disable

namespace BTLLTWin.Models
{
    public partial class HoaDon
    {
        public string MaHd { get; set; }
        public string MaKh { get; set; }
        public string MaPhong { get; set; }
        public DateTime NgayDen { get; set; }
        public DateTime NgayDi { get; set; }
        public string TtthanhToan { get; set; }

        public virtual KhachHang MaKhNavigation { get; set; }
        public virtual Phong MaPhongNavigation { get; set; }
    }
}
