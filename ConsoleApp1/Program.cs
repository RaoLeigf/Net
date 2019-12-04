using ConsoleApp1.Helper;
using ConsoleApp1.Model;
//using Dapper;
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
        static void Main()
        {

            #region 快速迁移Dll
            MoveFileHelper.MoveG6HDll();
            #endregion

            #region 快速迁移Orm
            //MoveFileHelper.MoveOrmFile();
            #endregion

            #region sqlServer数据库连接

            //using (var con = SqlBaseHelper.GetWfmSqlServerConnection())
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

            #region 连接oracle数据库
            //using (var con = SqlBaseHelper.GetDqwOracleConnection())
            //{
            //    var sql = "select P_Name Name,P_Type Type from NG0002.GIA_ITEMS";
            //    var result = con.Query<GiaItemModel>(sql);
            //    foreach(var r in result)
            //    {
            //        Console.WriteLine(r.Name);
            //    }
            //}

            #endregion

            #region 转换大小写
            //Console.WriteLine(StringHelper.ToLower(string.Empty));
            #endregion

            #region 导出Excel
            //ExcelHelper.exportExcel();
            #endregion
            Console.ReadLine();

        }

    }       
}
