namespace root
{
    partial class hintWindow
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
            this.helpUsrnLabel = new System.Windows.Forms.Label();
            this.hintBox = new System.Windows.Forms.TextBox();
            this.sendHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helpUsrnLabel
            // 
            this.helpUsrnLabel.AutoSize = true;
            this.helpUsrnLabel.Location = new System.Drawing.Point(12, 9);
            this.helpUsrnLabel.Name = "helpUsrnLabel";
            this.helpUsrnLabel.Size = new System.Drawing.Size(123, 13);
            this.helpUsrnLabel.TabIndex = 0;
            this.helpUsrnLabel.Text = "Help teopaius with a hint";
            // 
            // hintBox
            // 
            this.hintBox.Location = new System.Drawing.Point(15, 34);
            this.hintBox.Multiline = true;
            this.hintBox.Name = "hintBox";
            this.hintBox.Size = new System.Drawing.Size(257, 190);
            this.hintBox.TabIndex = 1;
            // 
            // sendHelp
            // 
            this.sendHelp.Location = new System.Drawing.Point(197, 230);
            this.sendHelp.Name = "sendHelp";
            this.sendHelp.Size = new System.Drawing.Size(75, 23);
            this.sendHelp.TabIndex = 2;
            this.sendHelp.Text = "button1";
            this.sendHelp.UseVisualStyleBackColor = true;
            this.sendHelp.Click += new System.EventHandler(this.sendHelp_Click);
            // 
            // hintWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.sendHelp);
            this.Controls.Add(this.hintBox);
            this.Controls.Add(this.helpUsrnLabel);
            this.Name = "hintWindow";
            this.Text = "hintWindow";
            this.Load += new System.EventHandler(this.hintWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helpUsrnLabel;
        private System.Windows.Forms.TextBox hintBox;
        private System.Windows.Forms.Button sendHelp;
    }
}