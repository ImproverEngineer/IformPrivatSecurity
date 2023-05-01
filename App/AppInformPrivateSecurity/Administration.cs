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

    public partial class Administration : Form
    {
        private AdministrationUsers administrationUsers;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="icon">иконка как у родительского окна.</param>
        public Administration(Icon icon)
        {
            InitializeComponent();
            this.Icon = icon;
            administrationUsers = new AdministrationUsers();
            gridUsers.DataSource = administrationUsers.GetUsers();
            gerUsers();
        }
        private void gerUsers()
        {
            gridUsers.DataSource = administrationUsers.GetUsers();
            gridUsers.Columns["ID"].Visible = false;
        }

        /// <summary>
        /// Добавить нового пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtnAdd_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(this.Icon);
            addUser.Owner = this;
            if (addUser.ShowDialog() == DialogResult.OK)
            {
                if (administrationUsers.AddUsers(addUser.UserName, addUser.Password))
                {
                    gerUsers();
                    MessageBox.Show("Пользоватль " + addUser.UserName + " добавлен", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Неудалось добавить пользователя " + addUser.Name + "", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        /// <summary>
        /// Удаляем записть пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (administrationUsers.DeleteUser(gridUsers["id", gridUsers.CurrentRow.Index].Value.ToString()))
            {
                gerUsers();
            }
        }
    }
}
