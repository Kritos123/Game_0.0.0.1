using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_0._0._0._1.Database_connection;
using Game_0._0._0._1.Game;
using Game_0._0._0._1.Player;

namespace Game_0._0._0._1
{
    public partial class Form1 : Form
    {
        Profil sl;
        Profil slk = new Profil();
        Save_Load spl = new Save_Load();
        int coins;
        public Form1()
        {
            InitializeComponent();
            //Start timer pro coins
            timer1.Start();
        }

       //Cliknutí na picturebox
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           if((label1.Text=="Level 0")&&(coins>=10))
            {
                sl = new Profil("Pepa", 1);
                label1.Text = sl.hl.Info;
                pictureBox1.BackColor = Color.Aquamarine;
                textBox1.Text = sl.ToString(); ;
                coins = coins -10;

            }
           else if(label1.Text == "Level 1")
            {

                sl = new Profil("Pepa", 2);
                label1.Text = sl.hl.Info;
                pictureBox1.BackColor = Color.Red;
                textBox1.Text = sl.ToString();
            }
            
        }
        // Co udělat pro každý Tick
        private void timer1_Tick(object sender, EventArgs e)
        {
            coins++;
            label2.Text = coins.ToString();
        }
    }
}
