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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Работа с окном справочников.
        private void учебныеЦентрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openSprFormWithСondition("EDUCATION");
        }

        private void медецинскиеЦентрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openSprFormWithСondition("MEDICAL");
        }

        private void разрядToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openSprFormWithСondition("DISCHARCHE");
        }
        /// <summary>
        /// отктрыть окно справочников.
        /// </summary>
        /// <param name="Condition"></param>
        private void openSprFormWithСondition(string Condition)
        {
            SprForm sprMedical = new SprForm(Condition);
            sprMedical.ShowDialog();
            if (sprMedical.DialogResult == DialogResult.OK)
            {

            }
        }
        #endregion
    }
}
