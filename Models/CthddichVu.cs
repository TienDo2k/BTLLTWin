using System;
using System.Collections.Generic;

#nullable disable

namespace BTLLTWin.Models
{
    public partial class CthddichVu
    {
        public int Stt { get; set; }
        public string MaHd { get; set; }
        public string MaDichVu { get; set; }
        public int SoLuong { get; set; }

        public virtual MenuDichVu MaDichVuNavigation { get; set; }
        public virtual HddichVu MaHdNavigation { get; set; }
    }
}
