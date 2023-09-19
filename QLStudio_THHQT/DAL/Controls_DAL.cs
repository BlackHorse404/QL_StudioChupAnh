using System.Data.SqlClient;
using System.Data;
using QLStudio_THHQT.Ultilities;
using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace QLStudio_THHQT.DAL
{
    public class Controls_DAL
    {
        SqlConnection conn = DBconfig.getConnection();

        public DataTable ExecProcedureNotPar(string nameProc)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(nameProc, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                return table;
            }
            catch(SqlException err)
            {
                More.showNoticeErrorFromSQL(err.Number);
                return null;
            }
        }

        public int ExecProcedureNonQuery(string nameProc)
        {
            try
            {
                SqlCommand cmd;
                if (nameProc.StartsWith("sp_"))
                    cmd = new SqlCommand(nameProc, conn);
                else
                    cmd = new SqlCommand("SET DATEFORMAT DMY " + nameProc, conn);
                cmd.CommandType = CommandType.Text;
                if(conn.State == ConnectionState.Closed)
                    conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;// thanh cong
            }
            catch (SqlException err)
            {
                MessageBox.Show(DBconfig.getConnection().ToString());
                More.showNoticeErrorFromSQL(err.Number);
                return -1;
            }
        }

        public DataTable ExecProcedureQuery(string nameProc)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(nameProc, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable t = new DataTable();
                da.Fill(t);
                return t;// thanh cong
            }
            catch (SqlException err)
            {
                More.showNoticeErrorFromSQL(err.Number);
                return null;
            }
        }

        public int ExecProcedureScalar(string nameProc)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(nameProc, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                int num = (int)cmd.ExecuteScalar();
                conn.Close();
                return num;// thanh cong > -1
            }
            catch (SqlException err)
            {
                conn.Close();
                More.showNoticeErrorFromSQL(err.Number);
                return -1;
            }
        }

        public int ExecProcedureGetReturnValue(string nameProc, string namePermission, string username)
        {
            int num = -1;
            try
            {
                SqlCommand cmd = new SqlCommand(nameProc, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                cmd.Parameters.Add("@nameProc", SqlDbType.VarChar).Value = namePermission;
                //get value return
                var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                cmd.ExecuteNonQuery();
                num = int.Parse(returnParameter.Value.ToString());
                conn.Close();
                return num;// thanh cong
            }
            catch (SqlException err)
            {
                conn.Close();
                More.showNoticeErrorFromSQL(err.Number);
                return -1;
            }
        }

        public int ExecProcCheckMemberIsOfRole(string nameProc, string username, string roleName)
        {
            int num = -1;
            try
            {
                SqlCommand cmd = new SqlCommand(nameProc, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                cmd.Parameters.Add("@roleName", SqlDbType.VarChar).Value = roleName;
                //get value return
                var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                cmd.ExecuteNonQuery();
                num = int.Parse(returnParameter.Value.ToString());
                conn.Close();
                return num;// thanh cong
            }
            catch (SqlException err)
            {
                conn.Close();
                More.showNoticeErrorFromSQL(err.Number);
                return -1;
            }
        }

        public int ExecImportBCP(string nameProc, string path, string tableName)
        {
            int num = -1;
            try
            {
                SqlCommand cmd = new SqlCommand(nameProc, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@tableName", SqlDbType.VarChar).Value = tableName;
                cmd.Parameters.Add("@path", SqlDbType.VarChar).Value = path;
                //get value return
                var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                cmd.ExecuteNonQuery();
                num = int.Parse(returnParameter.Value.ToString());
                conn.Close();
                return num;// thanh cong
            }
            catch (SqlException err)
            {
                conn.Close();
                More.showNoticeErrorFromSQL(err.Number);
                return -1;
            }
        }
    }
}
