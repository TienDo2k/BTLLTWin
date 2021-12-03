using System;
using System.Collections.Generic;

#nullable disable

namespace BTLLTWin.Models
{
    public partial class TaiKhoan
    {
        public string MaNv { get; set; }
        public string MatKhau { get; set; }

        public virtual NhanVien MaNvNavigation { get; set; }
    }
}
