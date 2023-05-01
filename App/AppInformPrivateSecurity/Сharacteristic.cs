using AppInformPrivateSecurity.Data;
using AppInformPrivateSecurity.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AppInformPrivateSecurity
{
    public partial class Сharacteristic : Form
    {
        private string PhotoString = "";
        Employeer employeer = null;
        private string id = null;
        private List<string> informatinWorker;
        public Сharacteristic(string id = null)
        {
            InitializeComponent();
            this.employeer = new Employeer();
            this.id = id;
            openImgDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openImgDialog.Filter = "txt files (*.jpg)|*.jpg|All files (*.*)|*.*";
            MedicalPage.Parent = null;
            IdentityPage.Parent = null;
            if (!string.IsNullOrEmpty(id))
            {
                List<string> ls = employeer.informationWorker(id);
                informatinWorker = ls;
                nameBox.Text = ls[0];
                surmaneBox.Text = ls[1];
                middleBox.Text = ls[2];
                dataBirthday.Value = DateTime.Parse(ls[3]);
                phoneBox.Text = ls[4];
                if (ls[5] != "")
                {
                    Bitmap image = new Bitmap(ls[5]);
                    imgPhoto.Image = image;
                    imgPhoto.Invalidate();
                }
                MedicalPage.Parent = tabEmployee;
                IdentityPage.Parent = tabEmployee;
                UpdateDataGridMedical(this.id); // обновление таблицы работников
                UpdateDataGridIdentityCard(this.id); //
                // получить фото
                // заполнить поля
            }

        }
        private void UpdateDataGridMedical(string id)
        {
            dataGridMedical.DataSource = employeer.MedicalCommission(id);
        }
        private void UpdateDataGridIdentityCard(string id)
        {
            dataIdentityCard.DataSource = employeer.IdentityCard(id);
            dataIdentityCard.Columns["id"].Visible = false; //
            dataIdentityCard.Columns["ic_id"].Visible = false; // Для изменения
        }

        /// <summary>
        /// Вставка фотографии 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addPhoto_Click(object sender, EventArgs e)
        {

            if (openImgDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PhotoString = openImgDialog.FileName; //сохраняем фотку для того чтобы сохранить.
                    Bitmap image = new Bitmap(openImgDialog.FileName);
                    imgPhoto.Image = image;
                    imgPhoto.Invalidate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не возможно открыть картинку, " + ex.Message + ".", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id))
            {
                saveEmploer();
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                //updateEmploer
            }
        }
        private void saveEmploer()
        {
            string name = nameBox.Text;
            string surname = surmaneBox.Text;
            string smiddleBox = middleBox.Text;
            string birthday = dataBirthday.Value.ToString("yyyyMMdd");
            string phone = phoneBox.Text;
            id = employeer.saveEmploeer(name, surname, smiddleBox, birthday, phone, PhotoString);
            if (!string.IsNullOrEmpty(id))
            {
                //получить id последнего сохраненого 
                MedicalPage.Parent = tabEmployee;
                IdentityPage.Parent = tabEmployee;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddMedicalComission_Click(object sender, EventArgs e)
        {
            MedicalComission medicalComission = new MedicalComission(this.id);

            if (medicalComission.ShowDialog() == DialogResult.OK)
            {
                //если внесли изменения обновляем таблицу с медецинским осведетельствованием.
                UpdateDataGridMedical(this.id);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrintMedicalDirection medicalDirection = new PrintMedicalDirection(informatinWorker);
        }

        private void CreateIdentityCard_Click(object sender, EventArgs e)
        {
            //Создать идентификатор человеки
            IdentityCard identityCard = new IdentityCard(this.id);
            if (identityCard.ShowDialog() == DialogResult.OK)
            {
                UpdateDataGridIdentityCard(this.id);
            }

        }

        private void ChengeIdenty_Click(object sender, EventArgs e)
        {
            IdentityCard identityCard = new IdentityCard(this.id, dataIdentityCard["ic_id", dataIdentityCard.CurrentCell.RowIndex].Value.ToString());
            if (identityCard.ShowDialog() == DialogResult.OK)
            {
                UpdateDataGridIdentityCard(this.id);
            }

        }
    }
}
