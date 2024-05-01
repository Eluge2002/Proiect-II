namespace proiect
{
    partial class joc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(joc));
            this.start = new System.Windows.Forms.PictureBox();
            this.settings = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.PictureBox();
            this.titlu = new System.Windows.Forms.PictureBox();
            this.nivel1 = new System.Windows.Forms.PictureBox();
            this.nivel2 = new System.Windows.Forms.PictureBox();
            this.nivel3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel3)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("start.BackgroundImage")));
            this.start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.start.Location = new System.Drawing.Point(296, 246);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(168, 36);
            this.start.TabIndex = 0;
            this.start.TabStop = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.Transparent;
            this.settings.BackgroundImage = global::proiect.Properties.Resources.Site;
            this.settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settings.Location = new System.Drawing.Point(296, 303);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(168, 36);
            this.settings.TabIndex = 1;
            this.settings.TabStop = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logout.BackgroundImage")));
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logout.Location = new System.Drawing.Point(296, 359);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(168, 36);
            this.logout.TabIndex = 2;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // titlu
            // 
            this.titlu.BackColor = System.Drawing.Color.Transparent;
            this.titlu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titlu.BackgroundImage")));
            this.titlu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.titlu.Location = new System.Drawing.Point(208, 36);
            this.titlu.Name = "titlu";
            this.titlu.Size = new System.Drawing.Size(365, 171);
            this.titlu.TabIndex = 3;
            this.titlu.TabStop = false;
            // 
            // nivel1
            // 
            this.nivel1.BackColor = System.Drawing.Color.Transparent;
            this.nivel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nivel1.BackgroundImage")));
            this.nivel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nivel1.InitialImage = ((System.Drawing.Image)(resources.GetObject("nivel1.InitialImage")));
            this.nivel1.Location = new System.Drawing.Point(473, 246);
            this.nivel1.Name = "nivel1";
            this.nivel1.Size = new System.Drawing.Size(46, 36);
            this.nivel1.TabIndex = 4;
            this.nivel1.TabStop = false;
            this.nivel1.Visible = false;
            this.nivel1.Click += new System.EventHandler(this.Level1_Click);
            // 
            // nivel2
            // 
            this.nivel2.BackColor = System.Drawing.Color.Transparent;
            this.nivel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nivel2.BackgroundImage")));
            this.nivel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nivel2.InitialImage = ((System.Drawing.Image)(resources.GetObject("nivel2.InitialImage")));
            this.nivel2.Location = new System.Drawing.Point(525, 246);
            this.nivel2.Name = "nivel2";
            this.nivel2.Size = new System.Drawing.Size(46, 36);
            this.nivel2.TabIndex = 5;
            this.nivel2.TabStop = false;
            this.nivel2.Visible = false;
            this.nivel2.Click += new System.EventHandler(this.nivel2_Click);
            // 
            // nivel3
            // 
            this.nivel3.BackColor = System.Drawing.Color.Transparent;
            this.nivel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nivel3.BackgroundImage")));
            this.nivel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nivel3.InitialImage = ((System.Drawing.Image)(resources.GetObject("nivel3.InitialImage")));
            this.nivel3.Location = new System.Drawing.Point(577, 246);
            this.nivel3.Name = "nivel3";
            this.nivel3.Size = new System.Drawing.Size(46, 36);
            this.nivel3.TabIndex = 6;
            this.nivel3.TabStop = false;
            this.nivel3.Visible = false;
            this.nivel3.Click += new System.EventHandler(this.nivel3_Click);
            // 
            // joc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.nivel3);
            this.Controls.Add(this.nivel2);
            this.Controls.Add(this.nivel1);
            this.Controls.Add(this.titlu);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "joc";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.joc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox start;
        private System.Windows.Forms.PictureBox settings;
        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.PictureBox titlu;
        private System.Windows.Forms.PictureBox nivel1;
        private System.Windows.Forms.PictureBox nivel2;
        private System.Windows.Forms.PictureBox nivel3;
    }
}