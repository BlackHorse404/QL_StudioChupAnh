using QLStudio_THHQT.DAL;
using QLStudio_THHQT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLStudio_THHQT.BLL
{
    internal class KhachHangBL
    {
        private Controls_DAL da = new Controls_DAL();
        public DataTable loadDataKhachHang()
        {
            return da.ExecProcedureNotPar("GetTableKhachHang");
        }

        public int insertKhachHang(KhachHang kh)
        {
            string par = string.Format("exec dbo.InsertKhachHang '{0}', N'{1}', N'{2}', '{3}', '{4}', N'{5}'", kh.maKH, kh.hoTen, kh.gioiTinh, DateTime.Parse(kh.ngaySinh.ToString()).ToString("dd-MM-yyyy"), kh.sdt, kh.diaChi);
            return da.ExecProcedureNonQuery(par);
        }

        public int updateKhachHang(KhachHang kh)
        {
            string par = string.Format("exec dbo.UpdateKhachHang '{0}', N'{1}', N'{2}', '{3}', '{4}', N'{5}'", kh.maKH, kh.hoTen, kh.gioiTinh, kh.ngaySinh, kh.sdt, kh.diaChi);
            return da.ExecProcedureNonQuery(par);
        }
        public int deleteKhachHang(KhachHang kh)
        {
            string par = string.Format("exec dbo.DeleteKhachHang '{0}'", kh.maKH);
            return da.ExecProcedureNonQuery(par);
        }
        public int deleteKhachHang(string maKH)
        {
            string par = string.Format("exec dbo.DeleteKhachHang '{0}'", maKH);
            return da.ExecProcedureNonQuery(par);
        }

        public int countKhachHang()
        {
            return da.ExecProcedureScalar("exec dbo.soLuongKH");
        }

        public string findMaKHFromName(string name)
        {
            DataTable t = da.ExecProcedureQuery(string.Format("exec dbo.timMaKhachHang N'{0}'", name));
            if (t != null && t.Rows.Count != 0)
                return t.Rows[0][0].ToString();
            return string.Empty;
        }

        public DataTable searchKhachHang(string input)
        {
            return da.ExecProcedureQuery("exec proc_timkiembangKHACHHANG N'" + input + "'");
        }
    }
}
