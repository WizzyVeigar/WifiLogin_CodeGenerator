using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WifiLogin_CodeGenerator
{
    class SqlCommands : DBCommands<WifiCode>
    {
        SqlController sqlConn = new SqlController();
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        SqlDataAdapter da = new SqlDataAdapter();

        public override void AddMultipleToDb(List<WifiCode> listOfData)
        {
            throw new NotImplementedException();
        }

        public override void AddObjToDb(WifiCode obj)
        {
            
            sqlCommand = new SqlCommand("Query", sqlConn.GetSqlConnection());
            sqlConn.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConn.Close();
        }

        public override void AddToDb(string data)
        {
            throw new NotImplementedException();
        }

        public override DataTable GetDb()
        {
            throw new NotImplementedException();
        }
    }
}
