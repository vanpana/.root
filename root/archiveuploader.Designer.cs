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
            this.projectsummary.BackColor = System.Drawing.SystemColors.Control;
            this.projectsummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.projectsummary.Location = new System.Drawing.Point(16, 27);
            this.projectsummary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.projectsummary.Multiline = true;
            this.projectsummary.Name = "projectsummary";
            this.projectsummary.ReadOnly = true;
            this.projectsummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.projectsummary.Size = new System.Drawing.Size(480, 387);
            this.projectsummary.TabIndex = 0;
            this.projectsummary.TabStop = false;
            // 
            // projectsummaryLabel
            // 
            this.projectsummaryLabel.AutoSize = true;
            this.projectsummaryLabel.Location = new System.Drawing.Point(16, 7);
            this.projectsummaryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.projectsummaryLabel.Name = "projectsummaryLabel";
            this.projectsummaryLabel.Size = new System.Drawing.Size(115, 17);
            this.projectsummaryLabel.TabIndex = 1;
            this.projectsummaryLabel.Text = "Project Summary";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(16, 432);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(164, 17);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Status: Not uploaded yet";
            // 
            // uploadButton
            // 
            this.uploadButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uploadButton.Location = new System.Drawing.Point(397, 432);
            this.uploadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(100, 28);
            this.uploadButton.TabIndex = 3;
            this.uploadButton.Text = "Upload!";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Location = new System.Drawing.Point(16, 458);
            this.dueDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(70, 17);
            this.dueDateLabel.TabIndex = 4;
            this.dueDateLabel.Text = "Due: date";
            // 
            // openArchivePath
            // 
            this.openArchivePath.FileOk += new System.ComponentModel.CancelEventHandler(this.openArchivePath_FileOk);
            // 
            // archiveuploader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 485);
            this.Controls.Add(this.dueDateLabel);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.projectsummaryLabel);
            this.Controls.Add(this.projectsummary);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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