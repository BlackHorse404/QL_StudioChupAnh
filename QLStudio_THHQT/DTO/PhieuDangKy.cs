using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLStudio_THHQT.DTO
{
    public class PhieuDangKy
    {
        public PhieuDangKy(string maDK, DateTime ngayDK, string maKH, string ghiChu, string maDV)
        {
            this.maDK = maDK;
            this.ngayDK = ngayDK;
            this.maKH = maKH;
            this.ghiChu = ghiChu;
            this.maDV = maDV;
        }
        public PhieuDangKy() { }

        public string maDK { get; set; }
        public DateTime ngayDK { get; set; }
        public string maKH { get; set; }
        public string ghiChu { get; set; }
        public string maDV { get; set; }
    }
}
