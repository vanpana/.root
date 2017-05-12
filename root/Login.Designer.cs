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
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // userPicture
            // 
            this.userPicture.Image = ((System.Drawing.Image)(resources.GetObject("userPicture.Image")));
            this.userPicture.Location = new System.Drawing.Point(101, 31);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(75, 75);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPicture.TabIndex = 0;
            this.userPicture.TabStop = false;
            // 
            // usrnEdit
            // 
            this.usrnEdit.Location = new System.Drawing.Point(86, 121);
            this.usrnEdit.Name = "usrnEdit";
            this.usrnEdit.Size = new System.Drawing.Size(100, 20);
            this.usrnEdit.TabIndex = 1;
            this.usrnEdit.Text = "username";
            this.usrnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usrnEdit.Leave += new System.EventHandler(this.usrnEdit_Leave);
            this.usrnEdit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.usrnEdit_MouseDown);
            // 
            // passEdit
            // 
            this.passEdit.Location = new System.Drawing.Point(86, 147);
            this.passEdit.Name = "passEdit";
            this.passEdit.Size = new System.Drawing.Size(100, 20);
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
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.ForeColor = System.Drawing.Color.Transparent;
            this.loginButton.Location = new System.Drawing.Point(159, 173);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(40, 40);
            this.loginButton.TabIndex = 3;
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passEdit);
            this.Controls.Add(this.usrnEdit);
            this.Controls.Add(this.userPicture);
            this.Name = "Login";
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
    }
}