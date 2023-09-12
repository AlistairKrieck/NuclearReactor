using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;


namespace reactor2
{
    public partial class Form1 : Form
    {
        int loop = 0;

        public Form1()
        {
            InitializeComponent();
            
        }

   
        private void reactor1Image_Click(object sender, EventArgs e)
        {
           
        }

        private void reactorStart_Click(object sender, EventArgs e)
        {
          
            outputLabel.Text = "Ah, what a wonderful day to be alive";
                   Refresh();
            Thread.Sleep(1500);
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.alert);
            alertPlayer.Play();
            reactor1Image.BackColor = Color.Red;
            reactor2Image.BackColor = Color.Red;
            outputLabel.Text = "Huh?";
            Refresh();
            Thread.Sleep(1000);
            reactor1Image.BackColor = Color.Green;
            reactor2Image.BackColor = Color.Green;
            for (int i = 0; i < 3; i++)
            {
                reactor1Image.BackColor = Color.Red;
                reactor2Image.BackColor = Color.Red;
                Refresh();
                Thread.Sleep(1000);
                reactor1Image.BackColor = Color.Green;
                reactor2Image.BackColor = Color.Green;
                Refresh();
                Thread.Sleep(1000);
            }
            

         while (loop == 0) 
            {
                reactor1Image.BackColor = Color.Red;
                reactor2Image.BackColor = Color.Red;
                outputLabel.Text = "AHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH";
                Refresh();
                Thread.Sleep(1000);
                reactor1Image.BackColor = Color.Green;
                reactor2Image.BackColor = Color.Green;
                Refresh();
                Thread.Sleep(1000);
                reactor1Image.BackColor = Color.Red;
                reactor2Image.BackColor = Color.Red;
                outputLabel.Text = "WERE ALL GONNA DIE";
                Refresh();
                Thread.Sleep(1000);
                reactor1Image.BackColor = Color.Green;
                reactor2Image.BackColor = Color.Green;
                Refresh();
                Thread.Sleep(1000);
                reactor1Image.BackColor = Color.Red;
                reactor2Image.BackColor = Color.Red;
                outputLabel.Text = "I'M TOO YOUNG TO GO";
                Refresh();
                Thread.Sleep(1000);
                reactor1Image.BackColor = Color.Green;
                reactor2Image.BackColor = Color.Green;
                Refresh();
                Thread.Sleep(1000);
                reactor1Image.BackColor = Color.Red;
                reactor2Image.BackColor = Color.Red;
                outputLabel.Text = "WHO WILL FEED MY FAMILY???";
                Refresh();
                Thread.Sleep(1000);
                reactor1Image.BackColor = Color.Green;
                reactor2Image.BackColor = Color.Green;
                Refresh();
                Thread.Sleep(1000);
            }
            
           
        }

        private void reactor2Image_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
