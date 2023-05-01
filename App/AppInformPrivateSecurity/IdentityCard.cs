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
    public partial class IdentityCard : Form
    {
        private IdentityCardData identityCard;
        private string id; // id оханика
        private string ic;

        //Работаем с текушим Id работника + ic идентификатор сотрудника
        public IdentityCard(string id, string ic = null)
        {
            InitializeComponent();
            this.id = id;
            this.ic = ic;
            identityCard = IdentityCardData.IdentityCard();
            FillcmdDischarge();
            FillcmdEducation();
            if (!string.IsNullOrEmpty(ic))
            {
                this.Text = "Перезаписать удостоверение охранника";
                List<string> list = identityCard.getIdentityCard(ic);
                cmbDischarge.SelectedIndex = cmbDischarge.Items.IndexOf(list[1].ToString());
                dateCreate.Text = list[2].ToString();
                numericTerm.Text = list[3].ToString();
                txtCode.Text = list[4].ToString();
                dateEndLearn.Text = list[5].ToString();
                cmbEducationall.SelectedIndex = cmbEducationall.Items.IndexOf(list[6].ToString());
            }
        }

        //Заполнить значения разряда
        private void FillcmdDischarge()
        {
            cmbDischarge.DataSource = identityCard.getDischarge();
        }
        //Заполняем учебное заведение 
        private void FillcmdEducation()
        {
            cmbEducationall.DataSource = identityCard.getEducationalInstitutions();
        }

        #region Buttons Ok/Cancel
        private void button1_Click(object sender, EventArgs e)
        {
            //Основные элементы
            string discarge = cmbDischarge.Text;
            string dateCreates = dateCreate.Value.ToString("yyyyMMdd");
            string nTerm = numericTerm.Value.ToString();
            //то что касается обучения
            string codeEducation = txtCode.Text;
            string dateEducations = dateEndLearn.Value.ToString("yyyyMMdd");
            string nameEducational = cmbEducationall.Text;
            if (!string.IsNullOrEmpty(this.ic))
            {
                //Изменить удостоверение охраника передаем id idenityCard т.к. в этом месте мы хотим обновится.
                identityCard.updateIndentityCard(this.ic, discarge, dateCreates, nTerm, codeEducation, dateEducations, nameEducational);
            }
            else
            {
                //Добавляем записи в таблицу idenityCard.
                identityCard.createIndentityCard(this.id, discarge, dateCreates, nTerm, codeEducation, dateEducations, nameEducational);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion
    }
}
