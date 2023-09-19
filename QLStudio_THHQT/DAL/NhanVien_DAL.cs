using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLStudio_THHQT.DTO;
using System.Data.SqlClient;
using System.Data;

namespace QLStudio_THHQT.DAL
{
    public class NhanVien_DAL
    {
        DataHelper helper = new DataHelper();
        DataColumn[] keys;

        public DataTable ExecProcedureNotPar(string nameProc)
        {
            SqlCommand cmd = new SqlCommand(nameProc, helper.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }

        public int ExecProcedureNonQuery(string nameProc)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(nameProc, helper.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                int line = cmd.ExecuteNonQuery();
                return line;// thanh cong > -1
            }
            catch
            {
                return -1;//that bai
            }
            
        }
    }
}
