using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Helper
{
    /// <summary>
    /// 移动文件
    /// </summary>
    public class MoveFileHelper
    {
        /// <summary>
        /// 移动G6HDll
        /// </summary>
        /// <param name="soure"></param>
        /// <param name="target"></param>
        /// <param name="prefixs"></param>
        public static void MoveG6HDll()
        {
            if (!IsSure())
            {
                return;
            }
            string source = ConfigurationManager.AppSettings["g6hFileSource"];
            string target = ConfigurationManager.AppSettings["g6hFileTarget"];
            string prefixsString = ConfigurationManager.AppSettings["g6hFilePrefix"];
            var prefixs = prefixsString.Split(';').ToList();

            List<string> binFileNames = new List<string>
            {
                "Controller.dll",
                "Model.dll"
            };

            List<string> ruleFileNames = new List<string>
            {
                "Dac.dll",
                "Dac.Interface.dll",
                "Facade.dll",
                "Facade.Interface.dll",
                "Rule.dll",
                "Rule.Interface.dll",
                "Service.dll",
                "Service.Interface.dll"
            };

            prefixs.ForEach(prefix =>
            {
                //移动bin
                binFileNames.ForEach(p =>
                {
                    Console.WriteLine($"{source}\\bin\\{prefix}{p}  to {target}\\bin\\{prefix}{p}");
                    File.Copy($"{source}\\bin\\{prefix}{p}", $"{target}\\bin\\{prefix}{p}", true);//允许覆盖目的地的同名文件
                });

                //移动rule
                ruleFileNames.ForEach(p =>
                {
                    Console.WriteLine($"{source}\\Rules\\{prefix}{p}  to {target}\\I6Rules\\{prefix}{p}");
                    File.Copy($"{source}\\Rules\\{prefix}{p}", $"{target}\\I6Rules\\{prefix}{p}", true);//允许覆盖目的地的同名文件
                });
            });

            Console.WriteLine("Moving Finished !");
        }

        /// <summary>
        /// 移动生成的Orm文件
        /// </summary>
        public static void MoveOrmFile()
        {
            var source = @"\\10.0.10.11\OutFile\ORMFiles\GJS3.JS\GiaP6Evaluate";
            var files = Directory.GetFiles(source, "*.xml");
            foreach(var f in files)
            {
                var a = File.ReadAllText(f);
                File.AppendAllText(@"C:\Users\raolei\Desktop\新建文件夹\test.xml", a);
                Console.WriteLine(f);
            }
            //var target = @"C:\Users\raolei\Desktop\新建文件夹\P6EvaluateDac.xml";
            //File.Copy(source, target);
        }
        /// <summary>
        /// 是否确认
        /// </summary>
        /// <returns></returns>
        private static bool IsSure()
        {
            Console.WriteLine("Are you Sure ?(Y/N)");
            var check = Console.ReadLine();
            return (String.Equals(check, "Y", StringComparison.CurrentCultureIgnoreCase)|| String.Equals(check, "Yes", StringComparison.CurrentCultureIgnoreCase));
        } 
    }
}
