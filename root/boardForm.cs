using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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

        public Image SetImageOpacity(Image image, float opacity)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity;
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default,
                                                  ColorAdjustType.Bitmap);
                g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height),
                                   0, 0, image.Width, image.Height,
                                   GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }

        string[,] parsefile(string path)
        {
            string[,] parsed = new string[20, 4];

            for (int j = 0; j < 20; j++)
                parsed[j, 0] = "";

            int counter = 0;
            try
            {   // Open the text file using a stream reader.

                FileInfo fi1 = new FileInfo("data/help/helpboard.txt");
                MessageBox.Show(Form1.IsFileLocked(fi1).ToString());

                string[] split;
                using (StreamReader sr = new StreamReader("data/help/helpboard.txt"))
                {
                    while ((split = sr.ReadLine().Split(',')) != null)
                    {
                      
                        for (int i = 0; i < 4; i++)
                            parsed[counter, i] = split[i];
                        counter++;
                        MessageBox.Show(counter.ToString());
                    }
                }

                MessageBox.Show(Form1.IsFileLocked(fi1).ToString());
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

            topBar.Image = SetImageOpacity(topBar.Image, 0.15F);
            sideBar.Image = SetImageOpacity(sideBar.Image, 0.15F);

            boardForm.username = username;


            if (new FileInfo("data/help/helpboard.txt").Length != 0)
            {
                help = parsefile("data/help/helpboard.txt");

                for (int i = 0; i < 10; i++)
                    if (help[i, 0] != username && help[i, 0] != "")
                        helpBox.Items.Add(helpText(help[i, 0], help[i, 1], help[i, 2]));
            }
            
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
                helpFeedback hf = new helpFeedback(this);
                fileTitles = new string[filePaths.Length];

                for (int i = 0; i < filePaths.Length; i++)
                {
                    string[] temp = filePaths[i].Split('/');
                    boardForm.fileTitles[i] = temp[temp.Length - 1];
                    //MessageBox.Show(fileTitles[i].ToString());
                    hf.helpBox.Items.Add(fileTitles[i]);
                }

                hf.Show();
                this.Hide();
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
                Tree.bf = this;
                t.Load("data/keys/Defaul.txt");
                t.Show();
                t.Save(path);
                this.Hide();
                
                
            }
            else
            {
                //Tree t = new Tree(new Node(200, 10, -1, null, new List<Node>()));
                Tree t = new Tree(username);
                Tree.bf = this;
                t.Load(path);
                t.Show();
                this.Hide();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }
    }
}
