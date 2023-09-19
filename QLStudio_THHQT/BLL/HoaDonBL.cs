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
    internal class HoaDonBL
    {
        private Controls_DAL da = new Controls_DAL();
        public DataTable loadDataHoaDon()
        {
            return da.ExecProcedureNotPar("GetTableHoaDon");
        }

        public int insertHoaDon(HoaDon hd, string maKH, string maDV)
        {
            string par = string.Format("exec dbo.InsertHoaDon '{0}', '{1}', '{2}', '{3}', '{4}'", hd.maHD, DateTime.Parse(hd.ngayLap.ToString()).ToString("d"),hd.maNV, maKH, maDV);
            return da.ExecProcedureNonQuery(par);
        }

        public int updateHoaDon(HoaDon hd, string maKH, string maDV)
        {
            string par = string.Format("exec dbo.UpdateHoaDon '{0}', '{1}', '{2}', '{3}', '{4}'", hd.maHD, hd.ngayLap, hd.maNV, maKH, maDV);
            return da.ExecProcedureNonQuery(par);
        }

        public DataTable loadDataCTHD(string maHD)
        {
            string par = string.Format("exec dbo.ThongTinCTHD '{0}'",maHD);
            return da.ExecProcedureQuery(par);
        }
        public int deleteHoaDon(string maHD)
        {
            string par = string.Format("exec dbo.DeleteHoaDon '{0}'", maHD);
            return da.ExecProcedureNonQuery(par);
        }

        public DataTable searchDichVu(string input)
        {
            return da.ExecProcedureQuery("exec dbo.proc_timkiembangDICHVU N'" + input + "'");
        }
    }
}
