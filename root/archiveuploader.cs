using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace root
{
    public partial class archiveuploader : Form
    {
        public string pathFile;
        public string codeName;
        public string title;

        public string[] parseFile(string path)
        {
            string[] parsed = new string[3];
            parsed[0] = ""; parsed[1] = ""; parsed[2] = "";
            int counter = 0;
            try
            {
                using (StreamReader reader = File.OpenText(path))
                {
                    string s = "";
                    while ((s = reader.ReadLine()) != null)
                    {
                        parsed[counter++] = s;
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }

            if (parsed[0] == "" || parsed[1] == "" || parsed[2] == "")
                throw new Exception("Invalid file.");

            if (parsed[2].Length != 10)
                throw new Exception("Invalid read date.");

            return parsed;
        }

        public DateTime parseDate(string date)
        {
            string[] ints = date.Split('.');
            DateTime parsedDate = new DateTime(Int32.Parse(ints[2]), Int32.Parse(ints[1]), Int32.Parse(ints[0]), 0, 0 ,0);
            return parsedDate;
        }

        public archiveuploader()
        {
            InitializeComponent();
        }

        private void archiveuploader_Load(object sender, EventArgs e)
        {
            string[] parsed = new string[3];
            try
            {
                parsed = parseFile(pathFile);
            }
            catch (Exception exc)
            {
                MessageBox.Show(String.Format("Exception encountered: {0}", exc));
                this.Close();
            }
            
            this.Text = parsed[0];
            this.projectsummary.Text = parsed[1];
            this.dueDateLabel.Text = "Due: " + parsed[2];

            if (File.Exists("data/users/" + boardForm.username + "/uploaded/" + codeName + ".zip"))
                this.statusLabel.Text = "Status: Uploaded";

            DateTime today = DateTime.Now;
            DateTime due = parseDate(parsed[2]);

            int dateCompareResult = DateTime.Compare(today, due); 

            if (dateCompareResult > 0)
                this.uploadButton.Enabled = false;
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            openArchivePath.ShowDialog();
        }

        private void openArchivePath_FileOk(object sender, CancelEventArgs e)
        {
            //MessageBox.Show(openArchivePath.FileName);
            string archivePath = openArchivePath.FileName;
            if (!Path.GetExtension(archivePath).Equals(".zip"))
                MessageBox.Show("File is not a zip!");
            else
            {
                if (File.Exists("data/project1.zip"))
                    File.Delete("data/project1.zip");
                File.Copy(openArchivePath.FileName, "data/project1.zip");
                this.statusLabel.Text = "Status: Uplaoded";
            }
        }
    }
}
