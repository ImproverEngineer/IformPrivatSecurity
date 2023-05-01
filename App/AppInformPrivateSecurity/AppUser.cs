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
using Microsoft.Office.Interop.Excel;

namespace AppInformPrivateSecurity
{
    public partial class AppUser : Form
    {
        Authorization authorization;
        public AppUser()
        {
            InitializeComponent();
            authorization = new Authorization();
            cmbUsers.DataSource = authorization.getUsers();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //выход из приложения
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            string password = edbPassword.Text;
            if (!string.IsNullOrEmpty(password))
            {
                if (authorization.checkPassword(cmbUsers.Text, password))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Введен не верный пароль, проверите состояние клавиш NumLook, CapsLook или раскладку клавиатуры ", "В доступе отказано", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}
