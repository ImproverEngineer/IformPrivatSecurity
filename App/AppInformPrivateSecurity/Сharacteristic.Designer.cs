namespace AppInformPrivateSecurity
{
    partial class Сharacteristic
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Сharacteristic));
            this.tabEmployee = new System.Windows.Forms.TabControl();
            this.EmployeePage = new System.Windows.Forms.TabPage();
            this.addPhoto = new System.Windows.Forms.Button();
            this.imgPhoto = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.dataBirthday = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMiddleName = new System.Windows.Forms.Label();
            this.middleBox = new System.Windows.Forms.TextBox();
            this.lbSurname = new System.Windows.Forms.Label();
            this.surmaneBox = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.IdentityPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataIdentityCard = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CreateIdentityCard = new System.Windows.Forms.Button();
            this.ChengeIdenty = new System.Windows.Forms.Button();
            this.MedicalPage = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridMedical = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.AddMedicalComission = new System.Windows.Forms.Button();
            this.openImgDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabEmployee.SuspendLayout();
            this.EmployeePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).BeginInit();
            this.IdentityPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataIdentityCard)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.MedicalPage.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedical)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEmployee
            // 
            this.tabEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabEmployee.Controls.Add(this.EmployeePage);
            this.tabEmployee.Controls.Add(this.IdentityPage);
            this.tabEmployee.Controls.Add(this.MedicalPage);
            this.tabEmployee.Location = new System.Drawing.Point(0, 0);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.SelectedIndex = 0;
            this.tabEmployee.Size = new System.Drawing.Size(800, 380);
            this.tabEmployee.TabIndex = 0;
            // 
            // EmployeePage
            // 
            this.EmployeePage.Controls.Add(this.addPhoto);
            this.EmployeePage.Controls.Add(this.imgPhoto);
            this.EmployeePage.Controls.Add(this.label2);
            this.EmployeePage.Controls.Add(this.phoneBox);
            this.EmployeePage.Controls.Add(this.dataBirthday);
            this.EmployeePage.Controls.Add(this.label1);
            this.EmployeePage.Controls.Add(this.lbMiddleName);
            this.EmployeePage.Controls.Add(this.middleBox);
            this.EmployeePage.Controls.Add(this.lbSurname);
            this.EmployeePage.Controls.Add(this.surmaneBox);
            this.EmployeePage.Controls.Add(this.lbName);
            this.EmployeePage.Controls.Add(this.nameBox);
            this.EmployeePage.Location = new System.Drawing.Point(4, 22);
            this.EmployeePage.Name = "EmployeePage";
            this.EmployeePage.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeePage.Size = new System.Drawing.Size(792, 354);
            this.EmployeePage.TabIndex = 0;
            this.EmployeePage.Text = "Характеристика";
            this.EmployeePage.UseVisualStyleBackColor = true;
            // 
            // addPhoto
            // 
            this.addPhoto.Location = new System.Drawing.Point(71, 280);
            this.addPhoto.Name = "addPhoto";
            this.addPhoto.Size = new System.Drawing.Size(106, 23);
            this.addPhoto.TabIndex = 12;
            this.addPhoto.Text = "Добавить";
            this.addPhoto.UseVisualStyleBackColor = true;
            this.addPhoto.Click += new System.EventHandler(this.addPhoto_Click);
            // 
            // imgPhoto
            // 
            this.imgPhoto.Location = new System.Drawing.Point(27, 46);
            this.imgPhoto.Name = "imgPhoto";
            this.imgPhoto.Size = new System.Drawing.Size(194, 228);
            this.imgPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPhoto.TabIndex = 10;
            this.imgPhoto.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(269, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Телефон:";
            // 
            // phoneBox
            // 
            this.phoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneBox.Location = new System.Drawing.Point(360, 224);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(388, 26);
            this.phoneBox.TabIndex = 8;
            // 
            // dataBirthday
            // 
            this.dataBirthday.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataBirthday.Location = new System.Drawing.Point(412, 181);
            this.dataBirthday.Name = "dataBirthday";
            this.dataBirthday.Size = new System.Drawing.Size(336, 26);
            this.dataBirthday.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(270, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Дата рождения: ";
            // 
            // lbMiddleName
            // 
            this.lbMiddleName.AutoSize = true;
            this.lbMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMiddleName.Location = new System.Drawing.Point(269, 141);
            this.lbMiddleName.Name = "lbMiddleName";
            this.lbMiddleName.Size = new System.Drawing.Size(87, 20);
            this.lbMiddleName.TabIndex = 5;
            this.lbMiddleName.Text = "Отчество:";
            // 
            // middleBox
            // 
            this.middleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middleBox.Location = new System.Drawing.Point(360, 138);
            this.middleBox.Name = "middleBox";
            this.middleBox.Size = new System.Drawing.Size(388, 26);
            this.middleBox.TabIndex = 4;
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSurname.Location = new System.Drawing.Point(269, 100);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(85, 20);
            this.lbSurname.TabIndex = 3;
            this.lbSurname.Text = "Фамилия:";
            // 
            // surmaneBox
            // 
            this.surmaneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surmaneBox.Location = new System.Drawing.Point(360, 97);
            this.surmaneBox.Name = "surmaneBox";
            this.surmaneBox.Size = new System.Drawing.Size(388, 26);
            this.surmaneBox.TabIndex = 2;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(269, 59);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 20);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Имя:";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBox.Location = new System.Drawing.Point(360, 56);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(388, 26);
            this.nameBox.TabIndex = 0;
            // 
            // IdentityPage
            // 
            this.IdentityPage.Controls.Add(this.panel2);
            this.IdentityPage.Location = new System.Drawing.Point(4, 22);
            this.IdentityPage.Name = "IdentityPage";
            this.IdentityPage.Padding = new System.Windows.Forms.Padding(3);
            this.IdentityPage.Size = new System.Drawing.Size(792, 354);
            this.IdentityPage.TabIndex = 1;
            this.IdentityPage.Text = "Удостоверение";
            this.IdentityPage.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 348);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataIdentityCard);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 51);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(786, 297);
            this.panel5.TabIndex = 2;
            // 
            // dataIdentityCard
            // 
            this.dataIdentityCard.AllowUserToAddRows = false;
            this.dataIdentityCard.AllowUserToDeleteRows = false;
            this.dataIdentityCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataIdentityCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataIdentityCard.Location = new System.Drawing.Point(0, 0);
            this.dataIdentityCard.Name = "dataIdentityCard";
            this.dataIdentityCard.Size = new System.Drawing.Size(786, 297);
            this.dataIdentityCard.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.CreateIdentityCard);
            this.flowLayoutPanel1.Controls.Add(this.ChengeIdenty);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(786, 51);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // CreateIdentityCard
            // 
            this.CreateIdentityCard.Location = new System.Drawing.Point(3, 3);
            this.CreateIdentityCard.Name = "CreateIdentityCard";
            this.CreateIdentityCard.Size = new System.Drawing.Size(120, 42);
            this.CreateIdentityCard.TabIndex = 1;
            this.CreateIdentityCard.Text = "Добавить удостоверение";
            this.CreateIdentityCard.UseVisualStyleBackColor = true;
            this.CreateIdentityCard.Click += new System.EventHandler(this.CreateIdentityCard_Click);
            // 
            // ChengeIdenty
            // 
            this.ChengeIdenty.Location = new System.Drawing.Point(129, 3);
            this.ChengeIdenty.Name = "ChengeIdenty";
            this.ChengeIdenty.Size = new System.Drawing.Size(120, 42);
            this.ChengeIdenty.TabIndex = 2;
            this.ChengeIdenty.Text = "Изменить удостоверение";
            this.ChengeIdenty.UseVisualStyleBackColor = true;
            this.ChengeIdenty.Click += new System.EventHandler(this.ChengeIdenty_Click);
            // 
            // MedicalPage
            // 
            this.MedicalPage.Controls.Add(this.panel4);
            this.MedicalPage.Controls.Add(this.panel3);
            this.MedicalPage.Location = new System.Drawing.Point(4, 22);
            this.MedicalPage.Name = "MedicalPage";
            this.MedicalPage.Size = new System.Drawing.Size(792, 354);
            this.MedicalPage.TabIndex = 2;
            this.MedicalPage.Text = "Медецинское осведетельствоние";
            this.MedicalPage.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridMedical);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(792, 303);
            this.panel4.TabIndex = 3;
            // 
            // dataGridMedical
            // 
            this.dataGridMedical.AllowUserToAddRows = false;
            this.dataGridMedical.AllowUserToDeleteRows = false;
            this.dataGridMedical.AllowUserToResizeRows = false;
            this.dataGridMedical.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMedical.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridMedical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMedical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridMedical.Location = new System.Drawing.Point(0, 0);
            this.dataGridMedical.Name = "dataGridMedical";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMedical.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridMedical.Size = new System.Drawing.Size(792, 303);
            this.dataGridMedical.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.AddMedicalComission);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(792, 51);
            this.panel3.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Image = global::AppInformPrivateSecurity.Properties.Resources.ExcelPicture__32x32_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(577, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 42);
            this.button3.TabIndex = 1;
            this.button3.Text = "Направление на мед. комиссию";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddMedicalComission
            // 
            this.AddMedicalComission.Location = new System.Drawing.Point(8, 3);
            this.AddMedicalComission.Name = "AddMedicalComission";
            this.AddMedicalComission.Size = new System.Drawing.Size(120, 42);
            this.AddMedicalComission.TabIndex = 0;
            this.AddMedicalComission.Text = "Изменить Мед. комиссию";
            this.AddMedicalComission.UseVisualStyleBackColor = true;
            this.AddMedicalComission.Click += new System.EventHandler(this.AddMedicalComission_Click);
            // 
            // openImgDialog
            // 
            this.openImgDialog.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(581, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(692, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 40);
            this.button2.TabIndex = 14;
            this.button2.Text = "Отменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 66);
            this.panel1.TabIndex = 15;
            // 
            // Сharacteristic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 442);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Сharacteristic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Характеристика";
            this.tabEmployee.ResumeLayout(false);
            this.EmployeePage.ResumeLayout(false);
            this.EmployeePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).EndInit();
            this.IdentityPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataIdentityCard)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.MedicalPage.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedical)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEmployee;
        private System.Windows.Forms.TabPage EmployeePage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.DateTimePicker dataBirthday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMiddleName;
        private System.Windows.Forms.TextBox middleBox;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.TextBox surmaneBox;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TabPage IdentityPage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox imgPhoto;
        private System.Windows.Forms.Button addPhoto;
        private System.Windows.Forms.TabPage MedicalPage;
        private System.Windows.Forms.OpenFileDialog openImgDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridMedical;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AddMedicalComission;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataIdentityCard;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button CreateIdentityCard;
        private System.Windows.Forms.Button ChengeIdenty;
    }
}