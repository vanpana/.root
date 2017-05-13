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
            {
                boardForm bf = new boardForm(usrnEdit.Text);
                if (!Directory.Exists("data/users/" + usrnEdit.Text))
                {
                    Directory.CreateDirectory("data/users/" + usrnEdit.Text);
                    Directory.CreateDirectory("data/users/" + usrnEdit.Text + "/help");
                    Directory.CreateDirectory("data/users/" + usrnEdit.Text + "/uploaded");
                }
                    
                bf.Show();
            }
        }
    }
}
