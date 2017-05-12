using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace root
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void usrnEdit_MouseDown(object sender, MouseEventArgs e)
        {
            if (usrnEdit.Text == "username")
                usrnEdit.Text = "";
        }

        private void usrnEdit_Leave(object sender, EventArgs e)
        {
            if (usrnEdit.Text == "")
                usrnEdit.Text = "username";
        }

        private void passEdit_MouseDown(object sender, MouseEventArgs e)
        {
            if (passEdit.Text == "password")
                passEdit.Text = "";
        }

        private void passEdit_Leave(object sender, EventArgs e)
        {
            if (passEdit.Text == "")
                passEdit.Text = "password";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usrnEdit.Text != "" && passEdit.Text != "")
                MessageBox.Show("You've logged in successfully yay!");
        }
    }
}
