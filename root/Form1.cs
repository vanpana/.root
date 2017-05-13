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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lecture l = new Lecture();
            l.ShowDialog();
            this.Show();
        }
    }
}
