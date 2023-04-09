using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppInformPrivateSecurity.Data;

namespace AppInformPrivateSecurity
{

    public partial class MainWindow : Form
    {
        private Employeer employeer;
        public MainWindow()
        {
            InitializeComponent();
            employeer = new Employeer();
            updateGridEmploers();

        }
        /// <summary>
        /// Обновляем таблицу работников
        /// </summary>
        private void updateGridEmploers()
        {
            dataGridEmploers.DataSource = employeer.getWorkers();
            dataGridEmploers.Columns["ID"].Visible = false;
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

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Сharacteristic сharacteristic = new Сharacteristic();
            if (сharacteristic.ShowDialog() == DialogResult.OK)
            {

            }
        }





        private void dataGridEmploers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Сharacteristic сharacteristic = new Сharacteristic(dataGridEmploers["id", dataGridEmploers.CurrentRow.Index].Value.ToString());
            if (сharacteristic.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
