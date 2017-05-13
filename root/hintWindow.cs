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
    public partial class hintWindow : Form
    {
        string usrn, type, name, codename;
        public hintWindow(string usrn, string type, string name, string codename)
        {
            InitializeComponent();
            this.usrn = usrn;
            this.type = type;
            this.name = name;
            this.codename = codename;
        }

        private void sendHelp_Click(object sender, EventArgs e)
        {
            string path = "data/users/" + usrn + "/help/" + codename + "-helpby-" + boardForm.username;
            File.WriteAllText(path,hintBox.Text);
            this.Close();
        }

        private void hintWindow_Load(object sender, EventArgs e)
        {
            helpUsrnLabel.Text = "Help " + usrn + " with a hint.";
        }
    }
}
