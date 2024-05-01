using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace proiect
{
    public partial class Level1 : Form
    {
        PictureBox[] stars;
        int playerSpeed;

        private int gameTimeInSeconds;

        PictureBox[] munitions;
        int MunitionSpeed;

        PictureBox[] enemies;
        int enemiesSpeed;

        PictureBox[] enemiesMunition;
        int enemiesMunitionSpeed;

        int backgroundspeed = 4;
        Random rnd;
        int score;
        
        bool pause;
        bool gameISOVER;

        WindowsMediaPlayer explosion;
        WindowsMediaPlayer gameMedia;
        WindowsMediaPlayer shootgMedia;
       
        public Level1()
        {
            InitializeComponent();
            explosion=new WindowsMediaPlayer();
            gameMedia = new WindowsMediaPlayer();
            shootgMedia = new WindowsMediaPlayer();
            Controls.Add(Player);
            
        }

        private void Level1_Load(object sender, EventArgs e)
        {

            
            pause = false;
            gameISOVER = false;
            score = 0;
            timerBg.Tick += timerBg_Tick;
            timerBg.Start();

            gameTimeInSeconds = 0;


            timerMoveMunition.Start();
            timerMoveEnem.Start();

            enemiesSpeed = 3;
            MunitionSpeed = 15;
            enemiesMunitionSpeed = 5;


            munitions = new PictureBox[3];
            for (int i = 0; i < munitions.Length; i++)
            {
                munitions[i] = new PictureBox();
                munitions[i].Size = new Size(6, 6);
                munitions[i].Image = Image.FromFile("munition.png");
                munitions[i].SizeMode = PictureBoxSizeMode.Zoom;
                munitions[i].BorderStyle = BorderStyle.None;
                munitions[i].Visible = false;
                Controls.Add(munitions[i]);
            }

            enemies = new PictureBox[7];
            for (int j = 0; j < enemies.Length; j++)
            {
                enemies[j] = new PictureBox();
                enemies[j].Size = new Size(40,40);
                enemies[j].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[j].BorderStyle = BorderStyle.None;
                enemies[j].Visible = false;
                Controls.Add(enemies[j]);
                enemies[j].Location = new Point((j + 1) * 60,-75);
            }
            // Set enemy images
            enemies[0].Image = Image.FromFile("Boss1.png");
            enemies[1].Image = Image.FromFile("E2.png");
            enemies[2].Image = Image.FromFile("E3.png");
            enemies[3].Image = Image.FromFile("E3.png");
            enemies[4].Image = Image.FromFile("E1.png");
            enemies[5].Image = Image.FromFile("E3.png");
            enemies[6].Image = Image.FromFile("Boss2.png");
            //
            rnd = new Random();
            enemiesMunition = new PictureBox[7];
            for (int j = 0; j < enemiesMunition.Length; j++)
            {
                enemiesMunition[j] = new PictureBox();
                enemiesMunition[j].Size = new Size(2, 25);
                enemiesMunition[j].Visible = false;
                enemiesMunition[j].BackColor = Color.Yellow;
                int x = rnd.Next(0,7);

                enemiesMunition[j].Location = new Point(enemies[x].Location.X, enemies[x].Location.Y-20);
                Controls.Add(enemiesMunition[j]);
            }
            //set the stars
            stars = new PictureBox[15];
            
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(rnd.Next(20, 580), rnd.Next(-10, 400));
                if (i % 2 == 1)
                {
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.Red;
                }
                else
                {
                    stars[i].Size = new Size(4, 4);
                    stars[i].BackColor = Color.White;
                }
                this.Controls.Add(stars[i]);
            }
            gameMedia.URL = "GameSong.mp3";
            shootgMedia.URL = "shoot.mp3";
            explosion.URL = "boom.mp3";
            gameMedia.settings.setMode("loop", true);
            gameMedia.settings.volume = 5;
            shootgMedia.settings.volume = 1;
            explosion.settings.volume = 6;

            playerSpeed = 5;
            gameMedia.controls.play();
            MoveEnemies(enemies, enemiesSpeed);

        }

        private void TimerBg_Tick(object sender, EventArgs e)
        {
            
        }

        private void timerStars_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < stars.Length / 2; i++)
            {
                stars[i].Top += backgroundspeed;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
            for (int i = stars.Length/2; i<stars.Length; i++)
            {
                stars[i].Top += backgroundspeed - 2;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
        }

        private void timerLeftMove_Tick(object sender, EventArgs e)
        {
            if (Player.Left>10)
            {
                Player.Left -= playerSpeed;
            }
        }

        private void timerRightMove_Tick(object sender, EventArgs e)
        {
            if (Player.Right < 580)
            {
                Player.Left += playerSpeed;
            }
        }

        private void timerUpMove_Tick(object sender, EventArgs e)
        {
            if (Player.Top > 10)
            {
                Player.Top -= playerSpeed;
            }
        }

        private void timerDownMove_Tick(object sender, EventArgs e)
        {
            if (Player.Bottom+playerSpeed<=this.ClientSize.Height)
            {
                Player.Top += playerSpeed;
            }
        }

        private void Level1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                timerRightMove.Start();
            }
            if (e.KeyCode == Keys.Left)
            {
                timerLeftMove.Start();

            }
            if (e.KeyCode == Keys.Down)
            {
                timerDownMove.Start();

            }
            if (e.KeyCode == Keys.Up)
            {
                timerUpMove.Start();
            }
        }

        private void Level1_KeyUp(object sender, KeyEventArgs e)
        {
            timerLeftMove.Stop();
            timerDownMove.Stop();
           
            timerRightMove.Stop();
            timerUpMove.Stop();
            if (e.KeyCode == Keys.Space)
            {

                if (!gameISOVER)
                {
                    if (pause)
                    {
                        StartTimers();
                        labelState.Visible = false;
                        gameMedia.controls.play();
                        pause = false;
                    }
                    else
                    {
                        int x = (this.ClientSize.Width-labelState.Width)/2;
                        int y = (this.ClientSize.Height-labelState.Height)/2;
                        labelState.Location = new Point(x, y);
                        labelState.Text = "PAUSED";
                        labelState.Visible = true;
                        gameMedia.controls.pause();
                        StopTimers();
                        pause = true;
                    }
                }

            }
        }

        private void timerMoveMunition_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < munitions.Length; i++)
            {
                if (munitions[i].Top > 0)
                {
                    munitions[i].Visible = true;
                    munitions[i].Top -= MunitionSpeed;
                    Collision();
                    CollisionWithEnemMun();
                }
                else
                {
                    munitions[i].Visible = false;
                    munitions[i].Location = new Point(Player.Location.X + 20, Player.Location.Y - i * 30);
                }
            }
        }

        private void timerMoveEnem_Tick(object sender, EventArgs e)
        {
            MoveEnemies(enemies, enemiesSpeed);
        }
        private void MoveEnemies(PictureBox[] array, int speed)
        {
             for (int i = 0; i < array.Length; i++)
            {
                array[i].Visible = true;
                array[i].Top += speed;

                if (array[i].Top > this.Height)
                    array[i].Location = new Point((i + 1) * 50, -200);
            }

        }
        private void StopTimers()
        {
            timerBg.Stop();
            timerMoveEnem.Stop();
            timerMoveMunition.Stop();
            timerMoveEnemMun.Stop();
            timerMove.Stop();
            timerMove.Stop();
        }
        private void StartTimers()
        {
            timerBg.Start();
            timerMoveEnem.Start();
            timerMoveMunition.Start();
            timerMoveEnemMun.Start();
            timerMove.Start();
        }

        private void timerMoveEnemMun_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < enemiesMunition.Length; i++)
            {
                if (enemiesMunition[i].Top<this.Height)
                {
                    enemiesMunition[i].Visible=true;
                    enemiesMunition[i].Top += enemiesMunitionSpeed;

                }
                else
                {
                    enemiesMunition[i].Visible = false;
                    int x = rnd.Next(0,7);

                    enemiesMunition[i].Location = new Point(enemies[x].Location.X + 20, enemies[x].Location.Y + 30);
                }
            }

        }
        public void Collision()
        {
            for (int i=0;i<enemies.Length; i++)
            {
                for (int j=0;j<munitions.Length; j++)
                {
                    if (munitions[j].Bounds.IntersectsWith(enemies[i].Bounds))
                    {
                        explosion.settings.volume = 30;
                        explosion.controls.play();
                        score += 1;
                        labelScore.Text = (score < 20) ? "0" + score.ToString() : score.ToString();
                        enemies[i].Location = new Point((i + 1) * 50, -100);
                        munitions[j].Visible = false;
                    }
                   
                }
            }
        }
        public void GameOver(String str)
        {
            labelState.Text = str;
            int x = (this.ClientSize.Width-labelState.Width)/2;
            int y = (this.ClientSize.Height-labelState.Height)/2;
            labelState.Location = new Point(x, y);
            labelState.Visible = true;
            replayBtn.Visible = true;
            exit.Visible = true;

            gameMedia.controls.stop();
            StopTimers();
        }
        public void CollisionWithEnemMun()
        {
            if (!pause && !gameISOVER)
            {
                for (int i = 0; i < enemiesMunition.Length; i++)
                {
                    // Calculăm centrul muniției inamicului
                    Point munitionCenter = new Point(
                        enemiesMunition[i].Bounds.X + enemiesMunition[i].Bounds.Width/2,
                         enemiesMunition[i].Bounds.Y + enemiesMunition[i].Bounds.Height/2
                    );

                    // Calculăm centrul jucătorului
                    Point playerCenter = new Point(
                        Player.Bounds.X + Player.Bounds.Width/2,
                        Player.Bounds.Y + Player.Bounds.Height/2
                    );


                    double distance = Math.Sqrt(Math.Pow(munitionCenter.X - playerCenter.X, 2) + Math.Pow(munitionCenter.Y - playerCenter.Y, 2));
                    double distantaMinimaPentruColiziune = 16.0;

                    if (distance < distantaMinimaPentruColiziune)
                    {

                        enemiesMunition[i].Visible = false;
                        explosion.settings.volume = 30;
                        explosion.controls.play();
                        Player.Visible = false;
                        GameOver("GAME OVER");
                    }

                }
                timerMoveEnemMun.Start();
            }
        }

        private void timerBg_Tick(object sender, EventArgs e)
        {
            gameTimeInSeconds++;
            time.Text = $"{gameTimeInSeconds/60:D2}:{gameTimeInSeconds%60:D2}";
        }

        private void replayBtn_Click(object sender, EventArgs e)
        {
           
            this.Controls.Clear();
            this.Hide();
            Level1 level1 = new Level1();
            level1.Show();
            


        }

        private void exit_Click(object sender, EventArgs e)
        {
            joc menu= new joc();
            menu.Show();
            this.Close();
        }
    }
}
