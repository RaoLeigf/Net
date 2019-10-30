using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace ConsoleApp1.Helper
{
    /// <summary>
    /// 存放各种数据库的连接
    /// </summary>
    public class SqlBaseHelper
    {
        public SqlConnection GetWfmSqlServerConnection()
        {
            var ConnectionString = ConfigurationManager.ConnectionStrings["wfm_sqlserver"].ConnectionString;
            return new SqlConnection(ConnectionString);
        }
    }
}
