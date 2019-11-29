using NPOI.HSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1.Helper
{
    public class ExcelHelper
    {
        /// <summary>
        /// 导出Excel
        /// </summary>
        /// <returns></returns>
        public static void exportExcel()
        {
            var book = new HSSFWorkbook();

            //测试新建一个sheet
            var sheet = book.CreateSheet("例子");

            var row = sheet.CreateRow(0);
            var cell = row.CreateCell(0);
            cell.SetCellValue("第一行第一列");

            using (FileStream fs = File.OpenWrite("d:\\excel.xls"))
            {
                book.Write(fs);//向打开的这个xls文件中写入并保存。  
            }
        }
    }
}
