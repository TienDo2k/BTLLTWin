using System;
using System.Collections.Generic;

#nullable disable

namespace BTLLTWin.Models
{
    public partial class NhanVien
    {
        public string MaNv { get; set; }
        public string TenNv { get; set; }
        public string GioiTinh { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string ChucVu { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
