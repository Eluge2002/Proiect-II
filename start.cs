
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace proiect
{
    public partial class start : Form
    {
        private string currentUsername; // Variabilă pentru a stoca numele de utilizator introdus temporar
        private IMongoCollection<Cont> ContCollection;
        private MongoClient client;
        public start()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void User_TextChanged(object sender, EventArgs e)
        {
            // Aici puteți adăuga logica pentru evenimentul text modificat pentru câmpul de utilizator (dacă este necesar)
        }

        private void Parola_TextChanged(object sender, EventArgs e)
        {
            // Aici puteți adăuga logica pentru evenimentul text modificat pentru câmpul de parolă (dacă este necesar)
        }



        private void start_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentUsername)) // Verificați dacă există un nume de utilizator stocat
            {
                MessageBox.Show($"Welcome back, {currentUsername}!"); // Afișați mesajul de bun venit
            }
        }

        private void signupimg_Click(object sender, EventArgs e)
        {
            signup signupForm = new signup();

            // Arată fereastra Signup
            signupForm.Show();
        }

        private void loginimg_Click(object sender, EventArgs e)
        {
            string username = User.Text;
            string password = Parola.Text;

            // Validate input
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            // Query MongoDB collection to find a document with the provided username and password
            var filter = Builders<Cont>.Filter.Eq("Username", username) & Builders<Cont>.Filter.Eq("Password", password);

            // Execute the query
            var result = ContCollection.Find(filter).FirstOrDefault();

            // Check if a matching document was found
            if (result != null)
            {
                MessageBox.Show("Login successful!");

                // Save the username
                currentUsername = username;

                this.Hide();
                joc jocForm = new joc(currentUsername);
                jocForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

    }
}
