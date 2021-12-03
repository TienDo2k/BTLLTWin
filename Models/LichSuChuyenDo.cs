using System;
using System.Collections.Generic;

#nullable disable

namespace BTLLTWin.Models
{
    public partial class LichSuChuyenDo
    {
        public int MaLichSu { get; set; }
        public string MaPhong { get; set; }
        public string MaVatTu { get; set; }
        public string TenVatTu { get; set; }
        public int Sl { get; set; }
        public int Id { get; set; }
        public double TriGia { get; set; }
        public DateTime NgayChuyenVao { get; set; }
        public DateTime? NgayChuyenDi { get; set; }
        public string TinhTrang { get; set; }

        public virtual ThietBiVatTu IdNavigation { get; set; }
    }
}
