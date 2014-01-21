namespace Teleavtomatika_Form_Validation
{
    partial class frmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbGeneralInfo = new System.Windows.Forms.GroupBox();
            this.nmAge = new System.Windows.Forms.NumericUpDown();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblEMail = new System.Windows.Forms.Label();
            this.lblMidleName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.gbGeneralInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAge)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGeneralInfo
            // 
            this.gbGeneralInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGeneralInfo.Controls.Add(this.nmAge);
            this.gbGeneralInfo.Controls.Add(this.lblAge);
            this.gbGeneralInfo.Controls.Add(this.lblEMail);
            this.gbGeneralInfo.Controls.Add(this.lblMidleName);
            this.gbGeneralInfo.Controls.Add(this.lblName);
            this.gbGeneralInfo.Controls.Add(this.lblSurname);
            this.gbGeneralInfo.Controls.Add(this.txtEMail);
            this.gbGeneralInfo.Controls.Add(this.txtMiddleName);
            this.gbGeneralInfo.Controls.Add(this.txtName);
            this.gbGeneralInfo.Controls.Add(this.txtSurname);
            this.gbGeneralInfo.Location = new System.Drawing.Point(12, 12);
            this.gbGeneralInfo.Name = "gbGeneralInfo";
            this.gbGeneralInfo.Size = new System.Drawing.Size(391, 167);
            this.gbGeneralInfo.TabIndex = 0;
            this.gbGeneralInfo.TabStop = false;
            this.gbGeneralInfo.Text = "Основные данные";
            // 
            // nmAge
            // 
            this.nmAge.Location = new System.Drawing.Point(109, 110);
            this.nmAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmAge.Name = "nmAge";
            this.nmAge.Size = new System.Drawing.Size(166, 20);
            this.nmAge.TabIndex = 7;
            this.nmAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(6, 112);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(52, 13);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Возраст:";
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.Location = new System.Drawing.Point(6, 139);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(39, 13);
            this.lblEMail.TabIndex = 8;
            this.lblEMail.Text = "E-Mail:";
            // 
            // lblMidleName
            // 
            this.lblMidleName.AutoSize = true;
            this.lblMidleName.Location = new System.Drawing.Point(6, 86);
            this.lblMidleName.Name = "lblMidleName";
            this.lblMidleName.Size = new System.Drawing.Size(57, 13);
            this.lblMidleName.TabIndex = 4;
            this.lblMidleName.Text = "Отчество:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Имя:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(6, 34);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(59, 13);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Фамилия:";
            // 
            // txtEMail
            // 
            this.txtEMail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEMail.Location = new System.Drawing.Point(109, 136);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(255, 20);
            this.txtEMail.TabIndex = 9;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMiddleName.Location = new System.Drawing.Point(109, 83);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(255, 20);
            this.txtMiddleName.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(109, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(255, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtSurname
            // 
            this.txtSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSurname.Location = new System.Drawing.Point(109, 31);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(255, 20);
            this.txtSurname.TabIndex = 1;
            // 
            // butCancel
            // 
            this.butCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Location = new System.Drawing.Point(328, 188);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 2;
            this.butCancel.Text = "Отмена";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // butSave
            // 
            this.butSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butSave.Location = new System.Drawing.Point(247, 188);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 23);
            this.butSave.TabIndex = 1;
            this.butSave.Text = "Сохранить";
            this.butSave.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AcceptButton = this.butSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCancel;
            this.ClientSize = new System.Drawing.Size(415, 223);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.gbGeneralInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о пользователе";
            this.gbGeneralInfo.ResumeLayout(false);
            this.gbGeneralInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGeneralInfo;
        private System.Windows.Forms.NumericUpDown nmAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblMidleName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.TextBox txtEMail;
    }
}

