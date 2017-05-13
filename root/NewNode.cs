using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace root
{
    public partial class NewNode : Form
    {
        int key;

        public NewNode()
        {
            InitializeComponent();
        }

        public NewNode(int k)
        {
            InitializeComponent();
            key = k;
            //MessageBox.Show(key.ToString());
        }

        private void browseButton_Click(object sender, EventArgs e)
        {

            DialogResult n = newNodeOpenFileDialog.ShowDialog();
            string path = newNodeOpenFileDialog.FileName;
            int i;
            for (i = path.Length - 1; i > 0; i--)
                if (path[i] == '\\' || path[i] == '/')
                    break;
            string fileName;
            if (path == "")
                fileName = "Select a file";
            else
                fileName = path.Substring(i + 1);
            this.fileName = fileName;
            this.path = path;
            browseLabel.Text = Convert.ToString(fileName);
            
        }

        private void typeCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeCheckedListBox.SelectedIndex == 0)
            {
                fileNameTextBox.Text = "Insert Lecure name";
                typeCheckedListBox.SetItemChecked(0, true);
                typeCheckedListBox.SetItemChecked(1, false);
                this.type = "lecture";
            }
            if (typeCheckedListBox.SelectedIndex == 1)
            {
                fileNameTextBox.Text = "Insert Project name";
                typeCheckedListBox.SetItemChecked(0, false);
                typeCheckedListBox.SetItemChecked(1, true);
                this.type = "project";
            }
            
    
        }

        private void fileNameTextBox_Click(object sender, EventArgs e)
        {
            fileNameTextBox.Text = "";
        }

        public string fileName;
        public string type;
        public string path;
        public string fileNameText;
        public string codeName;

        private void addNewButton_Click(object sender, EventArgs e)
        {
            if (path.Substring(path.Length - 4) == ".txt")
            {
                codeName = codeNameTextBox.Text;
                switch (type)
                {
                    case "lecture":
                        if (System.IO.File.Exists("data/lecture/" + codeName + ".txt"))
                            System.IO.File.Delete("data/lecture/" + codeName + ".txt");
                        System.IO.File.Copy(path, "data/lecture/" + codeName + ".txt");
                        break;
                    case "project":
                        if (System.IO.File.Exists("data/project/" + codeName + ".txt"))
                            System.IO.File.Delete("data/project/" + codeName + ".txt");
                        System.IO.File.Copy(path, "data/project/" + codeName + ".txt");
                        break;
                }
                if(!Directory.Exists("data/users/" + boardForm.username + "/keys"))
                {
                    Directory.CreateDirectory("data/users/" + boardForm.username + "/keys");
                }
                string fpath = "data/users/" + boardForm.username + "/keys/" + key.ToString() + ".txt";
                if (!File.Exists(fpath))
                {
                    FileStream s = File.Create(fpath);
                    s.Close();
                }
                StreamWriter wr = new StreamWriter(fpath);
                wr.Write(fileNameTextBox.Text + "\n");
                wr.Write(codeNameTextBox.Text + "\n");
                if(typeCheckedListBox.SelectedIndex == 1)
                {
                    wr.Write(textBox1.Text + "\n");
                }
                wr.Close();
                // TODO
            }
            else
                MessageBox.Show("Try a text file!"); 
            
        }

        private void codeNameTextBox_Click(object sender, EventArgs e)
        {
            codeNameTextBox.Text = "";
        }

        private void NewNode_Load(object sender, EventArgs e)
        {

        }
    }
}
