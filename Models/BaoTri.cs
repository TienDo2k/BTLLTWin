using System;
using System.Collections.Generic;

#nullable disable

namespace BTLLTWin.Models
{
    public partial class BaoTri
    {
        public string MaBaoTri { get; set; }
        public string MaVatTu { get; set; }
        public string TenVatTu { get; set; }
        public string MaPhong { get; set; }
        public string NoiDung { get; set; }
        public DateTime NgayBaoTri { get; set; }
        public int ChuKi { get; set; }
        public int? Id { get; set; }
        public DateTime? NgayBaoTriKeTiep { get; set; }

        public virtual ThietBiVatTu IdNavigation { get; set; }
    }
}
