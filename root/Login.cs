using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace root
{
    public partial class Login : Form
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

        public Login()
        {
            InitializeComponent();
            this.BackgroundImage = SetImageOpacity(this.BackgroundImage, 0.15F);
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void usrnEdit_MouseDown(object sender, MouseEventArgs e)
        {
            if (usrnEdit.Text == "username")
                usrnEdit.Text = "";
        }

        private void usrnEdit_Leave(object sender, EventArgs e)
        {
            if (usrnEdit.Text == "")
                usrnEdit.Text = "username";
        }

        private void passEdit_MouseDown(object sender, MouseEventArgs e)
        {
            if (passEdit.Text == "password")
                passEdit.Text = "";
        }

        private void passEdit_Leave(object sender, EventArgs e)
        {
            if (passEdit.Text == "")
                passEdit.Text = "password";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usrnEdit.Text != "" && passEdit.Text != "")
            {
                boardForm bf = new boardForm(usrnEdit.Text);
                if (!Directory.Exists("data/users/" + usrnEdit.Text))
                {
                    Directory.CreateDirectory("data/users/" + usrnEdit.Text);
                    Directory.CreateDirectory("data/users/" + usrnEdit.Text + "/help");
                    Directory.CreateDirectory("data/users/" + usrnEdit.Text + "/uploaded");
                }
                    
                bf.Show();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
