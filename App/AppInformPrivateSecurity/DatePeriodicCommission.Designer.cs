namespace AppInformPrivateSecurity
{
    partial class DatePeriodicCommission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatePeriodicCommission));
            this.dateTimeExam = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.appoint = new System.Windows.Forms.Button();
            this.doNotAppoint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimeExam
            // 
            this.dateTimeExam.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeExam.Location = new System.Drawing.Point(15, 36);
            this.dateTimeExam.Name = "dateTimeExam";
            this.dateTimeExam.Size = new System.Drawing.Size(331, 26);
            this.dateTimeExam.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата периодической комиссии";
            // 
            // appoint
            // 
            this.appoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appoint.Location = new System.Drawing.Point(33, 87);
            this.appoint.Name = "appoint";
            this.appoint.Size = new System.Drawing.Size(136, 50);
            this.appoint.TabIndex = 2;
            this.appoint.Text = "Назначить";
            this.appoint.UseVisualStyleBackColor = true;
            this.appoint.Click += new System.EventHandler(this.appoint_Click);
            // 
            // doNotAppoint
            // 
            this.doNotAppoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doNotAppoint.Location = new System.Drawing.Point(175, 87);
            this.doNotAppoint.Name = "doNotAppoint";
            this.doNotAppoint.Size = new System.Drawing.Size(136, 50);
            this.doNotAppoint.TabIndex = 3;
            this.doNotAppoint.Text = "Отменить";
            this.doNotAppoint.UseVisualStyleBackColor = true;
            this.doNotAppoint.Click += new System.EventHandler(this.doNotAppoint_Click);
            // 
            // DatePeriodicCommission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 152);
            this.Controls.Add(this.doNotAppoint);
            this.Controls.Add(this.appoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeExam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatePeriodicCommission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Назначить дату периодической комиссии";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeExam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button appoint;
        private System.Windows.Forms.Button doNotAppoint;
    }
}