using System;
using System.IO;
using System.Windows.Forms;

namespace proiect
{
    public partial class start : Form
    {
        private string currentUsername; // Variabilă pentru a stoca numele de utilizator introdus temporar

        public start()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Aici puteți adăuga logica inițială la încărcarea formularului (dacă este necesar)
        }

        private void User_TextChanged(object sender, EventArgs e)
        {
            // Aici puteți adăuga logica pentru evenimentul text modificat pentru câmpul de utilizator (dacă este necesar)
        }

        private void Parola_TextChanged(object sender, EventArgs e)
        {
            // Aici puteți adăuga logica pentru evenimentul text modificat pentru câmpul de parolă (dacă este necesar)
        }

  

        private bool CheckCredentials(string username, string password)
        {
            string filePath = "accounts.txt";

            // Verificăm dacă fișierul există
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Fișierul cu conturi nu există!");
                return false;
            }

            // Citim fișierul pentru a verifica credențialele
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                string storedUsername = parts[0];
                string storedPassword = parts[1];

                // Verificăm dacă numele de utilizator și parola introduse corespund cu cele din fișier
                if (username == storedUsername && password == storedPassword)
                {
                    return true;
                }
            }

            return false; // Autentificare eșuată
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

            if (CheckCredentials(username, password))
            {
                // Salvăm numele de utilizator introdus
                currentUsername = username;

                // Închideți Form1
                this.Hide();

                // Deschideți Form2
                joc form2 = new joc();
                form2.ShowDialog(); // Afișați Form2 ca un dialog modal

            }
            else
            {
                MessageBox.Show("Numele de utilizator sau parola incorecte!");
            }
        }
    }
}
