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
    internal class PhieuDangKyBL
    {
        private Controls_DAL da = new Controls_DAL();
        public DataTable loadDataPhieuDangKy()
        {
            return da.ExecProcedureNotPar("GetTablePhieuDangKy");
        }

        public int insertPhieuDangKy(PhieuDangKy pdk, string maKH, string maDV)
        {
            string par = string.Format("exec dbo.InsertPhieuDangKy '{0}', '{1}', '{2}', N'{3}', '{4}'", pdk.maDK, DateTime.Parse(pdk.ngayDK.ToString()).ToString("dd-MM-yyyy"), maKH, pdk.ghiChu, maDV);
            return da.ExecProcedureNonQuery(par);
        }

        public int updatePhieuDangKy(PhieuDangKy pdk, string maKH, string maDV)
        {
            string par = string.Format("exec dbo.UpdatePhieuDangKy '{0}', '{1}', '{2}', N'{3}', '{4}'", pdk.maDK, DateTime.Parse(pdk.ngayDK.ToString()).ToString("dd-MM-yyyy"), maKH, pdk.ghiChu, maDV);
            return da.ExecProcedureNonQuery(par);
        }
        public int deletePhieuDangKy(PhieuDangKy pdk)
        {
            string par = string.Format("exec dbo.DeletePhieuDangKy '{0}'", pdk.maDK);
            return da.ExecProcedureNonQuery(par);
        }
        public int deletePhieuDangKy(string maPDK)
        {
            string par = string.Format("exec dbo.DeletePhieuDangKy '{0}'", maPDK);
            return da.ExecProcedureNonQuery(par);
        }
    }
}
