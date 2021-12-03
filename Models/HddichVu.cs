using System;
using System.Collections.Generic;

#nullable disable

namespace BTLLTWin.Models
{
    public partial class HddichVu
    {
        public HddichVu()
        {
            CthddichVus = new HashSet<CthddichVu>();
        }

        public string MaHd { get; set; }
        public string TenHd { get; set; }
        public DateTime NgayLap { get; set; }

        public virtual ICollection<CthddichVu> CthddichVus { get; set; }
    }
}
