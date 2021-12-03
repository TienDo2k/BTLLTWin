using System;
using System.Collections.Generic;

#nullable disable

namespace BTLLTWin.Models
{
    public partial class Phong
    {
        public Phong()
        {
            DatPhongs = new HashSet<DatPhong>();
            HoaDons = new HashSet<HoaDon>();
            ThietBiVatTus = new HashSet<ThietBiVatTu>();
        }

        public string MaPhong { get; set; }
        public string TenPhong { get; set; }
        public string LoaiPhong { get; set; }
        public string TinhTrang { get; set; }
        public int SoNguoiToiDa { get; set; }
        public double Gia { get; set; }

        public virtual ICollection<DatPhong> DatPhongs { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public virtual ICollection<ThietBiVatTu> ThietBiVatTus { get; set; }
    }
}
