using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Helper
{
    public class StringHelper
    {
        /// <summary>
        /// 转大写
        /// </summary>
        /// <returns></returns>
        public static string ToUpper(string s )
        {
            if (string.IsNullOrEmpty(s))
            {
                s = Console.ReadLine();
            }
            return s.ToUpper();
        }

        /// <summary>
        /// 转小写
        /// </summary>
        /// <returns></returns>
        public static string ToLower(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                s = Console.ReadLine();
            }
            return s.ToLower();
        }
    }
}
