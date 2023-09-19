using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLStudio_THHQT.DTO;
using QLStudio_THHQT.DAL;
using System.Data;

namespace QLStudio_THHQT.BLL
{
    internal class DichVuBL
    {
        private Controls_DAL da = new Controls_DAL();
        public DataTable loadDataDichVu()
        {
            return da.ExecProcedureNotPar("GetTableDichVu");
        }

        public string getMaTuDong()
        {
            return da.ExecProcedureNotPar("sinhMaDVTuDong").Rows[0][0].ToString();
        }
        public int insertDichVu(DichVu dv)
        {
            string par = string.Format("exec dbo.InsertDichVu '{0}', N'{1}', N'{2}', {3}", dv.maDV, dv.tenDV,dv.moTa, dv.gia);
            return da.ExecProcedureNonQuery(par);
        }

        public int updateDichVu(DichVu dv)
        {
            string par = string.Format("exec dbo.UpdateDichVu '{0}', N'{1}', N'{2}', {3}", dv.maDV, dv.tenDV, dv.moTa, dv.gia);
        return da.ExecProcedureNonQuery(par);
        }

        public int deleteDichVu(string maDV)
        {
            string par = string.Format("exec dbo.DeleteDichVu '{0}'", maDV);
            return da.ExecProcedureNonQuery(par);
        }

        public DataTable searchDichVu(string input)
        {
            return da.ExecProcedureQuery("exec dbo.proc_timkiembangDICHVU N'" + input + "'");
        }

        public DataTable TopDichVuMoi()
        {
            DataTable t = da.ExecProcedureNotPar("dbo.LayNamDichVuMoiNhat");
            return t;
        }
    }
}
