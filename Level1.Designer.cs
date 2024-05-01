namespace proiect
{
    partial class Level1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level1));
            this.Player = new System.Windows.Forms.PictureBox();
            this.timerStars = new System.Windows.Forms.Timer(this.components);
            this.timerLeftMove = new System.Windows.Forms.Timer(this.components);
            this.timerRightMove = new System.Windows.Forms.Timer(this.components);
            this.timerUpMove = new System.Windows.Forms.Timer(this.components);
            this.timerDownMove = new System.Windows.Forms.Timer(this.components);
            this.timerMoveMunition = new System.Windows.Forms.Timer(this.components);
            this.timerMoveEnem = new System.Windows.Forms.Timer(this.components);
            this.timerMoveEnemMun = new System.Windows.Forms.Timer(this.components);
            this.timerBg = new System.Windows.Forms.Timer(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.replayBtn = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.timerMove = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(269, 421);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(100, 60);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // timerStars
            // 
            this.timerStars.Enabled = true;
            this.timerStars.Interval = 20;
            this.timerStars.Tick += new System.EventHandler(this.timerStars_Tick);
            // 
            // timerLeftMove
            // 
            this.timerLeftMove.Enabled = true;
            this.timerLeftMove.Interval = 20;
            this.timerLeftMove.Tick += new System.EventHandler(this.timerLeftMove_Tick);
            // 
            // timerRightMove
            // 
            this.timerRightMove.Enabled = true;
            this.timerRightMove.Interval = 20;
            this.timerRightMove.Tick += new System.EventHandler(this.timerRightMove_Tick);
            // 
            // timerUpMove
            // 
            this.timerUpMove.Enabled = true;
            this.timerUpMove.Interval = 20;
            this.timerUpMove.Tick += new System.EventHandler(this.timerUpMove_Tick);
            // 
            // timerDownMove
            // 
            this.timerDownMove.Enabled = true;
            this.timerDownMove.Interval = 20;
            this.timerDownMove.Tick += new System.EventHandler(this.timerDownMove_Tick);
            // 
            // timerMoveMunition
            // 
            this.timerMoveMunition.Enabled = true;
            this.timerMoveMunition.Interval = 50;
            this.timerMoveMunition.Tick += new System.EventHandler(this.timerMoveMunition_Tick);
            // 
            // timerMoveEnem
            // 
            this.timerMoveEnem.Enabled = true;
            this.timerMoveEnem.Interval = 20;
            this.timerMoveEnem.Tick += new System.EventHandler(this.timerMoveEnem_Tick);
            // 
            // timerMoveEnemMun
            // 
            this.timerMoveEnemMun.Enabled = true;
            this.timerMoveEnemMun.Interval = 20;
            this.timerMoveEnemMun.Tick += new System.EventHandler(this.timerMoveEnemMun_Tick);
            // 
            // timerBg
            // 
            this.timerBg.Enabled = true;
            this.timerBg.Interval = 20;
            this.timerBg.Tick += new System.EventHandler(this.timerBg_Tick);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(12, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(43, 16);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Score";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.ForeColor = System.Drawing.Color.DarkRed;
            this.labelState.Location = new System.Drawing.Point(266, 67);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(131, 29);
            this.labelState.TabIndex = 2;
            this.labelState.Text = "labelState";
            this.labelState.Visible = false;
            // 
            // replayBtn
            // 
            this.replayBtn.Location = new System.Drawing.Point(216, 119);
            this.replayBtn.Margin = new System.Windows.Forms.Padding(4);
            this.replayBtn.Name = "replayBtn";
            this.replayBtn.Size = new System.Drawing.Size(181, 72);
            this.replayBtn.TabIndex = 3;
            this.replayBtn.Text = "Replay";
            this.replayBtn.UseVisualStyleBackColor = true;
            this.replayBtn.Visible = false;
            this.replayBtn.Click += new System.EventHandler(this.replayBtn_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(216, 221);
            this.exit.Margin = new System.Windows.Forms.Padding(4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(181, 77);
            this.exit.TabIndex = 4;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Visible = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(585, 13);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(42, 16);
            this.time.TabIndex = 5;
            this.time.Text = "timeG";
            // 
            // timerMove
            // 
            this.timerMove.Enabled = true;
            this.timerMove.Interval = 10;
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(682, 483);
            this.Controls.Add(this.time);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.replayBtn);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.Player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(700, 530);
            this.Name = "Level1";
            this.Text = "Level1";
            this.Load += new System.EventHandler(this.Level1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer timerStars;
        private System.Windows.Forms.Timer timerLeftMove;
        private System.Windows.Forms.Timer timerRightMove;
        private System.Windows.Forms.Timer timerUpMove;
        private System.Windows.Forms.Timer timerDownMove;
        private System.Windows.Forms.Timer timerMoveMunition;
        private System.Windows.Forms.Timer timerMoveEnem;
        private System.Windows.Forms.Timer timerMoveEnemMun;
        private System.Windows.Forms.Timer timerBg;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Button replayBtn;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timerMove;
    }
}