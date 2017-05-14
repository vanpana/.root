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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(helpFeedback));
            this.helpBox = new System.Windows.Forms.ListBox();
            this.helpPreview = new System.Windows.Forms.TextBox();
            this.likeButton = new System.Windows.Forms.Button();
            this.unlikeButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helpBox
            // 
            this.helpBox.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBox.FormattingEnabled = true;
            this.helpBox.ItemHeight = 15;
            this.helpBox.Location = new System.Drawing.Point(0, 1);
            this.helpBox.Name = "helpBox";
            this.helpBox.Size = new System.Drawing.Size(379, 94);
            this.helpBox.TabIndex = 2;
            this.helpBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // helpPreview
            // 
            this.helpPreview.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpPreview.Location = new System.Drawing.Point(0, 104);
            this.helpPreview.Multiline = true;
            this.helpPreview.Name = "helpPreview";
            this.helpPreview.Size = new System.Drawing.Size(379, 119);
            this.helpPreview.TabIndex = 4;
            // 
            // likeButton
            // 
            this.likeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("likeButton.BackgroundImage")));
            this.likeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.likeButton.FlatAppearance.BorderSize = 0;
            this.likeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.likeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.likeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.likeButton.Location = new System.Drawing.Point(284, 222);
            this.likeButton.Name = "likeButton";
            this.likeButton.Size = new System.Drawing.Size(40, 40);
            this.likeButton.TabIndex = 5;
            this.likeButton.UseVisualStyleBackColor = true;
            // 
            // unlikeButton
            // 
            this.unlikeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("unlikeButton.BackgroundImage")));
            this.unlikeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.unlikeButton.FlatAppearance.BorderSize = 0;
            this.unlikeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.unlikeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.unlikeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unlikeButton.Location = new System.Drawing.Point(330, 222);
            this.unlikeButton.Name = "unlikeButton";
            this.unlikeButton.Size = new System.Drawing.Size(40, 40);
            this.unlikeButton.TabIndex = 6;
            this.unlikeButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(12, 222);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(40, 40);
            this.backButton.TabIndex = 7;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // helpFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(100)))), ((int)(((byte)(30)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(377, 264);
            this.ControlBox = false;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.unlikeButton);
            this.Controls.Add(this.likeButton);
            this.Controls.Add(this.helpPreview);
            this.Controls.Add(this.helpBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "helpFeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "helpFeedback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ListBox helpBox;
        private System.Windows.Forms.TextBox helpPreview;
        private System.Windows.Forms.Button likeButton;
        private System.Windows.Forms.Button unlikeButton;
        private System.Windows.Forms.Button backButton;
    }
}