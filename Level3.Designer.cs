namespace proiect
{
    partial class Level3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level3));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_over = new System.Windows.Forms.Label();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.alien2 = new System.Windows.Forms.PictureBox();
            this.alien = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.return_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.return_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_score.Location = new System.Drawing.Point(9, 9);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(135, 37);
            this.lbl_score.TabIndex = 5;
            this.lbl_score.Text = "Score : 0";
            // 
            // lbl_over
            // 
            this.lbl_over.AutoSize = true;
            this.lbl_over.BackColor = System.Drawing.Color.Transparent;
            this.lbl_over.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_over.ForeColor = System.Drawing.Color.Red;
            this.lbl_over.Location = new System.Drawing.Point(129, 212);
            this.lbl_over.Name = "lbl_over";
            this.lbl_over.Size = new System.Drawing.Size(229, 50);
            this.lbl_over.TabIndex = 6;
            this.lbl_over.Text = "Game Over";
            // 
            // enemy3
            // 
            this.enemy3.Image = global::proiect.Properties.Resources.E3;
            this.enemy3.Location = new System.Drawing.Point(300, 49);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(58, 50);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy3.TabIndex = 9;
            this.enemy3.TabStop = false;
            this.enemy3.Tag = "enemy";
            // 
            // enemy2
            // 
            this.enemy2.Image = global::proiect.Properties.Resources.E2;
            this.enemy2.Location = new System.Drawing.Point(211, 49);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(58, 50);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy2.TabIndex = 8;
            this.enemy2.TabStop = false;
            this.enemy2.Tag = "enemy";
            // 
            // enemy1
            // 
            this.enemy1.Image = global::proiect.Properties.Resources.E1;
            this.enemy1.Location = new System.Drawing.Point(113, 49);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(58, 50);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy1.TabIndex = 7;
            this.enemy1.TabStop = false;
            this.enemy1.Tag = "enemy";
            // 
            // alien2
            // 
            this.alien2.Image = global::proiect.Properties.Resources.Boss2;
            this.alien2.Location = new System.Drawing.Point(412, 57);
            this.alien2.Name = "alien2";
            this.alien2.Size = new System.Drawing.Size(58, 50);
            this.alien2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.alien2.TabIndex = 2;
            this.alien2.TabStop = false;
            this.alien2.Tag = "enemy";
            // 
            // alien
            // 
            this.alien.Image = global::proiect.Properties.Resources.Boss1;
            this.alien.Location = new System.Drawing.Point(12, 57);
            this.alien.Name = "alien";
            this.alien.Size = new System.Drawing.Size(58, 50);
            this.alien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.alien.TabIndex = 1;
            this.alien.TabStop = false;
            this.alien.Tag = "enemy";
            // 
            // player
            // 
            this.player.Image = global::proiect.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(211, 367);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(52, 40);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proiect.Properties.Resources.stars;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 455);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "stars";
            // 
            // return_btn
            // 
            this.return_btn.BackColor = System.Drawing.Color.Transparent;
            this.return_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("return_btn.BackgroundImage")));
            this.return_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.return_btn.InitialImage = ((System.Drawing.Image)(resources.GetObject("return_btn.InitialImage")));
            this.return_btn.Location = new System.Drawing.Point(156, 275);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(170, 61);
            this.return_btn.TabIndex = 10;
            this.return_btn.TabStop = false;
            this.return_btn.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Level3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.lbl_over);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.alien2);
            this.Controls.Add(this.alien);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Level3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level3";
            this.Load += new System.EventHandler(this.Level3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level3_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level3_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.return_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox alien;
        private System.Windows.Forms.PictureBox alien2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_over;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox return_btn;
    }
}