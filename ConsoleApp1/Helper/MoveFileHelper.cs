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
        }
    }
}
