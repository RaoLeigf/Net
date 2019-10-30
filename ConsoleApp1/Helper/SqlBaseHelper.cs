using Oracle.ManagedDataAccess.Client;
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
        /// <summary>
        /// 获取Wfm_SqlServer连接
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetWfmSqlServerConnection()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["wfm_sqlserver"].ConnectionString;
            return new SqlConnection(connectionString);
        }

        /// <summary>
        /// 获取Dqw_Oracle连接
        /// </summary>
        /// <returns></returns>
        public static OracleConnection GetDqwOracleConnection()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["dqw_oracle"].ConnectionString;
            var connection = new OracleConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
