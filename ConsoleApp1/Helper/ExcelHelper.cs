using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
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

            //sheet.DisplayGridlines = false;//无边框

            //创建一个10行，6列的表格
            var rowNum = 10; //10行
            var cellNum = 6; //6列
            for (var i = 0; i < rowNum; i++)
            {
                var row = sheet.CreateRow(i);
                for (var j = 0; j < cellNum; j++)
                {
                    row.CreateCell(j);
                }
            }
            IFont font1 = book.CreateFont();
            font1.FontHeightInPoints = (short)20;

            //第一行，输入标题 工会经费收支结算表
            var cell_00 = sheet.GetRow(0).GetCell(0);
            cell_00.SetCellValue("工会经费收支结算表");
            sheet.GetRow(0).Height = 20 * 20;
            ICellStyle cellStyle = book.CreateCellStyle();
            cellStyle.VerticalAlignment = VerticalAlignment.Justify;//垂直对齐
            cellStyle.Alignment = HorizontalAlignment.Center;//水平对齐
            cellStyle.SetFont(font1);
            cell_00.CellStyle = cellStyle;
            
            var region = new CellRangeAddress(0, 0, 0, 5);
            sheet.AddMergedRegion(region);
            
            //第二行 编制单位
            var orgName = "广东省总工会";
            region = new CellRangeAddress(1, 1, 0, 1);
            sheet.AddMergedRegion(region);
            var cell_10 = sheet.GetRow(1).GetCell(0);
            cellStyle = book.CreateCellStyle();
            cellStyle.VerticalAlignment = VerticalAlignment.Justify;//垂直对齐
            cellStyle.Alignment = HorizontalAlignment.Left;//水平对齐
            cell_10.SetCellValue($"编制单位:{orgName}");
            cell_10.CellStyle = cellStyle;
            

            //第二行 编制日期
            var date = DateTime.Now;
            var cell_12 = sheet.GetRow(1).GetCell(2);
            cellStyle = book.CreateCellStyle();
            cellStyle.VerticalAlignment = VerticalAlignment.Justify;//垂直对齐
            cellStyle.Alignment = HorizontalAlignment.Center;//水平对齐
            cell_12.SetCellValue($"编制日期:{date.ToString("D")}");
            cell_12.CellStyle = cellStyle;
            region = new CellRangeAddress(1, 1, 2, 3);
            sheet.AddMergedRegion(region);

            //第二行 单位:元
            var cell_15 = sheet.GetRow(1).GetCell(5);
            cellStyle = book.CreateCellStyle();
            cellStyle.VerticalAlignment = VerticalAlignment.Justify;//垂直对齐
            cellStyle.Alignment = HorizontalAlignment.Right;//水平对齐
            cell_15.SetCellValue($"单位:元");
            cell_15.CellStyle = cellStyle;


            using (FileStream fs = File.OpenWrite("d:\\excel.xls"))
            {
                book.Write(fs);//向打开的这个xls文件中写入并保存。  
            }

            Console.WriteLine("导出成功");
        }
    }
}
