using System;
using System.Collections.Generic;

#nullable disable

namespace BTLLTWin.Models
{
    public partial class DatPhong
    {
        public int Id { get; set; }
        public string SoCmnd { get; set; }
        public string HoTen { get; set; }
        public string Sdt { get; set; }
        public DateTime NgayDatPhong { get; set; }
        public DateTime NgayDi { get; set; }
        public string MaPhong { get; set; }

        public string TinhTrangDp { get; set; }
        public virtual Phong MaPhongNavigation { get; set; }
    }
}
