namespace AppInformPrivateSecurity
{
    partial class PeriodicInspection
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeriodicInspection));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.GridInspection = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkAssigned = new System.Windows.Forms.CheckBox();
            this.comboEmployer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFindOnDateCreate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkFaindOnFamily = new System.Windows.Forms.CheckBox();
            this.checkFindOnCode = new System.Windows.Forms.CheckBox();
            this.checkFindOnDate = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.зачтеноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.неЗачтеноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridInspection)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 132);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::AppInformPrivateSecurity.Properties.Resources.exam2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(650, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Уведомить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GridInspection
            // 
            this.GridInspection.AllowUserToAddRows = false;
            this.GridInspection.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridInspection.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridInspection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridInspection.ContextMenuStrip = this.contextMenuStrip1;
            this.GridInspection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridInspection.Location = new System.Drawing.Point(0, 132);
            this.GridInspection.Name = "GridInspection";
            this.GridInspection.ReadOnly = true;
            this.GridInspection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridInspection.Size = new System.Drawing.Size(819, 318);
            this.GridInspection.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkFindOnDate);
            this.groupBox1.Controls.Add(this.checkFindOnCode);
            this.groupBox1.Controls.Add(this.checkFaindOnFamily);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateFindOnDateCreate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboEmployer);
            this.groupBox1.Controls.Add(this.checkAssigned);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтр для периодической сдачи экзамена ";
            // 
            // checkAssigned
            // 
            this.checkAssigned.AutoSize = true;
            this.checkAssigned.Checked = true;
            this.checkAssigned.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAssigned.Location = new System.Drawing.Point(6, 30);
            this.checkAssigned.Name = "checkAssigned";
            this.checkAssigned.Size = new System.Drawing.Size(237, 17);
            this.checkAssigned.TabIndex = 0;
            this.checkAssigned.Text = "Выбрать все у кого назначена пересдача";
            this.checkAssigned.UseVisualStyleBackColor = true;
            this.checkAssigned.CheckedChanged += new System.EventHandler(this.checkAssigned_CheckedChanged);
            // 
            // comboEmployer
            // 
            this.comboEmployer.Enabled = false;
            this.comboEmployer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboEmployer.FormattingEnabled = true;
            this.comboEmployer.Location = new System.Drawing.Point(11, 79);
            this.comboEmployer.Name = "comboEmployer";
            this.comboEmployer.Size = new System.Drawing.Size(237, 28);
            this.comboEmployer.TabIndex = 1;
            this.comboEmployer.SelectedIndexChanged += new System.EventHandler(this.comboEmployer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Найти по фамилии ";
            // 
            // dateFindOnDateCreate
            // 
            this.dateFindOnDateCreate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateFindOnDateCreate.Enabled = false;
            this.dateFindOnDateCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateFindOnDateCreate.Location = new System.Drawing.Point(294, 78);
            this.dateFindOnDateCreate.Name = "dateFindOnDateCreate";
            this.dateFindOnDateCreate.Size = new System.Drawing.Size(304, 29);
            this.dateFindOnDateCreate.TabIndex = 3;
            this.dateFindOnDateCreate.ValueChanged += new System.EventHandler(this.dateFindOnDateCreate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(292, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Найти по назначеной дате";
            // 
            // textCode
            // 
            this.textCode.Enabled = false;
            this.textCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textCode.Location = new System.Drawing.Point(294, 29);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(304, 26);
            this.textCode.TabIndex = 5;
            this.textCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textCode_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(293, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Код удостоверения";
            // 
            // checkFaindOnFamily
            // 
            this.checkFaindOnFamily.AutoSize = true;
            this.checkFaindOnFamily.Location = new System.Drawing.Point(255, 86);
            this.checkFaindOnFamily.Name = "checkFaindOnFamily";
            this.checkFaindOnFamily.Size = new System.Drawing.Size(15, 14);
            this.checkFaindOnFamily.TabIndex = 7;
            this.checkFaindOnFamily.UseVisualStyleBackColor = true;
            this.checkFaindOnFamily.CheckedChanged += new System.EventHandler(this.checkFaindOnFamily_CheckedChanged);
            // 
            // checkFindOnCode
            // 
            this.checkFindOnCode.AutoSize = true;
            this.checkFindOnCode.Location = new System.Drawing.Point(604, 37);
            this.checkFindOnCode.Name = "checkFindOnCode";
            this.checkFindOnCode.Size = new System.Drawing.Size(15, 14);
            this.checkFindOnCode.TabIndex = 8;
            this.checkFindOnCode.UseVisualStyleBackColor = true;
            this.checkFindOnCode.CheckedChanged += new System.EventHandler(this.checkFindOnCode_CheckedChanged);
            // 
            // checkFindOnDate
            // 
            this.checkFindOnDate.AutoSize = true;
            this.checkFindOnDate.Location = new System.Drawing.Point(604, 87);
            this.checkFindOnDate.Name = "checkFindOnDate";
            this.checkFindOnDate.Size = new System.Drawing.Size(15, 14);
            this.checkFindOnDate.TabIndex = 9;
            this.checkFindOnDate.UseVisualStyleBackColor = true;
            this.checkFindOnDate.CheckedChanged += new System.EventHandler(this.checkFindOnDate_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зачтеноToolStripMenuItem,
            this.неЗачтеноToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 48);
            // 
            // зачтеноToolStripMenuItem
            // 
            this.зачтеноToolStripMenuItem.Name = "зачтеноToolStripMenuItem";
            this.зачтеноToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.зачтеноToolStripMenuItem.Text = "Зачтено";
            this.зачтеноToolStripMenuItem.Click += new System.EventHandler(this.зачтеноToolStripMenuItem_Click);
            // 
            // неЗачтеноToolStripMenuItem
            // 
            this.неЗачтеноToolStripMenuItem.Name = "неЗачтеноToolStripMenuItem";
            this.неЗачтеноToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.неЗачтеноToolStripMenuItem.Text = "Не зачтено";
            this.неЗачтеноToolStripMenuItem.Click += new System.EventHandler(this.неЗачтеноToolStripMenuItem_Click);
            // 
            // PeriodicInspection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 450);
            this.Controls.Add(this.GridInspection);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PeriodicInspection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Переодическая проверка сотрудников";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridInspection)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GridInspection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateFindOnDateCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboEmployer;
        private System.Windows.Forms.CheckBox checkAssigned;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.CheckBox checkFindOnDate;
        private System.Windows.Forms.CheckBox checkFindOnCode;
        private System.Windows.Forms.CheckBox checkFaindOnFamily;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem зачтеноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem неЗачтеноToolStripMenuItem;
    }
}