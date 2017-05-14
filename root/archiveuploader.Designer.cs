namespace root
{
    partial class archiveuploader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(archiveuploader));
            this.projectsummary = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.uploadButton = new System.Windows.Forms.Button();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.openArchivePath = new System.Windows.Forms.OpenFileDialog();
            this.projectsummaryLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.topBar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.topBar)).BeginInit();
            this.SuspendLayout();
            // 
            // projectsummary
            // 
            this.projectsummary.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectsummary.Location = new System.Drawing.Point(12, 71);
            this.projectsummary.Multiline = true;
            this.projectsummary.Name = "projectsummary";
            this.projectsummary.Size = new System.Drawing.Size(361, 266);
            this.projectsummary.TabIndex = 0;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(12, 351);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(131, 13);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Status: Not uploaded yet";
            // 
            // uploadButton
            // 
            this.uploadButton.BackColor = System.Drawing.Color.Transparent;
            this.uploadButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uploadButton.BackgroundImage")));
            this.uploadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uploadButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uploadButton.FlatAppearance.BorderSize = 0;
            this.uploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadButton.Location = new System.Drawing.Point(328, 340);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(45, 45);
            this.uploadButton.TabIndex = 3;
            this.uploadButton.UseVisualStyleBackColor = false;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dueDateLabel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDateLabel.Location = new System.Drawing.Point(12, 372);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(54, 13);
            this.dueDateLabel.TabIndex = 4;
            this.dueDateLabel.Text = "Due: date";
            // 
            // openArchivePath
            // 
            this.openArchivePath.FileOk += new System.ComponentModel.CancelEventHandler(this.openArchivePath_FileOk);
            // 
            // projectsummaryLabel
            // 
            this.projectsummaryLabel.AutoSize = true;
            this.projectsummaryLabel.BackColor = System.Drawing.Color.Transparent;
            this.projectsummaryLabel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectsummaryLabel.Location = new System.Drawing.Point(12, 55);
            this.projectsummaryLabel.Name = "projectsummaryLabel";
            this.projectsummaryLabel.Size = new System.Drawing.Size(95, 13);
            this.projectsummaryLabel.TabIndex = 1;
            this.projectsummaryLabel.Text = "Project Summary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Roboto Bk", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Your messages";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(328, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(45, 45);
            this.backButton.TabIndex = 10;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.topBar.Location = new System.Drawing.Point(-1, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(387, 45);
            this.topBar.TabIndex = 11;
            this.topBar.TabStop = false;
            // 
            // archiveuploader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(385, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.dueDateLabel);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.projectsummaryLabel);
            this.Controls.Add(this.projectsummary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "archiveuploader";
            this.Text = "project_name";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.archiveuploader_FormClosing);
            this.Load += new System.EventHandler(this.archiveuploader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.topBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox projectsummary;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.OpenFileDialog openArchivePath;
        private System.Windows.Forms.Label projectsummaryLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox topBar;
    }
}