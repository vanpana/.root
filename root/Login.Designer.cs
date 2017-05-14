namespace root
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.usrnEdit = new System.Windows.Forms.TextBox();
            this.passEdit = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // userPicture
            // 
            this.userPicture.BackColor = System.Drawing.Color.Transparent;
            this.userPicture.Image = ((System.Drawing.Image)(resources.GetObject("userPicture.Image")));
            this.userPicture.Location = new System.Drawing.Point(188, 90);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(130, 130);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPicture.TabIndex = 0;
            this.userPicture.TabStop = false;
            // 
            // usrnEdit
            // 
            this.usrnEdit.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrnEdit.Location = new System.Drawing.Point(171, 240);
            this.usrnEdit.Name = "usrnEdit";
            this.usrnEdit.Size = new System.Drawing.Size(160, 23);
            this.usrnEdit.TabIndex = 1;
            this.usrnEdit.Text = "username";
            this.usrnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usrnEdit.Leave += new System.EventHandler(this.usrnEdit_Leave);
            this.usrnEdit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.usrnEdit_MouseDown);
            // 
            // passEdit
            // 
            this.passEdit.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passEdit.Location = new System.Drawing.Point(171, 276);
            this.passEdit.Name = "passEdit";
            this.passEdit.Size = new System.Drawing.Size(160, 23);
            this.passEdit.TabIndex = 2;
            this.passEdit.Text = "password";
            this.passEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passEdit.UseSystemPasswordChar = true;
            this.passEdit.Leave += new System.EventHandler(this.passEdit_Leave);
            this.passEdit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.passEdit_MouseDown);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginButton.BackgroundImage")));
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.ForeColor = System.Drawing.Color.Transparent;
            this.loginButton.Location = new System.Drawing.Point(298, 312);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(70, 70);
            this.loginButton.TabIndex = 3;
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.Transparent;
            this.exitButton.Location = new System.Drawing.Point(460, 460);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(40, 40);
            this.exitButton.TabIndex = 4;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(211)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(512, 512);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passEdit);
            this.Controls.Add(this.usrnEdit);
            this.Controls.Add(this.userPicture);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.TextBox usrnEdit;
        private System.Windows.Forms.TextBox passEdit;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button exitButton;
    }
}