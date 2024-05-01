using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace proiect
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        DBAccess objDBAccess = new DBAccess();
       

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
            // Aici puteți adăuga logica pentru încărcarea formularului (dacă este necesar)
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string usernameValue = password.Text;
            string passwordValue = username.Text;
            string emailValue = email.Text;

            // Validare dacă câmpurile sunt completate
            if (string.IsNullOrWhiteSpace(usernameValue) || string.IsNullOrWhiteSpace(passwordValue) || string.IsNullOrWhiteSpace(emailValue))
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }
            else
            {
               
                SqlCommand insertCommand = new SqlCommand("insert into Cont(Username,Password,Email) values (@usernameValue, @passwordValue, @emailValue)");
                insertCommand.Parameters.AddWithValue("@usernameValue", usernameValue);
                insertCommand.Parameters.AddWithValue("@passwordValue", passwordValue);
                insertCommand.Parameters.AddWithValue("@emailValue", emailValue);

                int row = objDBAccess.executeQuery(insertCommand);
                if (row == 1)
                {
                    MessageBox.Show("Account created successfully!");
                    objDBAccess.closeConn();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error!");
                }
                
            }

            // Salvare date în fișierul accounts.txt
            //string filePath = "accounts.txt";
            //try
            //{
            //  using (StreamWriter writer = File.AppendText(filePath))
            //{
            //  writer.WriteLine($"{passwordValue},{usernameValue},{emailValue}");

            //}
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Eroare la salvarea datelor: {ex.Message}");
            //}
         ;



        }
    }
}
