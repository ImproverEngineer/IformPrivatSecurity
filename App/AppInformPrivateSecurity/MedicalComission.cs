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
        private MedicalForm medicalForm;
        public MedicalComission(string id = "")
        {
            InitializeComponent();
            medicalForm = new MedicalForm();
            combo_Centers.DataSource = medicalForm.getMedicalCenters();

            //  combo_Centers.SelectedIndex = combo_Centers.Items.IndexOf("ГОРОД ПЕРМЬ, ШОССЕ КОСМОНАВТОВ, ДОМ 160"); //выбираем из представленых

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
            string stDatePeriod = datePeriod.Value.ToString("yyyyMMdd");
            string stDateRenewal = dateRenewal.Value.ToString("yyyyMMdd");
            //   medicalForm.UpdateCommision(id_medicalCenter, stMedicalCenter, stCode, stDateCreate, stDatePeriod, stDateRenewal);
        }
    }
}
