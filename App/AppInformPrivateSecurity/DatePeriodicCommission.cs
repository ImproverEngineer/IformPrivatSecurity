using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppInformPrivateSecurity
{
    public partial class DatePeriodicCommission : Form
    {
        public string DateExam;
        public DatePeriodicCommission()
        {
            InitializeComponent();
        }

        private void doNotAppoint_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
        }

        private void appoint_Click(object sender, EventArgs e)
        {
            DateExam = dateTimeExam.Value.ToString("yyyyMMdd");
            this.DialogResult = DialogResult.OK;
        }
    }
}
