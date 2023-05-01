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
    public partial class AddUser : Form
    {
        public string UserName;
        public string Password;

        public AddUser(Icon icon)
        {
            InitializeComponent();
            this.Icon = icon;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserName = edtName.Text;
            Password = edtPassword.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
