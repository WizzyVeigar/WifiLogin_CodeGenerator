using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WifiLogin_CodeGenerator
{
    class SqlController
    {
        private const string connectionString = @"Server = RO-SKP-01838; Database=somethingnotyet; Integrated Security = true";

        public string ConnectionString
        {
            get
            {
                return connectionString;
            }
        }

        internal void Open()
        {
            using (SqlConnection connection = new SqlConnection("connString"))
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();
            }
        }

        internal void Close()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        internal SqlConnection GetSqlConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
