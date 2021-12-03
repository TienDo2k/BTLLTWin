using System;
using System.Collections.Generic;

#nullable disable

namespace BTLLTWin.Models
{
    public partial class NhaCc
    {
        public NhaCc()
        {
            DatDichVus = new HashSet<DatDichVu>();
        }

        public string MaNcc { get; set; }
        public string TenNcc { get; set; }
        public string DiaChi { get; set; }

        public virtual ICollection<DatDichVu> DatDichVus { get; set; }
    }
}
