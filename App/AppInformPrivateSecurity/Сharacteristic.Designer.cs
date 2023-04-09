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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Сharacteristic));
            this.tabEmployee = new System.Windows.Forms.TabControl();
            this.EmployeePage = new System.Windows.Forms.TabPage();
            this.addPhoto = new System.Windows.Forms.Button();
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
            this.MedicalPage = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddMedicalComission = new System.Windows.Forms.Button();
            this.openImgDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgPhoto = new System.Windows.Forms.PictureBox();
            this.tabEmployee.SuspendLayout();
            this.EmployeePage.SuspendLayout();
            this.IdentityPage.SuspendLayout();
            this.MedicalPage.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).BeginInit();
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 348);
            this.panel2.TabIndex = 0;
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
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(792, 303);
            this.panel4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(792, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AddMedicalComission);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(792, 51);
            this.panel3.TabIndex = 2;
            // 
            // AddMedicalComission
            // 
            this.AddMedicalComission.Location = new System.Drawing.Point(8, 3);
            this.AddMedicalComission.Name = "AddMedicalComission";
            this.AddMedicalComission.Size = new System.Drawing.Size(120, 42);
            this.AddMedicalComission.TabIndex = 0;
            this.AddMedicalComission.Text = "Добавить Мед. комиссию";
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
            // imgPhoto
            // 
            this.imgPhoto.Location = new System.Drawing.Point(27, 46);
            this.imgPhoto.Name = "imgPhoto";
            this.imgPhoto.Size = new System.Drawing.Size(194, 228);
            this.imgPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPhoto.TabIndex = 10;
            this.imgPhoto.TabStop = false;
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
            this.IdentityPage.ResumeLayout(false);
            this.MedicalPage.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AddMedicalComission;
    }
}