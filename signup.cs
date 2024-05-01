using System;
using System.IO;
using System.Windows.Forms;
using MongoDB.Driver;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Raven.Database.Plugins.Builtins.Monitoring.Snmp.Objects.Database.Statistics;
using System.ComponentModel.Composition.Primitives;
using MongoDB.Bson;

namespace proiect
{
    public partial class signup : Form
    {
        private IMongoCollection<Cont> ContCollection;


        public signup()
        {

            InitializeComponent();
        }


        private void username_TextChanged(object sender, EventArgs e)
        {
            // Aici puteți adăuga logica pentru evenimentul text modificat pentru câmpul de utilizator (dacă este necesar)
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            // Aici puteți adăuga logica pentru evenimentul text modificat pentru câmpul de parolă (dacă este necesar)
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            // Aici puteți adăuga logica pentru evenimentul text modificat pentru câmpul de email (dacă este necesar)
        }

        private void signup_Load(object sender, EventArgs e)
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
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string usernameValue = username.Text;
            string passwordValue = password.Text;
            string emailValue = email.Text;

            // Validation: Check if all fields are completed
            if (string.IsNullOrWhiteSpace(usernameValue) || string.IsNullOrWhiteSpace(passwordValue) || string.IsNullOrWhiteSpace(emailValue))
            {
                MessageBox.Show("Please complete all fields!");
                return;
            }

            // Create a new Cont object
            var cont = new Cont
            {
                Username = usernameValue,
                Password = passwordValue,
                Email = emailValue,
                Score=0,
                Level1=0,
                Level2=0,
                Level3=0
            };

            // Insert the Cont object into MongoDB
            ContCollection.InsertOne(cont);

            MessageBox.Show("User registered successfully!");

        }

    }
}
