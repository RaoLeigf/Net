using ConsoleApp1.Helper;
using ConsoleApp1.Model;
using ConsoleApp1.Model.Demo;
using Dapper;
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


            #region 中文数字转换
            //for(; ; )
            //{
            //    var s = Console.ReadLine();
            //    Console.WriteLine(ChineseNumSortHelper.ConvertToString(int.Parse(s)));
            //}

            #endregion

            #region 快速迁移Dll
            //MoveFileHelper.MoveG6HDll();
            MoveFileHelper.MoveMSYHDll();
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

            #region 连接MySql数据库
//            using (var con = SqlBaseHelper.GetAliyunMySqlConnection())
//            {
//                var sql = @"SELECT ifnull(age,null) SecondHighestSalary 
//FROM Test_User
//ORDER BY age desc
//limit 4,1";
//                var sql2 = @"SELECT ifnull((select distinct age from Test_User order by age desc limit 4,1),null) age";
//                var result = con.Query<TestUserModel>(sql);
//                var result2 = con.Query<TestUserModel>(sql2);
//                foreach (var r in result)
//                {
//                    Console.WriteLine(r.Name);
//                }
//            }

            #endregion

            #region 转换大小写
            //Console.WriteLine(StringHelper.ToLower(string.Empty));
            #endregion

            #region 导出Excel
            //ExcelHelper.exportExcel();
            #endregion

            #region 字符串排序
            //var data = new List<string> { "01", "02", "0101", "0201", "0102" };
            //data.Sort();

            //data.ForEach(p =>
            //{
            //    Console.WriteLine(p);
            //});
            //
            #endregion

            #region 乐扣
            //LeCodeHelper.Q_1(new int[] { 3, 2, 4},6);
            #endregion

            #region 定时任务
            //QuartzHelper.Run();
            #endregion

            Console.ReadLine();

        }

    }       
}
