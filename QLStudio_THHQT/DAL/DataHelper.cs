using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QLStudio_THHQT.DTO;

namespace QLStudio_THHQT.DAL
{
    public class DataHelper
    {
        private string serverName = "PHAT-MSI\\DBPHAT";
        private string DBname = "QL_Studio";
        public SqlConnection conn;

        public DataHelper()
        {
            string connString = @"Data Source="+serverName+";Initial Catalog="+ DBname + ";Integrated Security=True";
            conn = new SqlConnection(connString);
        }
    }
}
