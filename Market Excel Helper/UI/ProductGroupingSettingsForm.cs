using System;
using System.Windows.Forms;

namespace Market_Excel_Helper.UI
{
    public partial class ProductGroupingSettingsForm : Form
    {
        public ProductGroupingSettingsForm()
        {
            InitializeComponent();

            for (int i = 0; i < CategoryList.Items.Count; i++)
            {
                CategoryList.SetItemChecked(i, true);
            }

            ParamsList.SelectedIndex = 0;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UnchekedAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CategoryList.Items.Count; i++)
            {
                CategoryList.SetItemChecked(i, false);
            }
        }

        private void ChekedAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CategoryList.Items.Count; i++)
            {
                CategoryList.SetItemChecked(i, true);
            }
        }

        private void ParamsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
