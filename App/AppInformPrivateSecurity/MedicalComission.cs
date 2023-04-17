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
    public partial class MedicalComission : Form
    {
        private string id_worker = "";
        private MedicalForm medicalForm;
        private List<string> CurrentMedicalProperties;
        public MedicalComission(string id = "")
        {
            InitializeComponent();
            this.id_worker = id;
            medicalForm = new MedicalForm();
            combo_Centers.DataSource = medicalForm.getMedicalCenters();
            CurrentMedicalProperties = medicalForm.getCurrentMedicalProperties(id);
            initElements(CurrentMedicalProperties);
        }
        private void initElements(List<string> lMedical)
        {
            combo_Centers.SelectedIndex = combo_Centers.Items.IndexOf(lMedical[0]);
            textBoxCod.Text = lMedical[1];
            dateCreate.Value = DateTime.Parse(lMedical[2]);
            numMonthValid.Value = int.Parse(lMedical[3]);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UpdateCommission();
        }
        private void UpdateCommission()
        {
            string stMedicalCenter = combo_Centers.Text.ToString().Trim();
            string stCode = textBoxCod.Text.ToString().Trim();
            string stDateCreate = dateCreate.Value.ToString("yyyyMMdd");
            string stDatePeriod = numMonthValid.Value.ToString();
            medicalForm.UpdateCommission(this.id_worker, stMedicalCenter, stCode, stDateCreate, stDatePeriod);
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }
    }
}
