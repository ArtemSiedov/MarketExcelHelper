using Market_Excel_Helper_Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;

namespace Market_Excel_Helper_Core.Models
{
    public class ExcelHandler
    {
        private static Excel.Application _application;
        private List<SheetData> _sheetDatas = new List<SheetData>();
        private Excel.Worksheet sheet = (Excel.Worksheet)_application.ActiveSheet;

        public ExcelHandler(Excel.Application application)
        {
            _application = application;
        }

        public void GetExcelSheetData()
        {
            for (int j = 1; j <= 28; j++)
            {
                var sheetData = new SheetData
                {
                    RozetkaID = sheet.Cells[j, 1].Value?.ToString(),
                    IDToСheck = sheet.Cells[j, 1].Value?.ToString() + ",",
                    GoodsName = sheet.Cells[j, 4].Value?.ToString(),
                    SellerCategory = sheet.Cells[j, 7].Value?.ToString(),
                    RozetkaCategory = sheet.Cells[j, 9].Value?.ToString(),
                    GoodsLink = sheet.Cells[j, 21].Value?.ToString()
                };
                _sheetDatas.Add(sheetData);
            }
        }

        public void CreateNewSpreadSheet()
        {

        }

        public void FillSpreadSheet()
        {
            var header = _sheetDatas[0];
            var sheetDatas = _sheetDatas.Skip(1).OrderBy(s => s.RozetkaCategory).ToList();
            sheetDatas.Insert(0, header);

            int row = 33;
            foreach (var data in sheetDatas)
            {
                sheet.Cells[row, 1].Value = data.RozetkaID;
                sheet.Cells[row, 2].Value = data.IDToСheck;
                sheet.Cells[row, 3].Value = data.GoodsName;
                sheet.Cells[row, 4].Value = data.SellerCategory;
                sheet.Cells[row, 5].Value = data.RozetkaCategory;
                sheet.Cells[row, 6].Value = data.GoodsLink;

                row++;
            }
        }
    }
}
