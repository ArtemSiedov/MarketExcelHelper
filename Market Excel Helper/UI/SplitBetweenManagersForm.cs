using System;
using System.Windows.Forms;

namespace Market_Excel_Helper.UI
{
    public partial class SplitBetweenManagers_Form : Form
    {
        public SplitBetweenManagers_Form()
        {
            InitializeComponent();
        }

        private void AddManager_Click(object sender, EventArgs e)
        {
            AddManagersForm addManagersForm = new AddManagersForm();
            addManagersForm.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
