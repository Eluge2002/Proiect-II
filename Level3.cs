using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace proiect
{
    public partial class Level3 : Form
    {
        private bool right, left, space;
        private int score;
        private List<PictureBox> enemies = new List<PictureBox>();
        private string currentUsername;
        private IMongoCollection<Cont> ContCollection;
        public Level3(string username)
        {
            InitializeComponent();
            lbl_over.Hide();
            return_btn.Hide();
            InitializeEnemies(); // Inițializăm inamicii la început
            currentUsername = username;
            InitializeMongoDB();
        }
        private void InitializeMongoDB()
        {
            const string connectionUri = "mongodb+srv://cbotar82:I36rhl3i86onf6b5@cluster0.bguofu2.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            // Set the ServerApi field of the settings object to set the version of the Stable API on the client
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            // Create a new client and connect to the server
            var client = new MongoClient(settings);
            // Send a ping to confirm a successful connection
            var database = client.GetDatabase("Conturi"); // Replace "your_database_name" with your actual database name
            ContCollection = database.GetCollection<Cont>("Cont");

            // Send a ping to confirm a successful connection
            try
            {
                var result = client.GetDatabase("admin").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
                Console.WriteLine("Pinged your deployment. You successfully connected to MongoDB!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        void InitializeEnemies()
        {
            // Adăugăm inamicii inițiali în listă
            enemies.Add(alien);
            enemies.Add(alien2);
            enemies.Add(enemy1);
            enemies.Add(enemy2);
            enemies.Add(enemy3);
        }
        private async Task UpdateScoreInDatabase(string playerName, int newScore)
        {
            var filter = Builders<Cont>.Filter.Eq("Username", playerName);
            var update = Builders<Cont>.Update.Set("Level3", newScore);
            await ContCollection.UpdateOneAsync(filter, update);
        }

        void Add_Bullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.SizeMode = PictureBoxSizeMode.Zoom;
            bullet.Size = new Size(10, 10);
            bullet.Image = Properties.Resources.munition;
            bullet.BackColor = System.Drawing.Color.Transparent;
            bullet.Tag = "bullet";
            bullet.Left = player.Left + 10;
            bullet.Top = player.Top - 20;
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }

        async void Game_Result()
        {
            foreach (PictureBox enemy in enemies)
            {
                if (player.Bounds.IntersectsWith(enemy.Bounds))
                {
                    // Dacă se produce coliziune, afișăm "Game Over", oprim timer-ul și facem lbl_over vizibil
                    timer1.Stop();
                    lbl_over.Show();
                    return_btn.Show();
                    return;
                }
            }
            foreach (PictureBox bullet in this.Controls.OfType<PictureBox>().Where(pb => pb.Tag?.ToString() == "bullet"))
            {
                foreach (PictureBox enemy in enemies)
                {
                    if (bullet.Bounds.IntersectsWith(enemy.Bounds))
                    {
                        this.Controls.Remove(bullet);
                        bullet.Dispose(); // Eliberăm resursele asociate cu proiectilul
                        enemies.Remove(enemy); // Înlăturăm inamicul lovit din listă
                        enemy.Dispose(); // Eliberăm resursele asociate cu inamicul
                        score++;
                        lbl_score.Text = "Score : " + score;
                        Add_Random_Enemy(); // Adăugăm un nou inamic
                        return; // Ne oprim din iterație pentru că inamicul a fost eliminat
                    }
                }
            }
            await UpdateScoreInDatabase(currentUsername, score);
        }

        void Bullet_Movement()
        {
            foreach (Control x in this.Controls.OfType<PictureBox>().Where(pb => pb.Tag?.ToString() == "bullet"))
            {
                x.Top -= 10;
                if (x.Top < 50)
                {
                    this.Controls.Remove(x);
                    x.Dispose(); // Eliberăm resursele asociate cu proiectilul
                }
            }
        }

        void Enemy_Movement()
        {
            Random rnd = new Random();
            foreach (PictureBox enemy in enemies)
            {
                if (enemy.Top >= 500)
                {
                    int x = rnd.Next(0, this.ClientSize.Width - enemy.Width);
                    enemy.Location = new Point(x, 0);
                    enemy.BringToFront();
                }
                else
                {
                    enemy.Top += 10;
                }
            }
        }

        void Arrow_key_Movement()
        {
            if (right == true)
            {
                if (player.Left < 325)
                {
                    player.Left += 15;
                }
            }
            if (left == true)
            {
                if (player.Left > 10)
                {
                    player.Left -= 15;
                }
            }
        }

        private void Level3_Load(object sender, EventArgs e)
        {
        }

        private void Level3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = true; }
            if (e.KeyCode == Keys.Left) { left = true; }
            if (e.KeyCode == Keys.Space)
            {
                space = true;
                Add_Bullet();
            }
        }

        private void Level3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }
            if (e.KeyCode == Keys.Space) { space = false; }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close(); // Închide formularul Level3
            joc joc = new joc(currentUsername); // Creează un nou obiect Joc
            joc.Show(); // Deschide formularul Joc
        }

        void Add_Random_Enemy()
        {
            Random rnd = new Random();
            int randEnemy = rnd.Next(1, 6); // Generează un număr aleatoriu între 1 și 5 pentru a alege un inamic nou

            PictureBox newEnemy = new PictureBox();
            newEnemy.SizeMode = PictureBoxSizeMode.Zoom;
            newEnemy.Size = new Size(40, 40);
            newEnemy.BackColor = Color.Transparent;
            newEnemy.Tag = "enemy";

            switch (randEnemy)
            {
                case 1:
                    newEnemy.Image = Properties.Resources.Boss1;
                    break;
                case 2:
                    newEnemy.Image = Properties.Resources.Boss2;
                    break;
                case 3:
                    newEnemy.Image = Properties.Resources.E1;
                    break;
                case 4:
                    newEnemy.Image = Properties.Resources.E2;
                    break;
                case 5:
                    newEnemy.Image = Properties.Resources.E3;
                    break;
                default:
                    break;
            }

            int x = rnd.Next(0, this.ClientSize.Width - newEnemy.Width);
            int y = rnd.Next(-100, -40); // Poziție aleatoare deasupra ecranului

            newEnemy.Location = new Point(x, y);
            this.Controls.Add(newEnemy);
            newEnemy.BringToFront();
            enemies.Add(newEnemy); // Adăugăm noul inamic în listă
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Arrow_key_Movement();
            Enemy_Movement();
            Bullet_Movement();
            Game_Result();
        }
    }
}