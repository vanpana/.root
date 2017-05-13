namespace root
{
    partial class helpFeedback
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
            this.helpBox = new System.Windows.Forms.ListBox();
            this.helpPreview = new System.Windows.Forms.TextBox();
            this.likeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helpBox
            // 
            this.helpBox.FormattingEnabled = true;
            this.helpBox.Location = new System.Drawing.Point(0, 12);
            this.helpBox.Name = "helpBox";
            this.helpBox.Size = new System.Drawing.Size(379, 95);
            this.helpBox.TabIndex = 2;
            this.helpBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // helpPreview
            // 
            this.helpPreview.Location = new System.Drawing.Point(0, 113);
            this.helpPreview.Multiline = true;
            this.helpPreview.Name = "helpPreview";
            this.helpPreview.Size = new System.Drawing.Size(379, 119);
            this.helpPreview.TabIndex = 4;
            // 
            // likeButton
            // 
            this.likeButton.Location = new System.Drawing.Point(290, 238);
            this.likeButton.Name = "likeButton";
            this.likeButton.Size = new System.Drawing.Size(75, 23);
            this.likeButton.TabIndex = 5;
            this.likeButton.Text = "button1";
            this.likeButton.UseVisualStyleBackColor = true;
            // 
            // helpFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 264);
            this.Controls.Add(this.likeButton);
            this.Controls.Add(this.helpPreview);
            this.Controls.Add(this.helpBox);
            this.Name = "helpFeedback";
            this.Text = "helpFeedback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ListBox helpBox;
        private System.Windows.Forms.TextBox helpPreview;
        private System.Windows.Forms.Button likeButton;
    }
}