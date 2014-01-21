namespace Teleavtomatika_Form_Validation
{
    partial class frmMain2
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
            this.gbSearchParameters = new System.Windows.Forms.GroupBox();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtBegin = new System.Windows.Forms.DateTimePicker();
            this.lblDateDash = new System.Windows.Forms.Label();
            this.chkFilterByDate = new System.Windows.Forms.CheckBox();
            this.pnlCategories = new System.Windows.Forms.Panel();
            this.chkFilterByCategory = new System.Windows.Forms.CheckBox();
            this.chkCategory1 = new System.Windows.Forms.CheckBox();
            this.chkCategory2 = new System.Windows.Forms.CheckBox();
            this.chkCategory3 = new System.Windows.Forms.CheckBox();
            this.chkCategory4 = new System.Windows.Forms.CheckBox();
            this.chkCategory5 = new System.Windows.Forms.CheckBox();
            this.chkCategory6 = new System.Windows.Forms.CheckBox();
            this.chkCategory7 = new System.Windows.Forms.CheckBox();
            this.chkCategory8 = new System.Windows.Forms.CheckBox();
            this.chkFilterByText = new System.Windows.Forms.CheckBox();
            this.pnlTextFilter = new System.Windows.Forms.Panel();
            this.chkSearchTextInHeader = new System.Windows.Forms.CheckBox();
            this.chkSearchTextInBody = new System.Windows.Forms.CheckBox();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.butSearch = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.gbSearchParameters.SuspendLayout();
            this.pnlCategories.SuspendLayout();
            this.pnlTextFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSearchParameters
            // 
            this.gbSearchParameters.Controls.Add(this.pnlTextFilter);
            this.gbSearchParameters.Controls.Add(this.chkFilterByText);
            this.gbSearchParameters.Controls.Add(this.chkFilterByCategory);
            this.gbSearchParameters.Controls.Add(this.pnlCategories);
            this.gbSearchParameters.Controls.Add(this.chkFilterByDate);
            this.gbSearchParameters.Controls.Add(this.lblDateDash);
            this.gbSearchParameters.Controls.Add(this.dtEnd);
            this.gbSearchParameters.Controls.Add(this.dtBegin);
            this.gbSearchParameters.Location = new System.Drawing.Point(12, 12);
            this.gbSearchParameters.Name = "gbSearchParameters";
            this.gbSearchParameters.Size = new System.Drawing.Size(517, 283);
            this.gbSearchParameters.TabIndex = 0;
            this.gbSearchParameters.TabStop = false;
            this.gbSearchParameters.Text = "Параметры отбора";
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(357, 28);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(138, 20);
            this.dtEnd.TabIndex = 3;
            // 
            // dtBegin
            // 
            this.dtBegin.Location = new System.Drawing.Point(196, 28);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.Size = new System.Drawing.Size(138, 20);
            this.dtBegin.TabIndex = 1;
            this.dtBegin.Value = new System.DateTime(2015, 1, 21, 0, 0, 0, 0);
            // 
            // lblDateDash
            // 
            this.lblDateDash.AutoSize = true;
            this.lblDateDash.Location = new System.Drawing.Point(341, 31);
            this.lblDateDash.Name = "lblDateDash";
            this.lblDateDash.Size = new System.Drawing.Size(10, 13);
            this.lblDateDash.TabIndex = 2;
            this.lblDateDash.Text = "-";
            // 
            // chkFilterByDate
            // 
            this.chkFilterByDate.AutoSize = true;
            this.chkFilterByDate.Location = new System.Drawing.Point(18, 29);
            this.chkFilterByDate.Name = "chkFilterByDate";
            this.chkFilterByDate.Size = new System.Drawing.Size(139, 17);
            this.chkFilterByDate.TabIndex = 0;
            this.chkFilterByDate.Text = "Фильтровать по дате:";
            this.chkFilterByDate.UseVisualStyleBackColor = true;
            // 
            // pnlCategories
            // 
            this.pnlCategories.Controls.Add(this.chkCategory8);
            this.pnlCategories.Controls.Add(this.chkCategory7);
            this.pnlCategories.Controls.Add(this.chkCategory6);
            this.pnlCategories.Controls.Add(this.chkCategory5);
            this.pnlCategories.Controls.Add(this.chkCategory4);
            this.pnlCategories.Controls.Add(this.chkCategory3);
            this.pnlCategories.Controls.Add(this.chkCategory2);
            this.pnlCategories.Controls.Add(this.chkCategory1);
            this.pnlCategories.Location = new System.Drawing.Point(18, 87);
            this.pnlCategories.Name = "pnlCategories";
            this.pnlCategories.Size = new System.Drawing.Size(477, 109);
            this.pnlCategories.TabIndex = 5;
            // 
            // chkFilterByCategory
            // 
            this.chkFilterByCategory.AutoSize = true;
            this.chkFilterByCategory.Location = new System.Drawing.Point(18, 64);
            this.chkFilterByCategory.Name = "chkFilterByCategory";
            this.chkFilterByCategory.Size = new System.Drawing.Size(168, 17);
            this.chkFilterByCategory.TabIndex = 4;
            this.chkFilterByCategory.Text = "Фильтровать по категории:";
            this.chkFilterByCategory.UseVisualStyleBackColor = true;
            // 
            // chkCategory1
            // 
            this.chkCategory1.AutoSize = true;
            this.chkCategory1.Location = new System.Drawing.Point(13, 12);
            this.chkCategory1.Name = "chkCategory1";
            this.chkCategory1.Size = new System.Drawing.Size(43, 17);
            this.chkCategory1.TabIndex = 0;
            this.chkCategory1.Text = "API";
            this.chkCategory1.UseVisualStyleBackColor = true;
            // 
            // chkCategory2
            // 
            this.chkCategory2.AutoSize = true;
            this.chkCategory2.Location = new System.Drawing.Point(13, 35);
            this.chkCategory2.Name = "chkCategory2";
            this.chkCategory2.Size = new System.Drawing.Size(130, 17);
            this.chkCategory2.TabIndex = 1;
            this.chkCategory2.Text = "Администрирование";
            this.chkCategory2.UseVisualStyleBackColor = true;
            // 
            // chkCategory3
            // 
            this.chkCategory3.AutoSize = true;
            this.chkCategory3.Location = new System.Drawing.Point(13, 58);
            this.chkCategory3.Name = "chkCategory3";
            this.chkCategory3.Size = new System.Drawing.Size(93, 17);
            this.chkCategory3.TabIndex = 2;
            this.chkCategory3.Text = "Базы данных";
            this.chkCategory3.UseVisualStyleBackColor = true;
            // 
            // chkCategory4
            // 
            this.chkCategory4.AutoSize = true;
            this.chkCategory4.Location = new System.Drawing.Point(13, 80);
            this.chkCategory4.Name = "chkCategory4";
            this.chkCategory4.Size = new System.Drawing.Size(98, 17);
            this.chkCategory4.TabIndex = 3;
            this.chkCategory4.Text = "Безопасность";
            this.chkCategory4.UseVisualStyleBackColor = true;
            // 
            // chkCategory5
            // 
            this.chkCategory5.AutoSize = true;
            this.chkCategory5.Location = new System.Drawing.Point(156, 12);
            this.chkCategory5.Name = "chkCategory5";
            this.chkCategory5.Size = new System.Drawing.Size(143, 17);
            this.chkCategory5.TabIndex = 4;
            this.chkCategory5.Text = "Дизайн, графика, звук";
            this.chkCategory5.UseVisualStyleBackColor = true;
            // 
            // chkCategory6
            // 
            this.chkCategory6.AutoSize = true;
            this.chkCategory6.Location = new System.Drawing.Point(156, 35);
            this.chkCategory6.Name = "chkCategory6";
            this.chkCategory6.Size = new System.Drawing.Size(123, 17);
            this.chkCategory6.TabIndex = 5;
            this.chkCategory6.Text = "Железо и гаджеты";
            this.chkCategory6.UseVisualStyleBackColor = true;
            // 
            // chkCategory7
            // 
            this.chkCategory7.AutoSize = true;
            this.chkCategory7.Location = new System.Drawing.Point(156, 58);
            this.chkCategory7.Name = "chkCategory7";
            this.chkCategory7.Size = new System.Drawing.Size(133, 17);
            this.chkCategory7.TabIndex = 6;
            this.chkCategory7.Text = "Компании и сервисы";
            this.chkCategory7.UseVisualStyleBackColor = true;
            // 
            // chkCategory8
            // 
            this.chkCategory8.AutoSize = true;
            this.chkCategory8.Location = new System.Drawing.Point(156, 80);
            this.chkCategory8.Name = "chkCategory8";
            this.chkCategory8.Size = new System.Drawing.Size(92, 17);
            this.chkCategory8.TabIndex = 7;
            this.chkCategory8.Text = "Менеджмент";
            this.chkCategory8.UseVisualStyleBackColor = true;
            // 
            // chkFilterByText
            // 
            this.chkFilterByText.AutoSize = true;
            this.chkFilterByText.Location = new System.Drawing.Point(18, 216);
            this.chkFilterByText.Name = "chkFilterByText";
            this.chkFilterByText.Size = new System.Drawing.Size(158, 17);
            this.chkFilterByText.TabIndex = 6;
            this.chkFilterByText.Text = "Искать следующий текст:";
            this.chkFilterByText.UseVisualStyleBackColor = true;
            // 
            // pnlTextFilter
            // 
            this.pnlTextFilter.Controls.Add(this.txtSearchText);
            this.pnlTextFilter.Controls.Add(this.chkSearchTextInHeader);
            this.pnlTextFilter.Controls.Add(this.chkSearchTextInBody);
            this.pnlTextFilter.Location = new System.Drawing.Point(194, 213);
            this.pnlTextFilter.Name = "pnlTextFilter";
            this.pnlTextFilter.Size = new System.Drawing.Size(306, 47);
            this.pnlTextFilter.TabIndex = 7;
            // 
            // chkSearchTextInHeader
            // 
            this.chkSearchTextInHeader.AutoSize = true;
            this.chkSearchTextInHeader.Location = new System.Drawing.Point(3, 29);
            this.chkSearchTextInHeader.Name = "chkSearchTextInHeader";
            this.chkSearchTextInHeader.Size = new System.Drawing.Size(95, 17);
            this.chkSearchTextInHeader.TabIndex = 1;
            this.chkSearchTextInHeader.Text = "В Заголовках";
            this.chkSearchTextInHeader.UseVisualStyleBackColor = true;
            // 
            // chkSearchTextInBody
            // 
            this.chkSearchTextInBody.AutoSize = true;
            this.chkSearchTextInBody.Location = new System.Drawing.Point(104, 29);
            this.chkSearchTextInBody.Name = "chkSearchTextInBody";
            this.chkSearchTextInBody.Size = new System.Drawing.Size(107, 17);
            this.chkSearchTextInBody.TabIndex = 2;
            this.chkSearchTextInBody.Text = "В тексте статей";
            this.chkSearchTextInBody.UseVisualStyleBackColor = true;
            // 
            // txtSearchText
            // 
            this.txtSearchText.Location = new System.Drawing.Point(3, 3);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(299, 20);
            this.txtSearchText.TabIndex = 0;
            // 
            // butSearch
            // 
            this.butSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butSearch.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butSearch.Location = new System.Drawing.Point(381, 305);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(75, 23);
            this.butSearch.TabIndex = 1;
            this.butSearch.Text = "Искать";
            this.butSearch.UseVisualStyleBackColor = true;
            // 
            // butCancel
            // 
            this.butCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Location = new System.Drawing.Point(462, 305);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 2;
            this.butCancel.Text = "Отмена";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // frmMain2
            // 
            this.AcceptButton = this.butSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCancel;
            this.ClientSize = new System.Drawing.Size(549, 340);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.gbSearchParameters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск статьи на Хабре";
            this.gbSearchParameters.ResumeLayout(false);
            this.gbSearchParameters.PerformLayout();
            this.pnlCategories.ResumeLayout(false);
            this.pnlCategories.PerformLayout();
            this.pnlTextFilter.ResumeLayout(false);
            this.pnlTextFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchParameters;
        private System.Windows.Forms.Panel pnlTextFilter;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.CheckBox chkSearchTextInHeader;
        private System.Windows.Forms.CheckBox chkSearchTextInBody;
        private System.Windows.Forms.CheckBox chkFilterByText;
        private System.Windows.Forms.CheckBox chkFilterByCategory;
        private System.Windows.Forms.Panel pnlCategories;
        private System.Windows.Forms.CheckBox chkCategory8;
        private System.Windows.Forms.CheckBox chkCategory7;
        private System.Windows.Forms.CheckBox chkCategory6;
        private System.Windows.Forms.CheckBox chkCategory5;
        private System.Windows.Forms.CheckBox chkCategory4;
        private System.Windows.Forms.CheckBox chkCategory3;
        private System.Windows.Forms.CheckBox chkCategory2;
        private System.Windows.Forms.CheckBox chkCategory1;
        private System.Windows.Forms.CheckBox chkFilterByDate;
        private System.Windows.Forms.Label lblDateDash;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtBegin;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button butCancel;
    }
}