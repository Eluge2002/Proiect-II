

using System.Drawing;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;

namespace Level_2

{
    partial class Level2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level2));
            this.MoveTimer = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.RightMove = new System.Windows.Forms.Timer(this.components);
            this.LeftMove = new System.Windows.Forms.Timer(this.components);
            this.DownMove = new System.Windows.Forms.Timer(this.components);
            this.UpMove = new System.Windows.Forms.Timer(this.components);
            this.MoveMunitionTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveEnemTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemMunTimer = new System.Windows.Forms.Timer(this.components);
            this.Box = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.replayBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.scorelb1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Label();
            this.timerGamer = new System.Windows.Forms.Timer(this.components);
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveTimer
            // 
            this.MoveTimer.Enabled = true;
            this.MoveTimer.Interval = 10;
            //this.MoveTimer.Tick += new System.EventHandler(this.MoveTimer_Tick);
            // 
            // Player
            // 
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(272, 420);
            this.Player.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(75, 60);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // RightMove
            // 
            this.RightMove.Interval = 5;
            this.RightMove.Tick += new System.EventHandler(this.RightMove_Tick_1);
            // 
            // LeftMove
            // 
            this.LeftMove.Interval = 5;
            this.LeftMove.Tick += new System.EventHandler(this.LeftMove_Tick_1);
            // 
            // DownMove
            // 
            this.DownMove.Interval = 4;
            this.DownMove.Tick += new System.EventHandler(this.DownMove_Tick_1);
            // 
            // UpMove
            // 
            this.UpMove.Interval = 5;
            this.UpMove.Tick += new System.EventHandler(this.UpMove_Tick_1);
            // 
            // MoveMunitionTimer
            // 
            this.MoveMunitionTimer.Enabled = true;
            this.MoveMunitionTimer.Interval = 20;
            this.MoveMunitionTimer.Tick += new System.EventHandler(this.MoveMunitionTimer_Tick_1);
            // 
            // MoveEnemTimer
            // 
            this.MoveEnemTimer.Enabled = true;
            this.MoveEnemTimer.Tick += new System.EventHandler(this.MoveEnemTimer_Tick_1);
            // 
            // EnemMunTimer
            // 
            this.EnemMunTimer.Enabled = true;
            this.EnemMunTimer.Interval = 20;
            this.EnemMunTimer.Tick += new System.EventHandler(this.EnemMunTimer_Tick_1);
            // 
            // Box
            // 
            this.Box.Image = ((System.Drawing.Image)(resources.GetObject("Box.Image")));
            this.Box.Location = new System.Drawing.Point(281, 226);
            this.Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(108, 50);
            this.Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Box.TabIndex = 1;
            this.Box.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(254, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // replayBtn
            // 
            this.replayBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.replayBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replayBtn.Location = new System.Drawing.Point(219, 97);
            this.replayBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.replayBtn.Name = "replayBtn";
            this.replayBtn.Size = new System.Drawing.Size(195, 46);
            this.replayBtn.TabIndex = 3;
            this.replayBtn.Text = "Replay";
            this.replayBtn.UseVisualStyleBackColor = false;
            this.replayBtn.Visible = false;
            this.replayBtn.Click += new System.EventHandler(this.replayBtn_Click_1);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(219, 154);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(195, 53);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Visible = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click_1);
            // 
            // scorelb1
            // 
            this.scorelb1.AutoSize = true;
            this.scorelb1.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.scorelb1.Location = new System.Drawing.Point(12, 7);
            this.scorelb1.Name = "scorelb1";
            this.scorelb1.Size = new System.Drawing.Size(60, 25);
            this.scorelb1.TabIndex = 5;
            this.scorelb1.Text = "Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(592, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Level2";
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Location = new System.Drawing.Point(604, 38);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(44, 16);
            this.timer.TabIndex = 7;
            this.timer.Text = "label3";
            // 
            // timerGamer
            // 
            this.timerGamer.Tick += new System.EventHandler(this.timerGamer_Tick_1);
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // Level2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(682, 483);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scorelb1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.replayBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.Player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(700, 530);
            this.Name = "Level2";
            this.Text = "Level2";
            this.MaximizedBoundsChanged += new System.EventHandler(this.Level2_Load_1);
            this.MaximumSizeChanged += new System.EventHandler(this.Level2_Load_1);
            this.MinimumSizeChanged += new System.EventHandler(this.Level2_Load_1);
            this.Load += new System.EventHandler(this.Level2_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level2_KeyDown_1);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level2_KeyUp_1);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //MoveTimer_Tick(object sender, EventArgs e) => throw new NotImplementedException();



        #endregion

        private System.Windows.Forms.Timer MoveTimer;
        private PictureBox Player;
        private System.Windows.Forms.Timer RightMove;
        private System.Windows.Forms.Timer LeftMove;
        private System.Windows.Forms.Timer DownMove;
        private System.Windows.Forms.Timer UpMove;
        private System.Windows.Forms.Timer MoveMunitionTimer;
        private System.Windows.Forms.Timer MoveEnemTimer;
        private System.Windows.Forms.Timer EnemMunTimer;
        private PictureBox Box;
        private Label label1;
        private Button replayBtn;
        private Button exitBtn;
        private Label scorelb1;
        private Label label2;
        private Label timer;
        private System.Windows.Forms.Timer timerGamer;
        private Timer timerGame;
    }
}