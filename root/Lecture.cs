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
    public partial class Lecture : Form
    {
        public Lecture()
        {
            InitializeComponent();
        }
        public string pathFile;
        public string codeName;
        public string title;

        private void Lecture_Load(object sender, EventArgs e)
        {
            var content = System.IO.File.ReadAllText(pathFile);
            string[] temp = pathFile.Split('/');
            codeName = temp[temp.Length - 1];
        
            lectureRichTextBox.Text = content;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists("data/help/helpboard.txt"))
                File.Create("data/help/helpboard.txt");

            string temp = boardForm.username + ",1," + title + "," + codeName;

            StreamWriter appender = File.AppendText("data/help/helpboard.txt");
            appender.Write(temp + "\n");
            appender.Close();
        }
    }
}
