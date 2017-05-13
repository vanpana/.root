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
        private Node nod;
        public PreviewWindow()
        {
            InitializeComponent();
            changeName();
            changeStatus();
            changeDescription();
        }

        public PreviewWindow(Node n)
        {
            nod = n;
            InitializeComponent();
            changeName();
            changeStatus();
            changeDescription();
        }

        public void changeName()
        {
            label2.Text = nod.getKey().ToString();
        }

        public void changeStatus()
        {
            int stat = nod.getState();
            switch(stat)
            {
                case (int)States.AVAILABLE:
                    label4.Text = "Available";
                    break;

                case (int)States.UNAVAILABLE:
                    label4.Text = "Unavailable";
                    break;

                case (int)States.ON_PROGRES:
                    label4.Text = "On progress";
                    break;
            }

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
