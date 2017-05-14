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
    public partial class PreviewWindow : Form
    {
        private Node nod;
        string filePath;
        string codeName;
        string name;
        string type;
        bool ok;

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
            //MessageBox.Show(parsed[1]);
            type = "project";
            if (parsed[2] == "none")
                type = "lecture";

            changeName(name);
            changeStatus();
            changeDescription();
            this.BackgroundImage = SetImageOpacity(this.BackgroundImage, 0.15F);
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
            this.Close();
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
                    l.title = name;
                    l.Show();
                    this.Close();
                }

                else if (type == "project")
                {
                 
                    archiveuploader au = new archiveuploader();
                    au.codeName = codeName;
                    au.pathFile = "data/keys/" + nod.getKey().ToString() + ".txt";
                    //au.pathFile = "data/" + type + "/" + codeName + ".txt";
                    //MessageBox.Show(res.ToString());
                    au.title = name;
                    this.Hide();
                    if (au.ShowDialog() == DialogResult.OK)
                    {
                        
                        //MessageBox.Show("second ok");
                        ok = true;
                    }
                    this.Show();
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
