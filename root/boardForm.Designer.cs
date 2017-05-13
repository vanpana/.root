namespace root
{
    partial class boardForm
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
            this.sideBar = new System.Windows.Forms.PictureBox();
            this.topBar = new System.Windows.Forms.PictureBox();
            this.helpBox = new System.Windows.Forms.ListBox();
            this.graphButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sideBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBar)).BeginInit();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.DarkCyan;
            this.sideBar.Location = new System.Drawing.Point(1, 1);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(45, 306);
            this.sideBar.TabIndex = 0;
            this.sideBar.TabStop = false;
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.DarkCyan;
            this.topBar.Location = new System.Drawing.Point(41, 1);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(384, 45);
            this.topBar.TabIndex = 1;
            this.topBar.TabStop = false;
            // 
            // helpBox
            // 
            this.helpBox.FormattingEnabled = true;
            this.helpBox.Location = new System.Drawing.Point(43, 45);
            this.helpBox.Name = "helpBox";
            this.helpBox.Size = new System.Drawing.Size(380, 251);
            this.helpBox.TabIndex = 2;
            // 
            // graphButton
            // 
            this.graphButton.Location = new System.Drawing.Point(1, 1);
            this.graphButton.Name = "graphButton";
            this.graphButton.Size = new System.Drawing.Size(45, 45);
            this.graphButton.TabIndex = 3;
            this.graphButton.Text = "button1";
            this.graphButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1, 251);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(45, 45);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "button1";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(378, 1);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(45, 45);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "button1";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // boardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 296);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.graphButton);
            this.Controls.Add(this.helpBox);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.sideBar);
            this.Name = "boardForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.boardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sideBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox sideBar;
        private System.Windows.Forms.PictureBox topBar;
        private System.Windows.Forms.ListBox helpBox;
        private System.Windows.Forms.Button graphButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button helpButton;
    }
}