using System;
using System.Collections.Generic;

#nullable disable

namespace BTLLTWin.Models
{
    public partial class MenuDichVu
    {
        public MenuDichVu()
        {
            CthddichVus = new HashSet<CthddichVu>();
            DatDichVus = new HashSet<DatDichVu>();
            DichVuKhachHangs = new HashSet<DichVuKhachHang>();
        }

        public string MaDichVu { get; set; }
        public string TenDichVu { get; set; }
        public double DonGia { get; set; }
        public int Slc { get; set; }

        public virtual ICollection<CthddichVu> CthddichVus { get; set; }
        public virtual ICollection<DatDichVu> DatDichVus { get; set; }
        public virtual ICollection<DichVuKhachHang> DichVuKhachHangs { get; set; }
    }
}
