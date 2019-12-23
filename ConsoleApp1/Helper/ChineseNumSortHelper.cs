using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Helper
{
    public static class ChineseNumSortHelper
    {
        public static int ConvertToInt(string num_cn)
        {
            var sum = 0;

            /* 亿以下转换
             * 先以万为分界线划分左右
             * 左边的值乘10000
             */

            var index_w = num_cn.IndexOf("万");

            if (index_w != -1)
            {
                var lr = num_cn.Split("万");
                sum += ConvertToIntLowW(lr[0]);
                sum += ConvertToIntLowW(lr[1]);
            }
            else
            {
                sum += ConvertToIntLowW(num_cn);
            }

            return sum;
        }


        public static int ConvertToIntLowW(string num_cn)
        {
            var sum = 0;
            var index_w = num_cn.IndexOf("千");
            if(index_w != -1)
            {  
                sum += (int)((CNNum)Enum.Parse(typeof(CNNum), num_cn[index_w - 1].ToString())) * 1000;
            }

            var index_b = num_cn.IndexOf("百");

            if(index_b != -1)
            {  
                sum += (int)((CNNum)Enum.Parse(typeof(CNNum), num_cn[index_b - 1].ToString())) * 100;
            }

            var index_s = num_cn.IndexOf("十");

            if (index_s != -1)
            {
                if("一二三四五六七八九".IndexOf(num_cn[index_s - 1]) != -1)
                {
                    sum += (int)((CNNum)Enum.Parse(typeof(CNNum), num_cn[index_s - 1].ToString())) * 10;
                }
                else
                {
                    sum += 10;
                }  
            }

            if(index_s != num_cn.Length - 1)
            {
                sum += (int)((CNNum)Enum.Parse(typeof(CNNum), num_cn[num_cn.Length - 1].ToString()));
            }

            return sum;

        }

        public static string ConvertToString(int num)
        {
            var s = string.Empty;
            if(num >= 10000)
            {
                var w_l = num / 10000;
                s += ConvertToStringLowW(w_l);

                var w_r = num % 10000;
                if (w_r/1000 == 0)
                {
                    s += "万零";
                }
                else
                {
                    s += "万";
                }
                s += ConvertToStringLowW(w_r);
            }
            else
            {
                s += ConvertToStringLowW(num);
            }
            return s;
        }

        public static string ConvertToStringLowW(int num)
        {
            var s = string.Empty;
            var zeroCheck = false;
            var hasNum = false;
            if(num / 1000 > 0)
            {
                
                s += $"{((CNNum)(num / 1000)).ToString()}千";
                num %= 1000;
                hasNum = true;
            }
            else
            {
                zeroCheck = true;
            }

            if(num / 100 > 0)
            {
                if (zeroCheck)
                {
                    if (hasNum)
                    {
                        s += "零";
                    }
                    
                    zeroCheck = false;
                }

                s += $"{((CNNum)(num / 100)).ToString()}百";
                num %= 100;
                hasNum = true;
            }
            else
            {
                zeroCheck = true;
            }

            

            if (num / 10 > 0)
            {
                if (zeroCheck)
                {
                    if (hasNum)
                    {
                        s += "零";
                    }
                    zeroCheck = false;
                }

                s += $"{((CNNum)(num / 10)).ToString()}十";
                num %= 10;
                hasNum = true;
            }
            else
            {
                zeroCheck = true;
            }

            if(num != 0)
            {
                if (zeroCheck)
                {
                    if (hasNum)
                    {
                        s += "零";
                    }
                    zeroCheck = false;
                }
                s += $"{((CNNum)(num)).ToString()}";
            }
            return s;
        }

        private enum CNNum
        {
            零 = 0,
            一 = 1,
            二 = 2,
            三 = 3,
            四 = 4,
            五 = 5,
            六 = 6,
            七 = 7,
            八 = 8,
            九 = 9
        }


    }
}
