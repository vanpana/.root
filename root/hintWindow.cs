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
    public partial class hintWindow : Form
    {
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

        string usrn, type, name, codename;
        public hintWindow(string usrn, string type, string name, string codename)
        {
            InitializeComponent();
            this.usrn = usrn;
            this.type = type;
            this.name = name;
            this.codename = codename;

            this.BackgroundImage = SetImageOpacity(this.BackgroundImage, 0.15F);
        }

        private void sendHelp_Click(object sender, EventArgs e)
        {
            string path = "data/users/" + usrn + "/help/" + codename + "-helpby-" + boardForm.username;
            File.WriteAllText(path,hintBox.Text);
            this.Close();
        }

        private void hintWindow_Load(object sender, EventArgs e)
        {
            helpUsrnLabel.Text = "Help " + usrn + " with a hint.";
        }
    }
}
