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
    public partial class PreviewWindow : Form
    {
        public PreviewWindow()
        {
            InitializeComponent();
            changeName();
            changeStatus();
            changeDescription();
        }

        public void changeName()
        {
            label2.Text = "Operating Systems";
        }

        public void changeStatus()
        {
            label4.Text = "Accessible";
        }

        public void changeDescription()
        {
            textBox1.Text = "Learn more about operating systems.\r\n\r\n\r\n\r\n\r\n\r\nThis is a test.\r\n\r\n\r\n\r\n\r\n\r\nThis is a test.";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
