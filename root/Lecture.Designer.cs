namespace root
{
    partial class Lecture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lecture));
            this.backButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.lectureRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(709, 473);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(45, 45);
            this.backButton.TabIndex = 0;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.Transparent;
            this.helpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpButton.BackgroundImage")));
            this.helpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Location = new System.Drawing.Point(709, 422);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(45, 45);
            this.helpButton.TabIndex = 1;
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // lectureRichTextBox
            // 
            this.lectureRichTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lectureRichTextBox.Location = new System.Drawing.Point(32, 24);
            this.lectureRichTextBox.Name = "lectureRichTextBox";
            this.lectureRichTextBox.ReadOnly = true;
            this.lectureRichTextBox.Size = new System.Drawing.Size(573, 494);
            this.lectureRichTextBox.TabIndex = 2;
            this.lectureRichTextBox.Text = "";
            // 
            // Lecture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(211)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(766, 545);
            this.ControlBox = false;
            this.Controls.Add(this.lectureRichTextBox);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.backButton);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lecture";
            this.Text = "Lecture";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Lecture_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.RichTextBox lectureRichTextBox;
    }
}