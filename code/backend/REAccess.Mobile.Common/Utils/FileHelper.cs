#region Using
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
#endregion

namespace REAccess.Mobile.Common.Utils
{
    public static class FileHelper
    {
        public static byte[] GetImageBytes(string imgPath)
        {
            //从图片中读取byte
            var fileBytes = File.ReadAllBytes(imgPath);
            ////从图片中读取流
            //var imgStream = new MemoryStream(fileBytes);

            return fileBytes;
        }

        public static DataTable ReadDataFromFile(Stream stream, bool isColumnName, string sheetName)
        {
            DataTable dataTable = new DataTable();
            DataColumn column = null;
            XSSFWorkbook workbook = new XSSFWorkbook(stream);
            ISheet sheet = null;
            ICell cell = null;
            int startRow = 0;

            if(workbook != null)
            {
                if (string.IsNullOrEmpty(sheetName))
                {
                    sheet = workbook.GetSheetAt(0);
                }
                else
                {
                    sheet = workbook.GetSheet(sheetName);
                }
                if (sheet != null)
                {
                    int rowCount = sheet.LastRowNum;//总行数
                    if (rowCount > 0)
                    {
                        IRow firstRow = sheet.GetRow(0);//第一行，一般存储列名
                        int cellCount = firstRow.LastCellNum;//列数
                        if (isColumnName)
                        {
                            startRow = sheet.FirstRowNum + 1;//如果第一行是列名。则从第二行开始读
                            for (var i = firstRow.FirstCellNum; i < cellCount; ++i)
                            {
                                cell = firstRow.GetCell(i);
                                if (cell != null)
                                {
                                    cell.SetCellType(CellType.String);
                                    if (cell.StringCellValue != null)
                                    {
                                        column = new DataColumn(cell.StringCellValue.Trim());
                                        dataTable.Columns.Add(column);
                                    }
                                }
                            }
                        }
                        else
                        {
                            startRow = sheet.FirstRowNum;
                        }
                        for (int i = startRow; i <= rowCount; ++i)
                        {
                            IRow row = sheet.GetRow(i);
                            if (row == null) { continue; }//没有数据的行默认为null
                            DataRow dataRow = dataTable.NewRow();
                            for (int j = row.FirstCellNum; j < cellCount; ++j)
                            {
                                if (row.GetCell(j) != null)
                                {
                                    //处理时间格式数据
                                    if (row.GetCell(j).CellType == CellType.Numeric && DateUtil.IsCellDateFormatted(row.GetCell(j)))
                                    {
                                        dataRow[j] = row.GetCell(j).DateCellValue.ToString("yyyy-MM-dd");
                                    }
                                    else
                                    {
                                        dataRow[j] = row.GetCell(j).ToString();
                                    }
                                }
                            }
                            dataTable.Rows.Add(dataRow);
                        }
                    }
                }
            }

            return dataTable;
        }
    }
}
