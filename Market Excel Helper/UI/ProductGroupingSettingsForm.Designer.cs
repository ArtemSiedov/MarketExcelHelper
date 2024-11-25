namespace Market_Excel_Helper.UI
{
    partial class ProductGroupingSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoryList = new System.Windows.Forms.CheckedListBox();
            this.ChekedAll = new System.Windows.Forms.Button();
            this.UnchekedAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CategoryInNewList = new System.Windows.Forms.RadioButton();
            this.CategoryInNewBook = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ParamsList = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Категорий в файле:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Разделить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(414, 354);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Отмена";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "4";
            // 
            // CategoryList
            // 
            this.CategoryList.CheckOnClick = true;
            this.CategoryList.FormattingEnabled = true;
            this.CategoryList.Items.AddRange(new object[] {
            "Джинсовые куртки для девочек",
            "Женские пончо",
            "Мужские кроссовки",
            "Мужские рубашки"});
            this.CategoryList.Location = new System.Drawing.Point(12, 29);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.Size = new System.Drawing.Size(261, 319);
            this.CategoryList.Sorted = true;
            this.CategoryList.TabIndex = 4;
            this.CategoryList.ThreeDCheckBoxes = true;
            this.CategoryList.SelectedIndexChanged += new System.EventHandler(this.CategoryList_SelectedIndexChanged);
            // 
            // ChekedAll
            // 
            this.ChekedAll.Location = new System.Drawing.Point(93, 354);
            this.ChekedAll.Name = "ChekedAll";
            this.ChekedAll.Size = new System.Drawing.Size(86, 23);
            this.ChekedAll.TabIndex = 5;
            this.ChekedAll.Text = "Выбрать все";
            this.ChekedAll.UseVisualStyleBackColor = true;
            this.ChekedAll.Click += new System.EventHandler(this.ChekedAll_Click);
            // 
            // UnchekedAll
            // 
            this.UnchekedAll.Location = new System.Drawing.Point(185, 354);
            this.UnchekedAll.Name = "UnchekedAll";
            this.UnchekedAll.Size = new System.Drawing.Size(88, 23);
            this.UnchekedAll.TabIndex = 6;
            this.UnchekedAll.Text = "Отменить все";
            this.UnchekedAll.UseVisualStyleBackColor = true;
            this.UnchekedAll.Click += new System.EventHandler(this.UnchekedAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CategoryInNewList);
            this.groupBox1.Controls.Add(this.CategoryInNewBook);
            this.groupBox1.Location = new System.Drawing.Point(289, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 73);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Как разделить ? ";
            // 
            // CategoryInNewList
            // 
            this.CategoryInNewList.AutoSize = true;
            this.CategoryInNewList.Checked = true;
            this.CategoryInNewList.Location = new System.Drawing.Point(19, 19);
            this.CategoryInNewList.Name = "CategoryInNewList";
            this.CategoryInNewList.Size = new System.Drawing.Size(160, 17);
            this.CategoryInNewList.TabIndex = 1;
            this.CategoryInNewList.TabStop = true;
            this.CategoryInNewList.Text = "Категория на новом листе";
            this.CategoryInNewList.UseVisualStyleBackColor = true;
            // 
            // CategoryInNewBook
            // 
            this.CategoryInNewBook.AutoSize = true;
            this.CategoryInNewBook.Location = new System.Drawing.Point(19, 42);
            this.CategoryInNewBook.Name = "CategoryInNewBook";
            this.CategoryInNewBook.Size = new System.Drawing.Size(152, 17);
            this.CategoryInNewBook.TabIndex = 0;
            this.CategoryInNewBook.Text = "Категория в новой книге";
            this.CategoryInNewBook.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ParamsList);
            this.groupBox2.Location = new System.Drawing.Point(289, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 76);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "По какому параметру группировать ?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Выбрать из списка";
            // 
            // ParamsList
            // 
            this.ParamsList.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.ParamsList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ParamsList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ParamsList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ParamsList.FormattingEnabled = true;
            this.ParamsList.Items.AddRange(new object[] {
            "Размер",
            "Рост",
            "Цвет",
            "Длина",
            "Возраст"});
            this.ParamsList.Location = new System.Drawing.Point(6, 44);
            this.ParamsList.Name = "ParamsList";
            this.ParamsList.Size = new System.Drawing.Size(255, 21);
            this.ParamsList.TabIndex = 0;
            this.ParamsList.SelectedIndexChanged += new System.EventHandler(this.ParamsList_SelectedIndexChanged);
            // 
            // ProductGroupingSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 385);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UnchekedAll);
            this.Controls.Add(this.ChekedAll);
            this.Controls.Add(this.CategoryList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ProductGroupingSettingsForm";
            this.Text = "Настройка группировки";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox CategoryList;
        private System.Windows.Forms.Button ChekedAll;
        private System.Windows.Forms.Button UnchekedAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton CategoryInNewList;
        private System.Windows.Forms.RadioButton CategoryInNewBook;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ParamsList;
        private System.Windows.Forms.Label label3;
    }
}