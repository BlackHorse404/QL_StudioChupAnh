using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLStudio_THHQT.DAL;

namespace QLStudio_THHQT.BLL
{
    class ImportExportData
    {
        private Controls_DAL da = new Controls_DAL();

        public int exportData(string tableName, string path)
        {
            return da.ExecProcedureNonQuery(string.Format("exec ExportDataFromTable '{0}', '{1}'",tableName, path));
        }
        public int importData(string tableName, string path)
        {
            return da.ExecImportBCP("ImportDataFromTable", path, tableName);
        }
    }
}
