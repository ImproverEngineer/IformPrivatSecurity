namespace AppInformPrivateSecurity
{
    partial class MedicalComission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicalComission));
            this.lab_MedicalCenter = new System.Windows.Forms.Label();
            this.lab_cod = new System.Windows.Forms.Label();
            this.lab_Date = new System.Windows.Forms.Label();
            this.lab_valid = new System.Windows.Forms.Label();
            this.combo_Centers = new System.Windows.Forms.ComboBox();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.dateCreate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numMonthValid = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numMonthValid)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_MedicalCenter
            // 
            this.lab_MedicalCenter.AutoSize = true;
            this.lab_MedicalCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_MedicalCenter.Location = new System.Drawing.Point(12, 42);
            this.lab_MedicalCenter.Name = "lab_MedicalCenter";
            this.lab_MedicalCenter.Size = new System.Drawing.Size(161, 20);
            this.lab_MedicalCenter.TabIndex = 0;
            this.lab_MedicalCenter.Text = "Медецинский центр";
            // 
            // lab_cod
            // 
            this.lab_cod.AutoSize = true;
            this.lab_cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_cod.Location = new System.Drawing.Point(12, 88);
            this.lab_cod.Name = "lab_cod";
            this.lab_cod.Size = new System.Drawing.Size(39, 20);
            this.lab_cod.TabIndex = 1;
            this.lab_cod.Text = "Код";
            // 
            // lab_Date
            // 
            this.lab_Date.AutoSize = true;
            this.lab_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_Date.Location = new System.Drawing.Point(12, 133);
            this.lab_Date.Name = "lab_Date";
            this.lab_Date.Size = new System.Drawing.Size(48, 20);
            this.lab_Date.TabIndex = 2;
            this.lab_Date.Text = "Дата";
            // 
            // lab_valid
            // 
            this.lab_valid.AutoSize = true;
            this.lab_valid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_valid.Location = new System.Drawing.Point(12, 177);
            this.lab_valid.Name = "lab_valid";
            this.lab_valid.Size = new System.Drawing.Size(194, 20);
            this.lab_valid.TabIndex = 3;
            this.lab_valid.Text = "Период действия в мес.";
            // 
            // combo_Centers
            // 
            this.combo_Centers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_Centers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combo_Centers.FormattingEnabled = true;
            this.combo_Centers.Location = new System.Drawing.Point(203, 39);
            this.combo_Centers.Name = "combo_Centers";
            this.combo_Centers.Size = new System.Drawing.Size(305, 28);
            this.combo_Centers.TabIndex = 5;
            // 
            // textBoxCod
            // 
            this.textBoxCod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCod.Location = new System.Drawing.Point(203, 85);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(305, 26);
            this.textBoxCod.TabIndex = 6;
            // 
            // dateCreate
            // 
            this.dateCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateCreate.Location = new System.Drawing.Point(203, 128);
            this.dateCreate.Name = "dateCreate";
            this.dateCreate.Size = new System.Drawing.Size(305, 26);
            this.dateCreate.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(164, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(280, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 40);
            this.button2.TabIndex = 16;
            this.button2.Text = "Отменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numMonthValid
            // 
            this.numMonthValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numMonthValid.Location = new System.Drawing.Point(203, 175);
            this.numMonthValid.Name = "numMonthValid";
            this.numMonthValid.Size = new System.Drawing.Size(305, 26);
            this.numMonthValid.TabIndex = 17;
            // 
            // MedicalComission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 303);
            this.Controls.Add(this.numMonthValid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateCreate);
            this.Controls.Add(this.textBoxCod);
            this.Controls.Add(this.combo_Centers);
            this.Controls.Add(this.lab_valid);
            this.Controls.Add(this.lab_Date);
            this.Controls.Add(this.lab_cod);
            this.Controls.Add(this.lab_MedicalCenter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MedicalComission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MedicalComission";
            ((System.ComponentModel.ISupportInitialize)(this.numMonthValid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_MedicalCenter;
        private System.Windows.Forms.Label lab_cod;
        private System.Windows.Forms.Label lab_Date;
        private System.Windows.Forms.Label lab_valid;
        private System.Windows.Forms.ComboBox combo_Centers;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.DateTimePicker dateCreate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numMonthValid;
    }
}