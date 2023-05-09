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
using AppInformPrivateSecurity.Report;

namespace AppInformPrivateSecurity
{
    public partial class PeriodicInspection : Form
    {
        private InitialInspection inspectionDB = null;
        public PeriodicInspection()
        {
            InitializeComponent();
            inspectionDB = new InitialInspection();
            getGridInspection(); // Заполняем поля инспекции
            getGridEmployer();
        }
        private void getGridEmployer()
        {
            comboEmployer.DataSource = inspectionDB.getWorker();
        }
        private void getGridInspection()
        {
            string where = "";
            if (checkAssigned.Checked == true)
            {
                where += " AND dateCreate>GETDATE() ";
            }
            if (checkFaindOnFamily.Checked && !string.IsNullOrEmpty(comboEmployer.Text))
            {
                where += " AND name = '" + comboEmployer.Text + "'";
            }
            if (checkFindOnCode.Checked && !string.IsNullOrEmpty(textCode.Text))
            {
                where += " AND code = '" + textCode.Text + "'";
            }
            if (checkFindOnDate.Checked && !string.IsNullOrEmpty(dateFindOnDateCreate.Text))
            {
                where += " AND dateCreate = '" + dateFindOnDateCreate.Value.ToString("yyyyMMdd") + "'";
            }
            GridInspection.DataSource = inspectionDB.getInspection(where);
            GridInspection.Columns["id"].Visible = false; //спрятать id
            GridInspection.Update();
        }

        private void checkFaindOnFamily_CheckedChanged(object sender, EventArgs e)
        {
            getGridInspection();
            checkedChecBOX(checkFaindOnFamily, comboEmployer);
        }

        private void checkFindOnCode_CheckedChanged(object sender, EventArgs e)
        {
            getGridInspection();
            checkedChecBOX(checkFindOnCode, textCode);
        }

        private void checkFindOnDate_CheckedChanged(object sender, EventArgs e)
        {
            getGridInspection();
            checkedChecBOX(checkFindOnDate, dateFindOnDateCreate);
        }

        private void зачтеноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultExam("1");
        }
        private void неЗачтеноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultExam("0");
        }

        /// <summary>
        /// Простовляем рузульта сдачи экзамена. 
        /// </summary>
        /// <param name="result"></param>
        private void ResultExam(string result)
        {
            string st = "";
            List<int> SelecedRowID = GridInspection.SelectedRows.Cast<DataGridViewRow>().Select(x => x.Index).ToList();
            for (int i = 0; i < SelecedRowID.Count; i++)
            {
                if (!inspectionDB.UpdateResulExam(GridInspection["Id", SelecedRowID[i]].Value.ToString(), result))
                {
                    MessageBox.Show("Ошибка записи данных", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    ///показываем что обовили этих людей.
                    st += (GridInspection["Ф.И.О", SelecedRowID[i]].Value.ToString()) + "\n";
                }
            }
            if (!string.IsNullOrEmpty(st))
            {
                MessageBox.Show("Список " + result + " обновлен: \n" + st, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ///после всех манипуляций просто обновляем.
            getGridInspection();
        }

        private void checkAssigned_CheckedChanged(object sender, EventArgs e)
        {
            getGridInspection();
        }
        /// <summary>
        /// Проверка на действующий 
        /// </summary>
        /// <param name="checkBox"></param>
        private void checkedChecBOX(CheckBox checkBox, Control control)
        {
            switch (checkBox.Checked)
            {
                case true: control.Enabled = true; break;
                case false: control.Enabled = false; break;
            }
        }

        private void comboEmployer_SelectedIndexChanged(object sender, EventArgs e)
        {
            getGridInspection();
        }

        private void textCode_KeyDown(object sender, KeyEventArgs e)
        {
            ///срабатывает при нажатии на клавишу Enter
            if (e.KeyCode == Keys.Enter)
            {
                getGridInspection();
            }
        }

        /// <summary>
        /// При изменении значений мы просто обновляем.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateFindOnDateCreate_ValueChanged(object sender, EventArgs e)
        {

            getGridInspection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PrintPeriodicInspection(GridInspection);
        }
    }
}
