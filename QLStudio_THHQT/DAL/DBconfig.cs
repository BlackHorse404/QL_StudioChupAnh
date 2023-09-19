using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QLStudio_THHQT.DTO;

namespace QLStudio_THHQT.DAL
{
    public static class DBconfig
    {
        private static string serverName = "PHAT-MSI\\DBPHAT";
        public static string DBname = "QL_Studio";
        public static string username = string.Empty;
        public static string password = string.Empty;

        public static SqlConnection getConnection()
        {
            string connString = @"Data Source="+serverName+";Initial Catalog="+ DBname + ";Integrated Security=False;User ID = "+username+";password="+password;
            return new SqlConnection(connString);
        }
    }
}
