using Market_Excel_Helper_Core.Models;
using Microsoft.Office.Tools.Ribbon;

namespace Market_Excel_Helper.UI
{
    public partial class UIRibbon
    {
        private void UIRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void DivideForInspection_Click(object sender, RibbonControlEventArgs e)
        {
            ExcelHandler excelHandler = new ExcelHandler(Globals.ThisAddIn.Application);

            excelHandler.GetExcelSheetData();
        }

        private void DivideRequestBetweenManagers_Click(object sender, RibbonControlEventArgs e)
        {
            SplitBetweenManagers_Form form = new SplitBetweenManagers_Form();

            form.ShowDialog();
        }

        private void button3_Click(object sender, RibbonControlEventArgs e)
        {
            ProductGroupingSettingsForm productGroupingSettingsForm = new ProductGroupingSettingsForm();
            productGroupingSettingsForm.ShowDialog();
        }
    }
}
