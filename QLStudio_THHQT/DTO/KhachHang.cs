using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLStudio_THHQT.DTO
{
    public class KhachHang
    {
        public KhachHang(string maKH, string hoTen, string gioiTinh, DateTime ngaySinh, string sdt, string diaChi)
        {
            this.maKH = maKH;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.sdt = sdt;
            this.diaChi = diaChi;
        }
        public KhachHang() { }
        public string maKH { get; set; }
        public string hoTen { get; set; }
        public string gioiTinh { get; set; }
        public DateTime ngaySinh { get; set; }
        public string sdt { get; set; }
        public string diaChi { get; set; }
    }
}
