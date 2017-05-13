namespace root
{
    partial class NewNode
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
            this.typeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.browseLabel = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.newNodeOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.addNewButton = new System.Windows.Forms.Button();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.codeNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // typeCheckedListBox
            // 
            this.typeCheckedListBox.FormattingEnabled = true;
            this.typeCheckedListBox.Items.AddRange(new object[] {
            "Lecture",
            "Project"});
            this.typeCheckedListBox.Location = new System.Drawing.Point(12, 12);
            this.typeCheckedListBox.Name = "typeCheckedListBox";
            this.typeCheckedListBox.Size = new System.Drawing.Size(82, 34);
            this.typeCheckedListBox.TabIndex = 0;
            this.typeCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.typeCheckedListBox_SelectedIndexChanged);
            // 
            // browseLabel
            // 
            this.browseLabel.AutoSize = true;
            this.browseLabel.Location = new System.Drawing.Point(142, 154);
            this.browseLabel.Name = "browseLabel";
            this.browseLabel.Size = new System.Drawing.Size(62, 13);
            this.browseLabel.TabIndex = 1;
            this.browseLabel.Text = "Select a file";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(225, 149);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // addNewButton
            // 
            this.addNewButton.Location = new System.Drawing.Point(404, 178);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(75, 23);
            this.addNewButton.TabIndex = 3;
            this.addNewButton.Text = "Add";
            this.addNewButton.UseVisualStyleBackColor = true;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(145, 79);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(245, 20);
            this.fileNameTextBox.TabIndex = 4;
            this.fileNameTextBox.Click += new System.EventHandler(this.fileNameTextBox_Click);
            // 
            // codeNameTextBox
            // 
            this.codeNameTextBox.Location = new System.Drawing.Point(145, 123);
            this.codeNameTextBox.Name = "codeNameTextBox";
            this.codeNameTextBox.Size = new System.Drawing.Size(245, 20);
            this.codeNameTextBox.TabIndex = 5;
            this.codeNameTextBox.Text = "Insert code name";
            this.codeNameTextBox.Click += new System.EventHandler(this.codeNameTextBox_Click);
            // 
            // NewNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 208);
            this.Controls.Add(this.codeNameTextBox);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.browseLabel);
            this.Controls.Add(this.typeCheckedListBox);
            this.Name = "NewNode";
            this.Text = "NewNode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox typeCheckedListBox;
        private System.Windows.Forms.Label browseLabel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.OpenFileDialog newNodeOpenFileDialog;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.TextBox codeNameTextBox;
    }
}