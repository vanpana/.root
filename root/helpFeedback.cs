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
    public partial class helpFeedback : Form
    {
        boardForm bf;

        public helpFeedback(boardForm bf)
        {
            InitializeComponent();
            this.BackgroundImage = SetImageOpacity(this.BackgroundImage, 0.15F);
            this.bf = bf;

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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = helpBox.SelectedItem.ToString();

            // Find the string in ListBox2.
            int index = helpBox.FindString(curItem);

            string path = "data/users/" + boardForm.username + "/help/" + curItem;
            helpPreview.Text = File.ReadAllText(path);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            bf.Show();
            
        }
    }
}
