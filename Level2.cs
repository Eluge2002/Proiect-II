using Level_2;
using proiect;
using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using WMPLib;

namespace Level_2
{
    public partial class Level2 : Form
    {
        
        WindowsMediaPlayer gameMedia;
        WindowsMediaPlayer shootgMedia;
        WindowsMediaPlayer explosion;
        int playerSpeed;
        int enemSpeed;
        PictureBox[] enemies;
        PictureBox[] munitions;
        PictureBox[] enemMuntion;
        Random rand;
        int enemMuntionSpeed;
        int munitionsSpeed;
        private int gameTimeInSeconds;
        int score;


        bool pause;
        bool gameIsOver;

        public Level2()
        {
            InitializeComponent();
            Controls.Add(Player);
        }


        public void Level2_Load_1(object sender, EventArgs e)
        {
            gameMedia = new WindowsMediaPlayer();
            shootgMedia = new WindowsMediaPlayer();
            explosion = new WindowsMediaPlayer();
            pause = false;
            gameIsOver = false;
            score = 0;
            timerGame.Tick += timerGamer_Tick_1;
            timerGame.Start();

            gameTimeInSeconds = 0;


            MoveMunitionTimer.Start();
            MoveEnemTimer.Start();

            enemSpeed = 4;
            munitionsSpeed = 15;
            enemMuntionSpeed = 5;


            munitions = new PictureBox[3];
            for (int i = 0; i < munitions.Length; i++)
            {
                munitions[i] = new PictureBox();
                munitions[i].Size = new Size(15, 15);
                munitions[i].Image = Image.FromFile("munition.png");
                munitions[i].SizeMode = PictureBoxSizeMode.Zoom;
                munitions[i].BorderStyle = BorderStyle.None;
                munitions[i].Visible = false;
                Controls.Add(munitions[i]);
            }

            enemies = new PictureBox[10];
            for (int j = 0; j < enemies.Length; j++)
            {
                enemies[j] = new PictureBox();
                enemies[j].Size = new Size(50, 50);
                enemies[j].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[j].BorderStyle = BorderStyle.None;
                enemies[j].Visible = false;
                Controls.Add(enemies[j]);
                enemies[j].Location = new Point((j + 1) * 50, -50);
            }
            // Set enemy images
            enemies[0].Image = Image.FromFile("Boss1.png");
            enemies[1].Image = Image.FromFile("E2.png");
            enemies[2].Image = Image.FromFile("E3.png");
            enemies[3].Image = Image.FromFile("E3.png");
            enemies[4].Image = Image.FromFile("E1.png");
            enemies[5].Image = Image.FromFile("E3.png");
            enemies[6].Image = Image.FromFile("E2.png");
            enemies[7].Image = Image.FromFile("E3.png");
            enemies[8].Image = Image.FromFile("E2.png");
            enemies[9].Image = Image.FromFile("Boss2.png");
            //
            rand = new Random();
            enemMuntion = new PictureBox[10];
            for (int j = 0; j < enemMuntion.Length; j++)
            {
                enemMuntion[j] = new PictureBox();
                enemMuntion[j].Size = new Size(2, 25);
                enemMuntion[j].Visible = false;
                enemMuntion[j].BackColor = Color.Yellow;
                int x = rand.Next(0, 10);

                enemMuntion[j].Location = new Point(enemies[x].Location.X, enemies[x].Location.Y - 20);
                Controls.Add(enemMuntion[j]);
            }
            gameMedia.URL = "ameSong.mp3";
            shootgMedia.URL = "shoot.mp3";
            explosion.URL = "boom.mp3";
            gameMedia.settings.setMode("loop", true);
            gameMedia.settings.volume = 5;
            shootgMedia.settings.volume = 1;
            explosion.settings.volume = 6;

            playerSpeed = 5;
            gameMedia.controls.play();
            MoveEnem(enemies, enemSpeed);
        }


        public void MoveEnem(PictureBox[] array, int speed)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Visible = true;
                array[i].Top += speed;

                // Verificăm coliziunea cu cutia
                if (array[i].Bounds.IntersectsWith(Box.Bounds))
                {
                    // Ajustăm poziția inamicului pentru a trece pe lângă cutie
                    array[i].Left += 50; // Deplasăm inamicul la dreapta cu 50 de pixeli
                    array[i].Top -= 50; // Ridicăm inamicul cu 50 de pixeli pentru a evita coliziunea
                }

                if (array[i].Top > this.Height)
                    array[i].Location = new Point((i + 1) * 50, -200);
            }
        }

        public void Collision()
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                for (int j = 0; j < munitions.Length; j++)
                {
                    if (munitions[j].Bounds.IntersectsWith(enemies[i].Bounds))
                    {
                        explosion.settings.volume = 30;
                        explosion.controls.play();
                        score += 1;
                        scorelb1.Text = (score < 20) ? "0" + score.ToString() : score.ToString();
                        enemies[i].Location = new Point((i + 1) * 50, -100);
                        munitions[j].Visible = false;
                        enemMuntion[i].Visible = false; 
                    }
                    if (munitions[j].Bounds.IntersectsWith(Box.Bounds))
                    {
                        // Muniția dispare când lovește cutia, dar nu este distrusă complet
                        munitions[j].Visible = false;
                        // Repozitionează muniția în afara ecranului
                        munitions[j].Location = new Point(-100, -100);// sau orice altă poziție în afara ecranului
                    }
                   
                }
            }
        }


        public void GameOver(String str)
        {
            label1.Text = str;
            int x = (this.ClientSize.Width-label1.Width)/2;
            int y = (this.ClientSize.Height-label1.Height)/2;
            label1.Location = new Point(x,y+50);
            label1.Visible = true;
            replayBtn.Visible = true;
            exitBtn.Visible = true;

            gameMedia.controls.stop();
            StopTimers();
        }
        public void StopTimers()
        {
            MoveTimer.Stop();
            MoveEnemTimer.Stop();
            MoveMunitionTimer.Stop();
            EnemMunTimer.Stop();
            timerGame.Stop();

        }
        public void StartTimers()
        {
            MoveTimer.Start();
            MoveEnemTimer.Start();
            MoveMunitionTimer.Start();
            EnemMunTimer.Start();
            timerGame.Start();
        }

       
        public void CollisionWithEnemMun()
        {
            if (!pause && !gameIsOver)
            {
                for (int i = 0; i<enemMuntion.Length; i++)
                {
                    // Calculăm centrul muniției inamicului
                    Point munitionCenter = new Point(
                        enemMuntion[i].Bounds.X + enemMuntion[i].Bounds.Width / 2,
                        enemMuntion[i].Bounds.Y + enemMuntion[i].Bounds.Height / 2
                    );

                    // Calculăm centrul jucătorului
                    Point playerCenter = new Point(
                        Player.Bounds.X + Player.Bounds.Width / 2,
                        Player.Bounds.Y + Player.Bounds.Height / 2
                    );


                    double distance=Math.Sqrt(Math.Pow(munitionCenter.X-playerCenter.X, 2)+Math.Pow(munitionCenter.Y - playerCenter.Y, 2));
                    double distantaMinimaPentruColiziune = 16.0;

                    if (distance<distantaMinimaPentruColiziune)
                    {
                        explosion.settings.volume = 30;
                        explosion.controls.play();
                        Player.Visible = false;
                        enemMuntion[i].Visible = false;
                        GameOver("GAME OVER");
                    }

                    if (enemMuntion[i].Bounds.IntersectsWith(Box.Bounds))
                    {
                        enemMuntion[i].Dispose();
                    }


                }
                EnemMunTimer.Start();
            }
        }

        private void timerGamer_Tick_1(object sender, EventArgs e)
        {
            
        }

        private void MoveMunitionTimer_Tick_1(object sender, EventArgs e)
        {
            shootgMedia.controls.play();
            for (int i = 0; i < munitions.Length; i++)
            {
                if (munitions[i].Top > 0)
                {
                    munitions[i].Visible = true;
                    munitions[i].Top -= munitionsSpeed;
                    Collision();
                    CollisionWithEnemMun();
                }
                else
                {
                    munitions[i].Visible = false;
                    munitions[i].Location = new Point(Player.Location.X + 10, Player.Location.Y - i * 30);
                }
            }
        }

        private void MoveEnemTimer_Tick_1(object sender, EventArgs e)
        {
            MoveEnem(enemies, enemSpeed);
        }

        private void EnemMunTimer_Tick_1(object sender, EventArgs e)
        {
            for (int i = 0; i < enemMuntion.Length; i++)
            {
                if (enemMuntion[i].Top < this.Height)
                {
                    enemMuntion[i].Visible = true;
                    enemMuntion[i].Top += enemMuntionSpeed;

                }
                else
                {
                    enemMuntion[i].Visible = false;
                    int x = rand.Next(0, 10);

                    enemMuntion[i].Location = new Point(enemies[x].Location.X + 20, enemies[x].Location.Y + 30);
                }
            }
        }

        public void replayBtn_Click_1(object sender, EventArgs e)
        {

            this.Controls.Clear();
            this.Hide();
            Level2 level2 = new Level2();   
            level2.Show();

        }
       
        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            joc menu = new joc();
            menu.Show();
            this.Close();
        }

        private void RightMove_Tick_1(object sender, EventArgs e)
        {
            if (Player.Right < 530) 
            {
                Player.Left += playerSpeed; 

             
                if (Player.Bounds.IntersectsWith(Box.Bounds))
                {
                   
                    Player.Left = Box.Left - Player.Width;
                }
            }
        }

        private void LeftMove_Tick_1(object sender, EventArgs e)
        {
            if (Player.Left > 10) 
            {
                Player.Left -= playerSpeed; 

              
                if (Player.Bounds.IntersectsWith(Box.Bounds))
                {
                   
                    Player.Left = Box.Right;
                }
            }
        }

        private void DownMove_Tick_1(object sender, EventArgs e)
        {
            if (Player.Bottom + playerSpeed <= this.ClientSize.Height) 
            {
                Player.Top += playerSpeed; 

               
                if (Player.Bounds.IntersectsWith(Box.Bounds))
                {
                    
                    Player.Top = Box.Top - Player.Height;
                }
            }
        }

        private void UpMove_Tick_1(object sender, EventArgs e)
        {
            if (Player.Top > 10) 
            {
                Player.Top -= playerSpeed; 

               
                if (Player.Bounds.IntersectsWith(Box.Bounds))
                {
                    
                    Player.Top = Box.Bottom;
                }
            }
        }
        private void timerGame_Tick(object sender, EventArgs e)
        {
            gameTimeInSeconds++;
            timer.Text = $"{gameTimeInSeconds / 60:D2}:{gameTimeInSeconds % 60:D2}";
        }

       

        private void Level2_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (!pause && !gameIsOver)
            {
                if (e.KeyCode == Keys.Right)
                    RightMove.Start();
                if (e.KeyCode == Keys.Left)
                    LeftMove.Start();
                if (e.KeyCode == Keys.Down)
                    DownMove.Start();
                if (e.KeyCode == Keys.Up)
                    UpMove.Start();
            }
        }

        private void Level2_KeyUp_1(object sender, KeyEventArgs e)
        {
            RightMove.Stop();
            LeftMove.Stop();
            UpMove.Stop();
            DownMove.Stop();
            if (e.KeyCode == Keys.Space)
            {

                if (!gameIsOver)
                {
                    if (pause)
                    {
                        StartTimers();
                        label1.Visible = false;
                        gameMedia.controls.play();
                        pause = false;
                    }
                    else
                    {

                        label1.Location = new Point(this.Width / 2 - 120, 150);
                        label1.Text = "PAUSED";
                        label1.Visible = true;
                        gameMedia.controls.pause();
                        StopTimers();
                        pause = true;
                    }
                }

            }
        }

       
    }
} 



