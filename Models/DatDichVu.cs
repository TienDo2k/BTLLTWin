using System;
using System.Collections.Generic;

#nullable disable

namespace BTLLTWin.Models
{
    public partial class DatDichVu
    {
        public string MaDatDv { get; set; }
        public string MaNcc { get; set; }
        public string MaDichVu { get; set; }
        public DateTime NgayDatDv { get; set; }
        public int Sld { get; set; }
        public double DonGia { get; set; }
        public string TrangThai { get; set; }

        public virtual MenuDichVu MaDichVuNavigation { get; set; }
        public virtual NhaCc MaNccNavigation { get; set; }
    }
}
