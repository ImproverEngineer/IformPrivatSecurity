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
    public partial class SprManipulation : Form
    {
        private DBServiceSpr dbSprService;
        private string typeSpr;
        private string id = null;
        private string operation;
        public SprManipulation(string typeSpr, Icon ico, string operation, string id = "UNDENFINED")
        {
            InitializeComponent();
            dbSprService = new DBServiceSpr();
            this.Icon = ico;
            this.typeSpr = typeSpr;
            this.operation = operation;
            this.Text = createCaptionString(typeSpr, operation);
            selectTag(typeSpr);
            ///заполняем поля формы при редактировании строк
            if (operation == "UPDATE")
            {
                this.id = id;
                FillInTheFields(typeSpr, id);
            }
        }
        #region Создать заголовок, выбор закладки, заполнение полей. 
        /// <summary>
        /// Создать заголовок
        /// </summary>
        /// <param name="typeSpr"></param>
        /// <param name="operation"></param>
        /// <returns>заголовок окна</returns>
        private string createCaptionString(string typeSpr, string operation)
        {
            string caption = "";
            switch (operation)
            {
                case "ADD": caption += "Добавить "; break;
                case "UPDATE": caption += "Изменить "; break;
            }
            switch (typeSpr)
            {
                case "MEDICAL": caption += "медецинский центр"; break;
                case "DISCHARCHE": caption += "разряд"; break;
                case "EDUCATION": caption += "учебный центр"; break;
            }
            return caption;
        }
        /// <summary>
        /// выбрать закладку которую необходимо открыть
        /// </summary>
        /// <param name="typeSpr"></param>
        private void selectTag(string typeSpr)
        {
            switch (typeSpr)
            {
                case "MEDICAL": tabControl1.SelectedTab = tabPage1; break;
                case "DISCHARCHE": tabControl1.SelectedTab = tabPage2; break;
                case "EDUCATION": tabControl1.SelectedTab = tabPage3; break;
            }
        }
        /// <summary>
        /// Заполняем текстовые поля 
        /// </summary>
        /// <param name="typeSpr"></param>
        /// <param name="id"></param>
        private void FillInTheFields(string typeSpr, string id)
        {
            switch (typeSpr)
            {
                case "MEDICAL": medical(); break;
                case "DISCHARCHE": discharge(); break;
                case "EDUCATION": education(); break;
            }
            void medical()
            {
                List<string> list = dbSprService.getElementMedical(id);
                editMedicalName.Text = list[0];
                editMedicalAddress.Text = list[1];
                editMedicalPhone.Text = list[2];
            }
            void discharge()
            {
                List<string> list = dbSprService.getElementDischarge(id);
                codeDischarge.Text = list[0];
                nameDischarge.Text = list[1];
            }
            void education()
            {
                List<string> list = dbSprService.getElementEducationCenters(id);
                nameEducation.Text = list[0];
                licenseEducation.Text = list[1];
                addresEducation.Text = list[2];
            }
        }
        #endregion

        #region Кнопки управления    

        private void btnMedicalCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMedicalSave_Click(object sender, EventArgs e)
        {
            dbSprService.saveMedical(editMedicalName.Text, editMedicalAddress.Text, editMedicalPhone.Text, id);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSaveDischarge_Click(object sender, EventArgs e)
        {
            dbSprService.saveDischarge(codeDischarge.Text, nameDischarge.Text, id);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelDischarge_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelEducationInst_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveEducationInst_Click(object sender, EventArgs e)
        {
            dbSprService.saveEducationInst(nameEducation.Text, licenseEducation.Text, addresEducation.Text, id);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion
    }
}
