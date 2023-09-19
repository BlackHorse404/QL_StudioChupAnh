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
    class DBSystemBL
    {
        private Controls_DAL da = new Controls_DAL();

        public int backupDB(string path)
        {
            string query = string.Format("exec SaoLuuDB '{0}'",path);
            return da.ExecProcedureNonQuery(query);
        }

        public int restoreDB(string path)
        {
            string query = string.Format("exec phucHoiDB '{0}'", path);
            return da.ExecProcedureNonQuery(query);
        }
    }
}
