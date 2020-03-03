using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Helper
{
    public class LeCodeHelper
    {
        public static int Q_84(int[] heights)
        {
            var result = 0;
            var length = heights.Length;
            var continuity = 1;
            //遍历所有的柱形
            for (int i = 0; i < length; i += continuity)
            {
                continuity = 1;
                var check = true;
                int left = i - 1;//左坐标
                int right = i + 1;//右坐标

                int equel = i;//
                int h = heights[i];
                //往左找
                for (; left >= 0; left--)
                {
                    if (heights[left] < h) break;
                }
                //往右找
                for (; right < length; right++)
                {
                    if (check)
                    {
                        if(heights[right] == h) 
                        { 
                            continuity++; 
                        }
                        else
                        {
                            check = false;
                        }
                        
                    }
                    
                    if (heights[right] < h) {
                        break;
                    } 
                }

                var area = (right - left - 1) * h;

                result = result >= area ? result : area;

            }
            return result;
        }

        public static int[] Q_1(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++){
                var index = Array.IndexOf(nums, target - nums[i]);
                if(index != -1 && index != i)
                {
                    return new int[] { i , index};
                }
            }

            return new int[] { 0,1 };
        }
    }
}
