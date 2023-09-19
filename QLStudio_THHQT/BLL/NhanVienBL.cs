using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLStudio_THHQT.DAL;
using System.Data;
using QLStudio_THHQT.DTO;

namespace QLStudio_THHQT.BLL
{
    public class NhanVienBL
    {
        private Controls_DAL da = new Controls_DAL();
        public DataTable loadDataNhanVien()
        {
            return da.ExecProcedureNotPar("GetTableNhanVien");
        }

        public int insertNhanVien(NhanVien nv)
        {
            string par = string.Format("exec dbo.InsertNhanVien '{0}', N'{1}', '{2}', N'{3}', N'{4}', N'{5}', '{6}', '{7}'", nv.manv, nv.hoten, nv.sdt, nv.diachi, nv.gioitinh, nv.chucvu, nv.maql, DateTime.Parse(nv.ngaysinh.ToString()).ToString("dd-MM-yyyy"));
            return da.ExecProcedureNonQuery(par);
        }

        public int updateNhanVien(NhanVien nv)
        {
            string par = string.Format("exec dbo.UpdateNhanVien '{0}', N'{1}', '{2}', N'{3}', N'{4}', N'{5}', '{6}', '{7}'", nv.manv, nv.hoten, nv.sdt, nv.diachi, nv.gioitinh, nv.chucvu, nv.maql, DateTime.Parse(nv.ngaysinh.ToString()).ToString("dd-MM-yyyy"));
            return da.ExecProcedureNonQuery(par);
        }
        public int deleteNhanVien(NhanVien nv)
        {
            string par = string.Format("exec dbo.DeleteNhanVien '{0}'", nv.manv);
            return da.ExecProcedureNonQuery(par);
        }
        public int deleteNhanVien(string maNV)
        {
            string par = string.Format("exec dbo.DeleteNhanVien '{0}'",maNV);
            return da.ExecProcedureNonQuery(par);
        }

        public DataTable searchNhanVien(string input)
        {
            return da.ExecProcedureQuery("exec proc_timkiembangNHANVIEN N'" + input + "'");
        }
    }
}
