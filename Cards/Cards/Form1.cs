using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int Score, Card1, Card2, Card3;

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            lScore.Text = "0";
            Score = 0;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Random firstCard = new Random();
            Card1 = firstCard.Next(1, 4);

            Random secondCard = new Random();
            Card2 = secondCard.Next(1, 3);


            switch (Card1)
            {

                case 1:
                    if (Card1 == 1)
                    {
                        pictureBox2.Image = Properties.Resources.Wrong1;

                        if (Card2 == 1)
                        {
                            pictureBox1.Image = Properties.Resources.Wrong2;
                            pictureBox3.Image = Properties.Resources.Correct;
                        }
                        else
                        {
                            pictureBox3.Image = Properties.Resources.Wrong2;
                            pictureBox1.Image = Properties.Resources.Correct;
                        }

                    }
                    break;

                case 2:
                    if (Card1 == 2)
                    {
                        pictureBox2.Image = Properties.Resources.Wrong2;

                        if (Card2 == 1)
                        {
                            pictureBox1.Image = Properties.Resources.Wrong1;
                            pictureBox3.Image = Properties.Resources.Correct;
                        }
                        else
                        {
                            pictureBox3.Image = Properties.Resources.Wrong1;
                            pictureBox1.Image = Properties.Resources.Correct;
                        }

                    }
                    break;

                case 3:
                    if (Card1 == 3)
                    {
                        pictureBox2.Image = Properties.Resources.Correct;

                        if (Card2 == 1)
                        {
                            pictureBox1.Image = Properties.Resources.Wrong1;
                            pictureBox3.Image = Properties.Resources.Wrong2;
                        }
                        else
                        {
                            pictureBox3.Image = Properties.Resources.Wrong1;
                            pictureBox1.Image = Properties.Resources.Wrong2;
                        }

                        Score++;
                        lScore.Text = Score.ToString();

                    }
                    break;

                    
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Random firstCard = new Random();
            Card1 = firstCard.Next(1, 4);

            Random secondCard = new Random();
            Card2 = secondCard.Next(1, 3);


            switch (Card1) //czy to ma jakiś większy sens, nwm, ctr+v, zabawa
            {

                case 1:
                    if (Card1 == 1)
                    {
                        pictureBox3.Image = Properties.Resources.Wrong1;

                        if (Card2 == 1)
                        {
                            pictureBox2.Image = Properties.Resources.Wrong2;
                            pictureBox1.Image = Properties.Resources.Correct;
                        }
                        else
                        {
                            pictureBox1.Image = Properties.Resources.Wrong2;
                            pictureBox2.Image = Properties.Resources.Correct;
                        }

                    }
                    break;

                case 2:
                    if (Card1 == 2)
                    {
                        pictureBox3.Image = Properties.Resources.Wrong2;

                        if (Card2 == 1)
                        {
                            pictureBox2.Image = Properties.Resources.Wrong1;
                            pictureBox1.Image = Properties.Resources.Correct;
                        }
                        else
                        {
                            pictureBox1.Image = Properties.Resources.Wrong1;
                            pictureBox2.Image = Properties.Resources.Correct;
                        }

                    }
                    break;

                case 3:
                    if (Card1 == 3)
                    {
                        pictureBox3.Image = Properties.Resources.Correct;

                        if (Card2 == 1)
                        {
                            pictureBox2.Image = Properties.Resources.Wrong1;
                            pictureBox1.Image = Properties.Resources.Wrong2;
                        }
                        else
                        {
                            pictureBox1.Image = Properties.Resources.Wrong1;
                            pictureBox2.Image = Properties.Resources.Wrong2;
                        }

                        Score++;
                        lScore.Text = Score.ToString();

                    }
                    break; 



            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/SHine221B");
        }

        private void bAgain_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Back;
            pictureBox3.Image = Properties.Resources.Back;
            pictureBox1.Image = Properties.Resources.Back;
        }

        private void lScore_Click(object sender, EventArgs e)
        {
            lScore.Text = Score.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random firstCard = new Random();
            Card1 = firstCard.Next(1, 4);

            Random secondCard = new Random();
            Card2 = secondCard.Next(1, 3);


            switch (Card1)
            {

                case 1:
                    if (Card1 == 1)
                    {
                        pictureBox1.Image = Properties.Resources.Wrong1;

                        if (Card2 == 1)
                        {
                            pictureBox2.Image = Properties.Resources.Wrong2;
                            pictureBox3.Image = Properties.Resources.Correct;
                        }
                        else
                        {
                            pictureBox3.Image = Properties.Resources.Wrong2;
                            pictureBox2.Image = Properties.Resources.Correct;
                        }
                    
                    }
                    break;

                case 2:
                    if (Card1 == 2)
                    {
                        pictureBox1.Image = Properties.Resources.Wrong2;

                        if (Card2 == 1)
                        {
                            pictureBox2.Image = Properties.Resources.Wrong1;
                            pictureBox3.Image = Properties.Resources.Correct;
                        }
                        else
                        {
                            pictureBox3.Image = Properties.Resources.Wrong1;
                            pictureBox2.Image = Properties.Resources.Correct;
                        }

                    }
                    break;

                case 3:
                    if (Card1 == 3)
                    {
                        pictureBox1.Image = Properties.Resources.Correct;

                        if (Card2 == 1)
                        {
                            pictureBox2.Image = Properties.Resources.Wrong1;
                            pictureBox3.Image = Properties.Resources.Wrong2;
                        }
                        else
                        {
                            pictureBox3.Image = Properties.Resources.Wrong1;
                            pictureBox2.Image = Properties.Resources.Wrong2;
                        }

                        Score++;
                        lScore.Text = Score.ToString();
                    }
                    break;



            }

        }
    }
} //uffffffffffffffffffffffffffffffffff...
//przydatność +1000000000;
