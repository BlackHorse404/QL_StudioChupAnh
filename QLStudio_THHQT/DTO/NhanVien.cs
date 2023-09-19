using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLStudio_THHQT.DTO
{
    public class NhanVien
    {
        public NhanVien(string manv, string hoten, string sdt, string diachi, string gioitinh, string chucvu, string maql, DateTime? ngaysinh)
        {
            this.manv = manv;
            this.hoten = hoten;
            this.sdt = sdt;
            this.diachi = diachi;
            this.gioitinh = gioitinh;
            this.chucvu = chucvu;
            this.maql = maql;
            this.ngaysinh = ngaysinh;
        }
        public NhanVien() {}
        public string manv { get; set; }
        public string hoten { get; set; }
        public string sdt { get; set; }
        public string diachi { get; set; }
        public string gioitinh { get; set; }
        public string chucvu { get; set; }
        public string maql { get; set; }
        public DateTime? ngaysinh { get; set; }
    }
}
