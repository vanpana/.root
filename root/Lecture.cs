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
            this.BackgroundImage = SetImageOpacity(this.BackgroundImage, 0.30F);
        
            lectureRichTextBox.Text = content;
        }

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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists("data/help/helpboard.txt"))
            {
                FileStream f = File.Create("data/help/helpboard.txt");
                f.Close();
            }

               

            string temp = boardForm.username + ",1," + title + "," + codeName;

            using (StreamWriter appender = File.AppendText("data/help/helpboard.txt"))
            {
                appender.Write(temp + "\r\n");
            }
            
        }
    }
}
