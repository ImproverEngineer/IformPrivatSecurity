using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using AppInformPrivateSecurity.Data;

namespace AppInformPrivateSecurity
{
    public partial class SprForm : Form
    {
        private string typeSpr;
        DBServiceSpr dbSprService;// клас подключения к базе
        public SprForm(string typeSpr)
        {
            InitializeComponent();
            this.typeSpr = typeSpr;
            dbSprService = new DBServiceSpr();
            Icon SrpIcon;
            switch (typeSpr)
            {
                case "MEDICAL":
                    SrpIcon = Icon.ExtractAssociatedIcon(Environment.CurrentDirectory + @"\ico\medical.ico");
                    this.Icon = SrpIcon;
                    this.Text = "Медецинские центры";
                    break;
                case "DISCHARCHE":
                    SrpIcon = Icon.ExtractAssociatedIcon(Environment.CurrentDirectory + @"\ico\fDischarge.ico");
                    this.Icon = SrpIcon;
                    this.Text = "Разряды";

                    break;
                case "EDUCATION":
                    SrpIcon = Icon.ExtractAssociatedIcon(Environment.CurrentDirectory + @"\ico\student.ico");
                    this.Icon = SrpIcon;
                    this.Text = "Образовательные учереждения"
                    ; break;
            }
        }

        #region Обновить Grid в зависимости от того какой сейчас выбран центр.
        /// <summary>
        /// Обновить Grid в зависимости от того какой сейчас выбран центр.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SprMedicalCenters_Load(object sender, EventArgs e)
        {
            updateGrid();
        }
        #endregion
        private void updateGrid()
        {
            switch (typeSpr)
            {
                case "MEDICAL": updateMedicalGridView(); break;
                case "DISCHARCHE": updateDischargeGridView(); break;
                case "EDUCATION": updateEducationGridView(); break;
            }
        }
        private void updateMedicalGridView()
        {
            SprGridView.DataSource = dbSprService.getMedicalCenters();
            SprGridView.Columns["ID"].Visible = false;
            SprGridView.Columns["Наименование"].Width = 200;
            SprGridView.Columns["Адрес"].Width = 300;
            SprGridView.Columns["Телефон"].Width = 120;
        }
        private void updateDischargeGridView()
        {
            SprGridView.DataSource = dbSprService.getDischarge();
            SprGridView.Columns["ID"].Visible = false;
            SprGridView.Columns["Код"].Width = 30;
            SprGridView.Columns["Описание"].Width = 200;
        }
        private void updateEducationGridView()
        {
            SprGridView.DataSource = dbSprService.getEducationCenters();
            SprGridView.Columns["ID"].Visible = false;
            SprGridView.Columns["Наименование"].Width = 200;
            SprGridView.Columns["Лицензия"].Width = 200;
            SprGridView.Columns["Адрес"].Width = 300;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            createSprManipulationForm("ADD", "UNDENFINED");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (SprGridView.CurrentRow == null)
            {
                MessageBox.Show("Необходимо выбрать строку для изменения", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int indexRow = SprGridView.CurrentRow.Index; // получить индекс текущей строки
            createSprManipulationForm("UPDATE", SprGridView["id", indexRow].Value.ToString());
        }

        #region Insert, Update для справочников.
        /// <summary>
        /// Процедура будет делать две операции вставки нового элемената и изменение текущего
        /// </summary>
        /// <param name="operation">Тип операции</param>
        /// <param name="id">ID элемента который необходимо заменить</param>
        private void createSprManipulationForm(string operation, string id)
        {
            SprManipulation manipulation = new SprManipulation(typeSpr, this.Icon, operation, id);
            manipulation.Owner = this;
            if (manipulation.ShowDialog() == DialogResult.OK)
            {
                updateGrid();
            }
        }
        #endregion
    }
}
