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
            AppUser user = new AppUser();
            // Пока не авторизировался не пускаем в приложение           
            if (user.ShowDialog() == DialogResult.OK)
            {
                // что то делаем 
            }
            else
            {
                Environment.Exit(0);
            }

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
            // обновляем таблицу
            if (sprMedical.DialogResult == DialogResult.OK)
            {
                updateGridEmploers();
            }
        }

        #endregion

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Сharacteristic сharacteristic = new Сharacteristic();
            // обновляем таблицу
            if (сharacteristic.ShowDialog() == DialogResult.OK)
            {
                updateGridEmploers();
            }
        }





        private void dataGridEmploers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Сharacteristic сharacteristic = new Сharacteristic(dataGridEmploers["id", dataGridEmploers.CurrentRow.Index].Value.ToString());
            if (сharacteristic.ShowDialog() == DialogResult.OK)
            {

            }
        }

        #region Работаем с ListBox в частности делаем проверку и подсвечиваем красным цветом
        /// <summary>
        /// тут просто запоминаем возможные варианты общения с пользователем.
        /// </summary>
        List<string> ErrorChecks = new List<string> { "Срок прохождения следующий мед. комиссии: удостоверение не получено",
                                                      "Срок прохождения следующий мед. комиссии: просрочено",
                                                      "Срок действия удостоверения до: удостоверение не получено",
                                                      "Срок действия удостоверения до: просрочено"
                                                    };

        private void dataGridEmploers_MouseClick(object sender, MouseEventArgs e)
        {
            listBox1.DrawMode = DrawMode.Normal;
            List<string> emploer = employeer.getWorker(dataGridEmploers["id", dataGridEmploers.CurrentRow.Index].Value.ToString());
            listBox1.Items.Clear();
            listBox1.Items.Add("ФИО: " + emploer[1]);
            listBox1.Items.Add("Тел: " + emploer[2]);
            if (emploer[3].ToString() == "01.01.1900")
            { listBox1.Items.Add(ErrorChecks[0]); GraphicsListBox(listBox1, 2); }
            else
            { //Проверить не просрочено ли удостоверение
                if (DateTime.Parse(emploer[3]) < DateTime.Now)
                {
                    listBox1.Items.Add(ErrorChecks[1]);
                    GraphicsListBox(listBox1, 2);
                }
                else
                {
                    listBox1.Items.Add("Дата прохождения следующий комиссии: " + emploer[3]);
                }
            }
            //срок дейсвсия комиссии до.
            if (emploer[4].ToString() == "01.01.1900")
            {
                listBox1.Items.Add(ErrorChecks[2]);
                GraphicsListBox(listBox1, 3);
            }
            else
            {
                if (DateTime.Parse(emploer[3]) < DateTime.Now)
                {
                    listBox1.Items.Add(ErrorChecks[3]);
                }
                else
                {
                    listBox1.Items.Add("Срок действия удостоверения до : " + emploer[4]);
                }
            }
            //listBox1.Items.Add("Дата получения удостоверения: " + emploer[4]); if (emploer[4].ToString() == "01.01.1900") { GraphicsListBox(listBox1, 3); }

        }
        /// <summary>
        /// Раскрашиваем ListBox что бы видеть что там у пользователя.
        /// </summary>
        /// <param name="lb"></param>
        /// <param name="indexVal"></param>
        private void GraphicsListBox(ListBox lb, int indexVal)
        {
            lb.DrawMode = DrawMode.OwnerDrawFixed;

            lb.DrawItem += (sender, e) =>
            {
                e.DrawBackground();
                Graphics g = e.Graphics;
                string val = (string)lb.Items[e.Index];
                if (ErrorChecks.Exists(x => val == x))
                {
                    g.FillRectangle(new SolidBrush(Color.Red), e.Bounds);
                }
                else
                {
                    g.FillRectangle(new SolidBrush(Color.White), e.Bounds);
                }
                g.DrawString(val.ToString(), e.Font, new SolidBrush(Color.Black), e.Bounds);
                e.DrawFocusRectangle();
            };
        }
        #endregion 

        private void переодическаяПроверкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeriodicInspection periodicInspection = new PeriodicInspection();
            if (periodicInspection.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void добавитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administration administration = new Administration(this.Icon);
            administration.ShowDialog();
        }

        private void отрправитьНаПереодическуюПроверкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dateExam = "";
            DatePeriodicCommission datePeriodicCommission = new DatePeriodicCommission();
            List<string> Message = new List<string>();
            if (datePeriodicCommission.ShowDialog() == DialogResult.OK)
            {
                dateExam = datePeriodicCommission.DateExam;
                ///Получить индекс выделеных элементов
                List<int> SelecedRowID = dataGridEmploers.SelectedRows.Cast<DataGridViewRow>().Select(x => x.Index).ToList();
                for (int i = 0; i < SelecedRowID.Count; i++)
                {
                    if (!employeer.setPeriodCommission(dataGridEmploers["Id", SelecedRowID[i]].Value.ToString(), dateExam))
                    {
                        //Ошибка записи данных.
                        MessageBox.Show("Ошибка записи данных", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Message.Add(dataGridEmploers["Фамилия", SelecedRowID[i]].Value.ToString() + " " + dataGridEmploers["Имя", SelecedRowID[i]].Value.ToString()[0] + "." + dataGridEmploers["Отчество", SelecedRowID[i]].Value.ToString()[0] + ".");
                }
                string message = "Отправлены на переодическую проверку " + dateExam.Substring(6, 2) + "." + dateExam.Substring(4, 2) + "." + dateExam.Substring(0, 4) + "\n";
                foreach (string s in Message)
                {
                    message += s + " \n";
                }
                MessageBox.Show(message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
