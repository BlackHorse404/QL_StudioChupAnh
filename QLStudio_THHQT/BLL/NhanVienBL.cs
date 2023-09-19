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
        private NhanVien_DAL da = new NhanVien_DAL();
        public DataTable loadDataNhanVien()
        {
            return da.ExecProcedureNotPar("GetTableNhanVien");
        }

        public int insertNhanVien(DichVu dv)
        {
            string par = string.Format("exec dbo.InsertDichVu '{0}', N'{1}', N'{2}', {3}", dv.maDV, dv.tenDV, dv.moTa, dv.gia);
            return da.ExecProcedureNonQuery(par);
        }
    }
}
