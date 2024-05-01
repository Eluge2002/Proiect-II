namespace proiect
{
    partial class start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(start));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.User = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Parola = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.loginimg = new System.Windows.Forms.PictureBox();
            this.signupimg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signupimg)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(71, 278);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 33);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(107, 289);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(159, 22);
            this.User.TabIndex = 1;
            this.User.TextChanged += new System.EventHandler(this.User_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(71, 317);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 36);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Parola
            // 
            this.Parola.Location = new System.Drawing.Point(107, 331);
            this.Parola.Name = "Parola";
            this.Parola.PasswordChar = '*';
            this.Parola.Size = new System.Drawing.Size(159, 22);
            this.Parola.TabIndex = 3;
            this.Parola.TextChanged += new System.EventHandler(this.Parola_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(326, 217);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // loginimg
            // 
            this.loginimg.BackColor = System.Drawing.Color.Transparent;
            this.loginimg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginimg.BackgroundImage")));
            this.loginimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loginimg.Location = new System.Drawing.Point(107, 359);
            this.loginimg.Name = "loginimg";
            this.loginimg.Size = new System.Drawing.Size(71, 32);
            this.loginimg.TabIndex = 7;
            this.loginimg.TabStop = false;
            this.loginimg.Click += new System.EventHandler(this.loginimg_Click);
            // 
            // signupimg
            // 
            this.signupimg.BackColor = System.Drawing.Color.Transparent;
            this.signupimg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signupimg.BackgroundImage")));
            this.signupimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.signupimg.Location = new System.Drawing.Point(195, 359);
            this.signupimg.Name = "signupimg";
            this.signupimg.Size = new System.Drawing.Size(73, 34);
            this.signupimg.TabIndex = 8;
            this.signupimg.TabStop = false;
            this.signupimg.Click += new System.EventHandler(this.signupimg_Click);
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.signupimg);
            this.Controls.Add(this.loginimg);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Parola);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.User);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "start";
            this.Text = "Prime Target";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signupimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Parola;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox loginimg;
        private System.Windows.Forms.PictureBox signupimg;
    }
}

