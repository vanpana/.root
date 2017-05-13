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
    public partial class Lecture : Form
    {
        public Lecture()
        {
            InitializeComponent();
        }
        public string pathFile = "data/project1.txt";

        private void Lecture_Load(object sender, EventArgs e)
        {
            var content = System.IO.File.ReadAllText(pathFile);
            lectureRichTextBox.Text = content;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
