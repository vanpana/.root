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
    public partial class helpFeedback : Form
    {
        public helpFeedback()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = helpBox.SelectedItem.ToString();

            // Find the string in ListBox2.
            int index = helpBox.FindString(curItem);

            string path = "data/users/" + boardForm.username + "/help/" + curItem;
            helpPreview.Text = File.ReadAllText(path);
        }
    }
}
