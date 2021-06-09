using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{
    public partial class Form1 : Form
    {
        
        int playerGold = 0;
        int AttackDMG = 1;
        int MonstersHp = 100;



        public Form1()
        {
            InitializeComponent();
        }

        private void label_NofClicks_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click1_Click(object sender, EventArgs e)
        {
            playerGold += 1;
            textBox_Gold.Text = playerGold.ToString();
            button2_Click2.Enabled = true;  
            button1_Click1.Enabled = false;
            button3_start.Enabled = false;
            if (playerGold >= 1000)
            {
                button_Upgrade.Enabled = true;
            }
            else
            {
                button_Upgrade.Enabled = false;
            }
        }

        private void button3_start_Click(object sender, EventArgs e)
        {
            button1_Click1.Enabled = true;
            button_DealDMG.Enabled = true;
            textBoxCurrentDMG.Text = AttackDMG.ToString();
        }

        private void button2_Click2_Click(object sender, EventArgs e)
        {
            playerGold += 1;
            textBox_Gold.Text = playerGold.ToString();
            button1_Click1.Enabled = true;
            button2_Click2.Enabled = false;
            if (playerGold >= 1000)
            {
                button_Upgrade.Enabled = true;
            }
            else
            {
                button_Upgrade.Enabled = false;
            }

        }

        private void button4_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_MonstersHP_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_DealDMG_Click(object sender, EventArgs e)
        {
            MonstersHp = MonstersHp - AttackDMG;
            textBox_MonstersHP.Text = MonstersHp.ToString();
            if(MonstersHp<=0)
            {
                playerGold += 50;
                MonstersHp = 100;
                MonstersHp += 50;
            }
        }

        private void label_MonstersHP_Click(object sender, EventArgs e)
        {
            
        }

        private void button_Upgrade_Click(object sender, EventArgs e)
        {
            playerGold -= 1000;
            AttackDMG += 1;

        }

        private void textBox_Gold_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox_MonstersHP_TextChanged(object sender, EventArgs e)
        {
           
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
