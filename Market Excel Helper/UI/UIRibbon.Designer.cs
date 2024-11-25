using System;

namespace Market_Excel_Helper.UI
{
    partial class UIRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public UIRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.DivideForInspection = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.DivideRequestBetweenManagers = this.Factory.CreateRibbonButton();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.button3 = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.group3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Groups.Add(this.group3);
            this.tab1.Label = "Market Excel Helper";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.DivideForInspection);
            this.group1.Label = "СВ";
            this.group1.Name = "group1";
            // 
            // DivideForInspection
            // 
            this.DivideForInspection.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.DivideForInspection.Image = global::Market_Excel_Helper.Properties.Resources.dManagers_;
            this.DivideForInspection.Label = "Разделить заявку для проверки";
            this.DivideForInspection.Name = "DivideForInspection";
            this.DivideForInspection.ShowImage = true;
            this.DivideForInspection.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.DivideForInspection_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.DivideRequestBetweenManagers);
            this.group2.Label = "КМ";
            this.group2.Name = "group2";
            // 
            // DivideRequestBetweenManagers
            // 
            this.DivideRequestBetweenManagers.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.DivideRequestBetweenManagers.Image = global::Market_Excel_Helper.Properties.Resources.Checking;
            this.DivideRequestBetweenManagers.Label = "Разделить заявку между КМ";
            this.DivideRequestBetweenManagers.Name = "DivideRequestBetweenManagers";
            this.DivideRequestBetweenManagers.ShowImage = true;
            this.DivideRequestBetweenManagers.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.DivideRequestBetweenManagers_Click);
            // 
            // group3
            // 
            this.group3.Items.Add(this.button3);
            this.group3.Label = "Группировка";
            this.group3.Name = "group3";
            // 
            // button3
            // 
            this.button3.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button3.Image = global::Market_Excel_Helper.Properties.Resources.grouping;
            this.button3.Label = "Подготовить файл для группировки";
            this.button3.Name = "button3";
            this.button3.ShowImage = true;
            this.button3.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button3_Click);
            // 
            // UIRibbon
            // 
            this.Name = "UIRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.UIRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton DivideRequestBetweenManagers;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton DivideForInspection;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button3;
    }

    partial class ThisRibbonCollection
    {
        internal UIRibbon UIRibbon
        {
            get { return this.GetRibbon<UIRibbon>(); }
        }

        private T GetRibbon<T>()
        {
            throw new NotImplementedException();
        }
    }
}
