using Dapper;
using System;
using System.Collections.Generic;
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
            //string path = @"F:\Code\WorkSpace\G6H_5.1R_JS\BusinessDlls";
            //string path2 = @"E:\G6HMidServer\NGWebSite";
            //string prefix = @"GJS3.JS.";
            ////string prefix2 = @"GQT3.QT.";
            //List<string> binFileNames = new List<string>
            //{
            //    "Controller.dll",
            //    "Model.dll"
            //};
            //List<string> ruleFileNames = new List<string>
            //{
            //    "Dac.dll",
            //    "Dac.Interface.dll",
            //    "Facade.dll",
            //    "Facade.Interface.dll",
            //    "Rule.dll",
            //    "Rule.Interface.dll",
            //    "Service.dll",
            //    "Service.Interface.dll"
            //};
            //binFileNames.ForEach(p =>
            //{
            //    Console.WriteLine($"{path}\\bin\\{prefix}{p}  to {path2}\\bin\\{prefix}{p}");
            //    File.Copy($"{path}\\bin\\{prefix}{p}", $"{path2}\\bin\\{prefix}{p}", true);//允许覆盖目的地的同名文件
            //    //Console.WriteLine($"{path}\\bin\\{prefix2}{p}  to {path2}\\bin\\{prefix2}{p}");
            //    //File.Copy($"{path}\\bin\\{prefix2}{p}", $"{path2}\\bin\\{prefix2}{p}", true);//允许覆盖目的地的同名文件
            //});


            //ruleFileNames.ForEach(p =>
            //{
            //    Console.WriteLine($"{path}\\Rules\\{prefix}{p}  to {path2}\\I6Rules\\{prefix}{p}");
            //    File.Copy($"{path}\\Rules\\{prefix}{p}", $"{path2}\\I6Rules\\{prefix}{p}", true);//允许覆盖目的地的同名文件
            //    //Console.WriteLine($"{path}\\bin\\{prefix2}{p}  to {path2}\\bin\\{prefix2}{p}");
            //    //File.Copy($"{path}\\Rules\\{prefix2}{p}", $"{path2}\\I6Rules\\{prefix2}{p}", true);//允许覆盖目的地的同名文件
            //});
            #endregion
            #region sqlServer数据库连接
            using (var con = new Helper.SqlBaseHelper().GetWfmSqlServerConnection())
            {
                var sql = @"SELECT  rightkey
                            FROM fg3_userrights
                            WHERE userId =  113191025000001 AND rightkey NOT IN (SELECT rightkey FROM fg3_userrights WHERE userId = 113191025000003)";

                var res = con.Query<string>(sql);

                var s = string.Empty;
                foreach (var r in res)
                {
                    s += (r + ",");
                }
                Console.WriteLine(s);
            }

            #endregion
            Console.ReadLine();

        }

    }       
}
