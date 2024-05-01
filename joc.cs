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




namespace proiect
{
    public partial class joc : Form
    {
        public joc()
        {
            InitializeComponent();
        }

        private void settings_Click(object sender, EventArgs e)
        {

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
            Level1 level1= new Level1();
            level1.Show();
        }
        private void nivel2_Click(object sender, EventArgs e)
        {

         

            this.Hide();
            Level2 level = new Level2();
            level.Show();
            level.Level2_Load_1(sender, e);
            
            
           
            
        }

        private void nivel3_Click(object sender, EventArgs e)
        {
            
        }

      

        private void joc_Load(object sender, EventArgs e)
        {

        }
        
    }
}
