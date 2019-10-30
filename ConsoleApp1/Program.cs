using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 快速迁移
            new Helper.MoveFileHelper().MoveG6HDll();
            #endregion

            #region sqlServer数据库连接
            //using (var con = new Helper.SqlBaseHelper().GetWfmSqlServerConnection())
            //{
            //    var sql = @"SELECT  rightkey
            //                FROM fg3_userrights
            //                WHERE userId =  113191025000001 AND rightkey NOT IN (SELECT rightkey FROM fg3_userrights WHERE userId = 113191025000003)";

            //    var res = con.Query<string>(sql);

            //    var s = string.Empty;
            //    foreach (var r in res)
            //    {
            //        s += (r + ",");
            //    }
            //    Console.WriteLine(s);
            //}

            #endregion
            Console.ReadLine();

        }

    }       
}
