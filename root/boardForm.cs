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
    public partial class boardForm : Form
    {
        string[,] help = new string[20,4];
        public static string username;

        public static string[] filePaths;
        public static string[] fileTitles;


        string[,] parsefile(string path)
        {
            string[,] parsed = new string[20, 4];

            for (int j = 0; j < 20; j++)
                parsed[j, 0] = "";

            int counter = 0;
            try
            {   // Open the text file using a stream reader.
                StreamReader file = new StreamReader(path);
                string[] split;
                while ((split = file.ReadLine().Split(',')) != null)
                {
                    for (int i = 0; i < 4; i++)
                        parsed[counter, i] = split[i];
                    counter++;
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

        string helpText(string usrn, string helptype, string name)
        {
            if (helptype == "1")
                return name + ", lecture, posted by " + usrn;
            return name + ", project, posted by " + usrn;
        }

        public boardForm(string username)
        {
            InitializeComponent();
            boardForm.username = username;

            help = parsefile("data/help/helpboard.txt");

            for (int i = 0; i < 10; i++)
                if (help[i, 0] != username && help[i,0] != "")
                    helpBox.Items.Add(helpText(help[i,0], help[i,1], help[i,2]));
        }

        private void boardForm_Load(object sender, EventArgs e)
        {

        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            string curItem = helpBox.SelectedItem.ToString();

            // Find the string in ListBox2.
            int index = helpBox.FindString(curItem);

            hintWindow hw = new hintWindow(help[index, 0], help[index, 1], help[index, 2], help[index, 3]);
            hw.Show();
        }

        private void yourHelpsButton_Click(object sender, EventArgs e)
        {
            filePaths = Directory.GetFiles("data/users/" + username + "/help/");
            if (filePaths.Length == 0)
                MessageBox.Show("No help yet!");
            else
            {
                helpFeedback hf = new helpFeedback();
                fileTitles = new string[filePaths.Length];

                for (int i = 0; i < filePaths.Length; i++)
                {
                    string[] temp = filePaths[i].Split('/');
                    boardForm.fileTitles[i] = temp[temp.Length - 1];
                    MessageBox.Show(fileTitles[i].ToString());
                    hf.helpBox.Items.Add(fileTitles[i]);
                }

                hf.Show();
            }
        }

        private void graphButton_Click(object sender, EventArgs e)
        {
            string path = "data/users/" + username + "/" + username + ".txt";
            if(!File.Exists(path))
            {
                FileStream f = File.Create(path);
                f.Close();
                Tree t = new Tree();
                t.Load("data/keys/Defaul.txt");
                t.Show();
                t.Save(path);
                
                
            }
            else
            {
                //Tree t = new Tree(new Node(200, 10, -1, null, new List<Node>()));
                Tree t = new Tree(username);
                t.Load(path);
                t.Show();
            }
        }
    }
}
