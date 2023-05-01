namespace AppInformPrivateSecurity
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переодическаяПроверкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridEmploers = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.добавитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медецинскиеЦентрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разрядToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учебныеЦентрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.отрправитьНаПереодическуюПроверкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmploers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.переодическаяПроверкаToolStripMenuItem,
            this.добавитьПользователяToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить работника";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // переодическаяПроверкаToolStripMenuItem
            // 
            this.переодическаяПроверкаToolStripMenuItem.Name = "переодическаяПроверкаToolStripMenuItem";
            this.переодическаяПроверкаToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.переодическаяПроверкаToolStripMenuItem.Text = "Периодическая проверка ";
            this.переодическаяПроверкаToolStripMenuItem.Click += new System.EventHandler(this.переодическаяПроверкаToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.медецинскиеЦентрыToolStripMenuItem,
            this.разрядToolStripMenuItem,
            this.учебныеЦентрыToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridEmploers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listBox1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 426);
            this.splitContainer1.SplitterDistance = 311;
            this.splitContainer1.TabIndex = 3;
            // 
            // dataGridEmploers
            // 
            this.dataGridEmploers.AllowUserToAddRows = false;
            this.dataGridEmploers.AllowUserToDeleteRows = false;
            this.dataGridEmploers.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridEmploers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmploers.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridEmploers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridEmploers.Location = new System.Drawing.Point(0, 0);
            this.dataGridEmploers.Name = "dataGridEmploers";
            this.dataGridEmploers.ReadOnly = true;
            this.dataGridEmploers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridEmploers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEmploers.Size = new System.Drawing.Size(800, 311);
            this.dataGridEmploers.TabIndex = 0;
            this.dataGridEmploers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEmploers_CellDoubleClick);
            this.dataGridEmploers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridEmploers_MouseClick);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(800, 111);
            this.listBox1.TabIndex = 0;
            // 
            // добавитьПользователяToolStripMenuItem
            // 
            this.добавитьПользователяToolStripMenuItem.Name = "добавитьПользователяToolStripMenuItem";
            this.добавитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.добавитьПользователяToolStripMenuItem.Text = "Добавить пользователя";
            this.добавитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.добавитьПользователяToolStripMenuItem_Click);
            // 
            // медецинскиеЦентрыToolStripMenuItem
            // 
            this.медецинскиеЦентрыToolStripMenuItem.Image = global::AppInformPrivateSecurity.Properties.Resources.medical_center;
            this.медецинскиеЦентрыToolStripMenuItem.Name = "медецинскиеЦентрыToolStripMenuItem";
            this.медецинскиеЦентрыToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.медецинскиеЦентрыToolStripMenuItem.Text = "Медецинские центры";
            this.медецинскиеЦентрыToolStripMenuItem.Click += new System.EventHandler(this.медецинскиеЦентрыToolStripMenuItem_Click);
            // 
            // разрядToolStripMenuItem
            // 
            this.разрядToolStripMenuItem.Image = global::AppInformPrivateSecurity.Properties.Resources.job;
            this.разрядToolStripMenuItem.Name = "разрядToolStripMenuItem";
            this.разрядToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.разрядToolStripMenuItem.Text = "Разряд";
            this.разрядToolStripMenuItem.Click += new System.EventHandler(this.разрядToolStripMenuItem_Click);
            // 
            // учебныеЦентрыToolStripMenuItem
            // 
            this.учебныеЦентрыToolStripMenuItem.Image = global::AppInformPrivateSecurity.Properties.Resources.school;
            this.учебныеЦентрыToolStripMenuItem.Name = "учебныеЦентрыToolStripMenuItem";
            this.учебныеЦентрыToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.учебныеЦентрыToolStripMenuItem.Text = "Учебные центры";
            this.учебныеЦентрыToolStripMenuItem.Click += new System.EventHandler(this.учебныеЦентрыToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отрправитьНаПереодическуюПроверкуToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(301, 48);
            // 
            // отрправитьНаПереодическуюПроверкуToolStripMenuItem
            // 
            this.отрправитьНаПереодическуюПроверкуToolStripMenuItem.Name = "отрправитьНаПереодическуюПроверкуToolStripMenuItem";
            this.отрправитьНаПереодическуюПроверкуToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.отрправитьНаПереодическуюПроверкуToolStripMenuItem.Text = "Отрправить на переодическую проверку";
            this.отрправитьНаПереодическуюПроверкуToolStripMenuItem.Click += new System.EventHandler(this.отрправитьНаПереодическуюПроверкуToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Картотека личных карточек";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmploers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медецинскиеЦентрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разрядToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учебныеЦентрыToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridEmploers;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem переодическаяПроверкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отрправитьНаПереодическуюПроверкуToolStripMenuItem;
    }
}

