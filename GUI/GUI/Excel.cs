using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;

public class Excel
{
    public static void ExportToExcel<T>(List<T> data, string filePath, string sheetName, Dictionary<string, Func<T, object>> columnMapping)
    {
        try
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add(sheetName);

                // Thêm tiêu đề cột và căn giữa văn bản
                int colIndex = 1;
                foreach (var column in columnMapping)
                {
                    worksheet.Cells[1, colIndex].Value = column.Key;
                    worksheet.Cells[1, colIndex].Style.Font.Bold = true;
                    worksheet.Cells[1, colIndex].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    worksheet.Cells[1, colIndex].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
                    worksheet.Cells[1, colIndex].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    worksheet.Cells[1, colIndex].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Cells[1, colIndex].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    colIndex++;
                }

                int rowIndex = 2;
                foreach (var item in data)
                {
                    colIndex = 1;
                    foreach (var column in columnMapping)
                    {
                        var value = column.Value(item);
                        worksheet.Cells[rowIndex, colIndex].Value = value;

                        // Căn giữa văn bản cho dữ liệu
                        worksheet.Cells[rowIndex, colIndex].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        worksheet.Cells[rowIndex, colIndex].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                        // Nếu cột là "Avatar", chỉ xuất tên ảnh từ CSDL
                        if (column.Key == "Avatar" && value != null)
                        {
                            var avatarFileName = value.ToString(); //Tên ảnh
                            worksheet.Cells[rowIndex, colIndex].Value = avatarFileName;
                        }

                        colIndex++;
                    }
                    rowIndex++;
                }

                using (var range = worksheet.Cells[1, 1, rowIndex - 1, columnMapping.Count])
                {
                    range.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    range.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                    range.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    range.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                }

                worksheet.Cells.AutoFitColumns();

                var fileInfo = new FileInfo(filePath);
                package.SaveAs(fileInfo);
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Lỗi khi xuất file Excel: {ex.Message}", ex);
        }
    }
}
