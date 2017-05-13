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
    public partial class PreviewWindow : Form
    {
        private Node nod;
        string filePath;
        string codeName;
        string name;
        string type;
        bool ok;

        public PreviewWindow()
        {
            InitializeComponent();
            changeName(name);
            changeStatus();
            changeDescription();
        }

        string[] parseFile(string path)
        {
            string[] parsed = new string[3];
            parsed[2] = "none";
            int counter = 0;
            try
            {   // Open the text file using a stream reader.
                StreamReader file = new StreamReader(path);
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    parsed[counter++] = line;
                }
                file.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return parsed;
        }

        public PreviewWindow(Node n)
        {
            nod = n;
            InitializeComponent();
            
            filePath = "data/keys/" + n.getKey().ToString() + ".txt";
            if(!File.Exists(filePath))
            {
                filePath = "data/users/" + boardForm.username + "/keys/" + n.getKey().ToString() + ".txt";
            }
            string[] parsed = parseFile(filePath);

            name = parsed[0];
            codeName = parsed[1];
            type = "project";
            if (parsed[2] == "none")
                type = "lecture";

            changeName(name);
            changeStatus();
            changeDescription();
        }

        public void changeName(string name)
        {
            label2.Text = name;
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
            string descriptionContainerPath;
            descriptionContainerPath = "data/" + type + "/" + codeName + ".txt";
            textBox1.Text = File.ReadAllText(descriptionContainerPath);
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

        private void runForm_Click(object sender, EventArgs e)
        {
            if (nod.getState() == (int)States.UNAVAILABLE)
            {
                MessageBox.Show("this node is not available yet");
            }
            else
            {
                if (type == "lecture")
                {
                    Lecture l = new Lecture();
                    l.codeName = codeName;
                    l.pathFile = "data/" + type + "/" + codeName + ".txt";
                    l.Show();
                }

                else if (type == "project")
                {
                    archiveuploader au = new archiveuploader();
                    au.codeName = codeName;
                    au.pathFile = "data/keys/" + nod.getKey().ToString() + ".txt";
                    //au.pathFile = "data/" + type + "/" + codeName + ".txt";
                    DialogResult res = au.ShowDialog();
                    //MessageBox.Show(res.ToString());
                    if (au.ShowDialog() == DialogResult.OK)
                    {
                        //MessageBox.Show("second ok");
                        ok = true;
                    }
                }
            }
        }

        private void PreviewWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ok)
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;
        }
    }
}
