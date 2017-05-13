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
            this.projectsummary = new System.Windows.Forms.TextBox();
            this.projectsummaryLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.uploadButton = new System.Windows.Forms.Button();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.openArchivePath = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // projectsummary
            // 
            this.projectsummary.Location = new System.Drawing.Point(12, 22);
            this.projectsummary.Multiline = true;
            this.projectsummary.Name = "projectsummary";
            this.projectsummary.Size = new System.Drawing.Size(361, 315);
            this.projectsummary.TabIndex = 0;
            // 
            // projectsummaryLabel
            // 
            this.projectsummaryLabel.AutoSize = true;
            this.projectsummaryLabel.Location = new System.Drawing.Point(12, 6);
            this.projectsummaryLabel.Name = "projectsummaryLabel";
            this.projectsummaryLabel.Size = new System.Drawing.Size(86, 13);
            this.projectsummaryLabel.TabIndex = 1;
            this.projectsummaryLabel.Text = "Project Summary";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 351);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(124, 13);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Status: Not uploaded yet";
            // 
            // uploadButton
            // 
            this.uploadButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uploadButton.Location = new System.Drawing.Point(298, 351);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(75, 23);
            this.uploadButton.TabIndex = 3;
            this.uploadButton.Text = "Upload!";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
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
            // archiveuploader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 394);
            this.Controls.Add(this.dueDateLabel);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.projectsummaryLabel);
            this.Controls.Add(this.projectsummary);
            this.Name = "archiveuploader";
            this.Text = "project_name";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.archiveuploader_FormClosing);
            this.Load += new System.EventHandler(this.archiveuploader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox projectsummary;
        private System.Windows.Forms.Label projectsummaryLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.OpenFileDialog openArchivePath;
    }
}