namespace AppInformPrivateSecurity
{
    partial class SprManipulation
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.editMedicalPhone = new System.Windows.Forms.TextBox();
            this.editMedicalAddress = new System.Windows.Forms.TextBox();
            this.editMedicalName = new System.Windows.Forms.TextBox();
            this.btnMedicalCancel = new System.Windows.Forms.Button();
            this.btnMedicalSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nameDischarge = new System.Windows.Forms.TextBox();
            this.codeDischarge = new System.Windows.Forms.TextBox();
            this.btnCancelDischarge = new System.Windows.Forms.Button();
            this.btnSaveDischarge = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.addresEducation = new System.Windows.Forms.TextBox();
            this.licenseEducation = new System.Windows.Forms.TextBox();
            this.nameEducation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelEducationInst = new System.Windows.Forms.Button();
            this.btnSaveEducationInst = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(10, 10);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(469, 227);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.editMedicalPhone);
            this.tabPage1.Controls.Add(this.editMedicalAddress);
            this.tabPage1.Controls.Add(this.editMedicalName);
            this.tabPage1.Controls.Add(this.btnMedicalCancel);
            this.tabPage1.Controls.Add(this.btnMedicalSave);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 14);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(461, 209);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // editMedicalPhone
            // 
            this.editMedicalPhone.Location = new System.Drawing.Point(100, 96);
            this.editMedicalPhone.Name = "editMedicalPhone";
            this.editMedicalPhone.Size = new System.Drawing.Size(325, 20);
            this.editMedicalPhone.TabIndex = 7;
            // 
            // editMedicalAddress
            // 
            this.editMedicalAddress.Location = new System.Drawing.Point(100, 57);
            this.editMedicalAddress.Name = "editMedicalAddress";
            this.editMedicalAddress.Size = new System.Drawing.Size(325, 20);
            this.editMedicalAddress.TabIndex = 6;
            // 
            // editMedicalName
            // 
            this.editMedicalName.Location = new System.Drawing.Point(100, 17);
            this.editMedicalName.Name = "editMedicalName";
            this.editMedicalName.Size = new System.Drawing.Size(325, 20);
            this.editMedicalName.TabIndex = 5;
            // 
            // btnMedicalCancel
            // 
            this.btnMedicalCancel.Image = global::AppInformPrivateSecurity.Properties.Resources.cross__32x32_;
            this.btnMedicalCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicalCancel.Location = new System.Drawing.Point(239, 148);
            this.btnMedicalCancel.Name = "btnMedicalCancel";
            this.btnMedicalCancel.Size = new System.Drawing.Size(97, 53);
            this.btnMedicalCancel.TabIndex = 4;
            this.btnMedicalCancel.Text = "Отмена";
            this.btnMedicalCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMedicalCancel.UseVisualStyleBackColor = true;
            this.btnMedicalCancel.Click += new System.EventHandler(this.btnMedicalCancel_Click);
            // 
            // btnMedicalSave
            // 
            this.btnMedicalSave.Image = global::AppInformPrivateSecurity.Properties.Resources.Mark;
            this.btnMedicalSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicalSave.Location = new System.Drawing.Point(136, 148);
            this.btnMedicalSave.Name = "btnMedicalSave";
            this.btnMedicalSave.Size = new System.Drawing.Size(97, 53);
            this.btnMedicalSave.TabIndex = 3;
            this.btnMedicalSave.Text = "Сохранит";
            this.btnMedicalSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMedicalSave.UseVisualStyleBackColor = true;
            this.btnMedicalSave.Click += new System.EventHandler(this.btnMedicalSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Телефон:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адрес:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.nameDischarge);
            this.tabPage2.Controls.Add(this.codeDischarge);
            this.tabPage2.Controls.Add(this.btnCancelDischarge);
            this.tabPage2.Controls.Add(this.btnSaveDischarge);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 14);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(461, 209);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // nameDischarge
            // 
            this.nameDischarge.Location = new System.Drawing.Point(93, 77);
            this.nameDischarge.Name = "nameDischarge";
            this.nameDischarge.Size = new System.Drawing.Size(329, 20);
            this.nameDischarge.TabIndex = 8;
            // 
            // codeDischarge
            // 
            this.codeDischarge.Location = new System.Drawing.Point(93, 32);
            this.codeDischarge.Name = "codeDischarge";
            this.codeDischarge.Size = new System.Drawing.Size(329, 20);
            this.codeDischarge.TabIndex = 7;
            // 
            // btnCancelDischarge
            // 
            this.btnCancelDischarge.Image = global::AppInformPrivateSecurity.Properties.Resources.cross__32x32_;
            this.btnCancelDischarge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelDischarge.Location = new System.Drawing.Point(243, 148);
            this.btnCancelDischarge.Name = "btnCancelDischarge";
            this.btnCancelDischarge.Size = new System.Drawing.Size(97, 53);
            this.btnCancelDischarge.TabIndex = 6;
            this.btnCancelDischarge.Text = "Отмена";
            this.btnCancelDischarge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelDischarge.UseVisualStyleBackColor = true;
            this.btnCancelDischarge.Click += new System.EventHandler(this.btnCancelDischarge_Click);
            // 
            // btnSaveDischarge
            // 
            this.btnSaveDischarge.Image = global::AppInformPrivateSecurity.Properties.Resources.Mark;
            this.btnSaveDischarge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveDischarge.Location = new System.Drawing.Point(140, 148);
            this.btnSaveDischarge.Name = "btnSaveDischarge";
            this.btnSaveDischarge.Size = new System.Drawing.Size(97, 53);
            this.btnSaveDischarge.TabIndex = 5;
            this.btnSaveDischarge.Text = "Сохранит";
            this.btnSaveDischarge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveDischarge.UseVisualStyleBackColor = true;
            this.btnSaveDischarge.Click += new System.EventHandler(this.btnSaveDischarge_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Описание:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Код:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.addresEducation);
            this.tabPage3.Controls.Add(this.licenseEducation);
            this.tabPage3.Controls.Add(this.nameEducation);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.btnCancelEducationInst);
            this.tabPage3.Controls.Add(this.btnSaveEducationInst);
            this.tabPage3.Location = new System.Drawing.Point(4, 14);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(461, 209);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // addresEducation
            // 
            this.addresEducation.Location = new System.Drawing.Point(101, 97);
            this.addresEducation.Name = "addresEducation";
            this.addresEducation.Size = new System.Drawing.Size(327, 20);
            this.addresEducation.TabIndex = 14;
            // 
            // licenseEducation
            // 
            this.licenseEducation.Location = new System.Drawing.Point(101, 56);
            this.licenseEducation.Name = "licenseEducation";
            this.licenseEducation.Size = new System.Drawing.Size(327, 20);
            this.licenseEducation.TabIndex = 13;
            // 
            // nameEducation
            // 
            this.nameEducation.Location = new System.Drawing.Point(101, 12);
            this.nameEducation.Name = "nameEducation";
            this.nameEducation.Size = new System.Drawing.Size(327, 20);
            this.nameEducation.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Адрес:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Лицензия:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Наименование:";
            // 
            // btnCancelEducationInst
            // 
            this.btnCancelEducationInst.Image = global::AppInformPrivateSecurity.Properties.Resources.cross__32x32_;
            this.btnCancelEducationInst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelEducationInst.Location = new System.Drawing.Point(241, 148);
            this.btnCancelEducationInst.Name = "btnCancelEducationInst";
            this.btnCancelEducationInst.Size = new System.Drawing.Size(97, 53);
            this.btnCancelEducationInst.TabIndex = 8;
            this.btnCancelEducationInst.Text = "Отмена";
            this.btnCancelEducationInst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelEducationInst.UseVisualStyleBackColor = true;
            this.btnCancelEducationInst.Click += new System.EventHandler(this.btnCancelEducationInst_Click);
            // 
            // btnSaveEducationInst
            // 
            this.btnSaveEducationInst.Image = global::AppInformPrivateSecurity.Properties.Resources.Mark;
            this.btnSaveEducationInst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveEducationInst.Location = new System.Drawing.Point(138, 148);
            this.btnSaveEducationInst.Name = "btnSaveEducationInst";
            this.btnSaveEducationInst.Size = new System.Drawing.Size(97, 53);
            this.btnSaveEducationInst.TabIndex = 7;
            this.btnSaveEducationInst.Text = "Сохранит";
            this.btnSaveEducationInst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveEducationInst.UseVisualStyleBackColor = true;
            this.btnSaveEducationInst.Click += new System.EventHandler(this.btnSaveEducationInst_Click);
            // 
            // SprManipulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 227);
            this.Controls.Add(this.tabControl1);
            this.Name = "SprManipulation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SprManipulation";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox editMedicalPhone;
        private System.Windows.Forms.TextBox editMedicalAddress;
        private System.Windows.Forms.TextBox editMedicalName;
        private System.Windows.Forms.Button btnMedicalCancel;
        private System.Windows.Forms.Button btnMedicalSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameDischarge;
        private System.Windows.Forms.TextBox codeDischarge;
        private System.Windows.Forms.Button btnCancelDischarge;
        private System.Windows.Forms.Button btnSaveDischarge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelEducationInst;
        private System.Windows.Forms.Button btnSaveEducationInst;
        private System.Windows.Forms.TextBox addresEducation;
        private System.Windows.Forms.TextBox licenseEducation;
        private System.Windows.Forms.TextBox nameEducation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}