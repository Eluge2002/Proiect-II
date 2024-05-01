using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Level_2;
using MongoDB.Bson;
using MongoDB.Driver;




namespace proiect
{
    public partial class joc : Form
    {
        private IMongoCollection<Cont> ContCollection;
        private string currentUsername;
        public joc(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }

        private void settings_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("index.html");
        }

        private void start_Click(object sender, EventArgs e)
        {
            nivel1.Visible = true;
            nivel2.Visible = true;
            nivel3.Visible = true;
           
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            start startForm = new start();
            startForm.Show();
        }

        private void Level1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Level1 level1= new Level1(currentUsername);
            level1.Show();
        }
        private void nivel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Level2 level = new Level2(currentUsername);
            level.Show();
            level.Level2_Load_1(sender, e);
        }

        private void nivel3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Level3 level = new Level3(currentUsername);
            level.Show();
        }



        private void joc_Load(object sender, EventArgs e)
        {
            const string connectionUri = "mongodb+srv://cbotar82:I36rhl3i86onf6b5@cluster0.bguofu2.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var database = client.GetDatabase("Conturi");
            ContCollection = database.GetCollection<Cont>("Cont");

            try
            {
                var result = client.GetDatabase("admin").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
                Console.WriteLine("Pinged your deployment. You successfully connected to MongoDB!");

                // Definirea etapei de agregare pentru a adăuga un nou câmp 'total_score'
                var pipeline = new BsonDocument[]
                {
            new BsonDocument("$match", new BsonDocument("username", currentUsername)), // Filtrează documentele după numele de utilizator
            new BsonDocument("$addFields", new BsonDocument
            {
                { "total_score", new BsonDocument("$add", new BsonArray { "$level1", "$Level2", "$Level3" }) }
            })
                };

                // Executarea operației de agregare și stocarea rezultatului într-o listă
                var aggregateResult = ContCollection.Aggregate<BsonDocument>(pipeline).ToList();

                // Extrage scorul total din primul document agregat (presupunând că există un singur document agregat pentru un utilizator)
                var totalScore = aggregateResult.FirstOrDefault()?["total_score"].AsInt32;

                // Actualizarea valoare TextBox-ului 'score' cu scorul total
                score.Text = totalScore.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }
}
