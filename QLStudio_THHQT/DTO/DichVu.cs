using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLStudio_THHQT.DTO
{
    public class DichVu
    {
        public DichVu(string maDV, string tenDV, string moTa, float gia)
        {
            this.maDV = maDV;
            this.tenDV = tenDV;
            this.moTa = moTa;
            this.gia = gia;
        }
        public DichVu() { }
        public string maDV { get; set; }
        public string tenDV { get; set; }
        public string moTa { get; set; }
        public float gia { get; set; }
    }
}
