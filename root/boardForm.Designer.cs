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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(boardForm));
            this.sideBar = new System.Windows.Forms.PictureBox();
            this.topBar = new System.Windows.Forms.PictureBox();
            this.helpBox = new System.Windows.Forms.ListBox();
            this.graphButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.yourHelpsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sideBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBar)).BeginInit();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.sideBar.Image = ((System.Drawing.Image)(resources.GetObject("sideBar.Image")));
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(45, 306);
            this.sideBar.TabIndex = 0;
            this.sideBar.TabStop = false;
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.topBar.Image = ((System.Drawing.Image)(resources.GetObject("topBar.Image")));
            this.topBar.Location = new System.Drawing.Point(40, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(455, 45);
            this.topBar.TabIndex = 1;
            this.topBar.TabStop = false;
            // 
            // helpBox
            // 
            this.helpBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(211)))));
            this.helpBox.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBox.FormattingEnabled = true;
            this.helpBox.ItemHeight = 15;
            this.helpBox.Location = new System.Drawing.Point(43, 45);
            this.helpBox.Name = "helpBox";
            this.helpBox.Size = new System.Drawing.Size(449, 244);
            this.helpBox.TabIndex = 2;
            // 
            // graphButton
            // 
            this.graphButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.graphButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("graphButton.BackgroundImage")));
            this.graphButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.graphButton.FlatAppearance.BorderSize = 0;
            this.graphButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.graphButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.graphButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphButton.Location = new System.Drawing.Point(1, 1);
            this.graphButton.Name = "graphButton";
            this.graphButton.Size = new System.Drawing.Size(45, 45);
            this.graphButton.TabIndex = 3;
            this.graphButton.UseVisualStyleBackColor = false;
            this.graphButton.Click += new System.EventHandler(this.graphButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(1, 244);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(45, 45);
            this.exitButton.TabIndex = 4;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.helpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpButton.BackgroundImage")));
            this.helpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.helpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Location = new System.Drawing.Point(438, 1);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(45, 45);
            this.helpButton.TabIndex = 5;
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // yourHelpsButton
            // 
            this.yourHelpsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.yourHelpsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yourHelpsButton.BackgroundImage")));
            this.yourHelpsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yourHelpsButton.FlatAppearance.BorderSize = 0;
            this.yourHelpsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.yourHelpsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.yourHelpsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yourHelpsButton.ForeColor = System.Drawing.Color.Transparent;
            this.yourHelpsButton.Location = new System.Drawing.Point(361, 1);
            this.yourHelpsButton.Name = "yourHelpsButton";
            this.yourHelpsButton.Size = new System.Drawing.Size(45, 45);
            this.yourHelpsButton.TabIndex = 6;
            this.yourHelpsButton.UseVisualStyleBackColor = false;
            this.yourHelpsButton.Click += new System.EventHandler(this.yourHelpsButton_Click);
            // 
            // boardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 287);
            this.ControlBox = false;
            this.Controls.Add(this.yourHelpsButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.graphButton);
            this.Controls.Add(this.helpBox);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.sideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "boardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button yourHelpsButton;
    }
}