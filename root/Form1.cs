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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tree t = new Tree(new Node(160, 10, -1, null, new List<Node>(100)));
            // t.Show();
            PreviewWindow p = new PreviewWindow();
            p.Show();
        }
    }
}
