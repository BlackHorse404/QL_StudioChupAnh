using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLStudio_THHQT.DTO
{
    public class HoaDon
    {
        public HoaDon(string maHD, DateTime ngayLap, string maNV)
        {
            this.maHD = maHD;
            this.ngayLap = ngayLap;
            this.maNV = maNV;
        }
        public HoaDon() { }
        public string maHD { get; set; }
        public DateTime ngayLap { get; set; }
        public string maNV { get; set; }
    }
}
