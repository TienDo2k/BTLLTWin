using System;
using System.Collections.Generic;

#nullable disable

namespace BTLLTWin.Models
{
    public partial class ThietBiVatTu
    {
        public ThietBiVatTu()
        {
            BaoTris = new HashSet<BaoTri>();
            LichSuChuyenDos = new HashSet<LichSuChuyenDo>();
        }

        public int Id { get; set; }
        public string MaPhong { get; set; }
        public string MaVatTu { get; set; }
        public string TenVatTu { get; set; }
        public int Sl { get; set; }
        public double TriGia { get; set; }
        public DateTime NgayChuyenVao { get; set; }
        public string TinhTrang { get; set; }

        public virtual Phong MaPhongNavigation { get; set; }
        public virtual ICollection<BaoTri> BaoTris { get; set; }
        public virtual ICollection<LichSuChuyenDo> LichSuChuyenDos { get; set; }
    }
}
