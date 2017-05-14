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
    public partial class Form1 : Form
    {
        public static Boolean IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                //Don't change FileAccess to ReadWrite, 
                //because if a file is in readOnly, it fails.
                stream = file.Open
                (
                    FileMode.Open,
                    FileAccess.Read,
                    FileShare.None
                );
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            //file is not locked
            return false;
        }
        public Form1()
        {
            InitializeComponent();
            //this.BackColor = Color.Transparent;
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;

            if (!Directory.Exists("data"))
                Directory.CreateDirectory("data");

            if (!Directory.Exists("data/help"))
                Directory.CreateDirectory("data/help");

            if (!Directory.Exists("data/users"))
                Directory.CreateDirectory("data/users");

            if (!Directory.Exists("data/lecture"))
                Directory.CreateDirectory("data/lecture");

            if (!Directory.Exists("data/project"))
                Directory.CreateDirectory("data/project");

            if (!Directory.Exists("data/keys"))
                Directory.CreateDirectory("data/keys");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void lectureButton_Click(object sender, EventArgs e)
        {
            Tree t = new Tree(new Node(160,10,-1,null,new List<Node>()));
            t.Show();
        }
    }
}
