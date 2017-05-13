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
            this.backButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.lectureRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(34, 378);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(34, 51);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 23);
            this.helpButton.TabIndex = 1;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            // 
            // lectureRichTextBox
            // 
            this.lectureRichTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lectureRichTextBox.Location = new System.Drawing.Point(151, 34);
            this.lectureRichTextBox.Name = "lectureRichTextBox";
            this.lectureRichTextBox.ReadOnly = true;
            this.lectureRichTextBox.Size = new System.Drawing.Size(454, 377);
            this.lectureRichTextBox.TabIndex = 2;
            this.lectureRichTextBox.Text = "";
            // 
            // Lecture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 472);
            this.Controls.Add(this.lectureRichTextBox);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.backButton);
            this.Name = "Lecture";
            this.Text = "Lecture";
            this.Load += new System.EventHandler(this.Lecture_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.RichTextBox lectureRichTextBox;
    }
}