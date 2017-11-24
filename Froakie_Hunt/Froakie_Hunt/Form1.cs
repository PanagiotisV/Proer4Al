using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Froakie_Hunt
{
    public partial class Form1 : Form
    {
        Random random;

        int score = 0;
        int highscore = 0;
        int chances = 2;
        int time = 60;

        bool play = false;




        public Form1()
        {
            InitializeComponent();

            pictureBox1.Parent = this;
            pictureBox2.Parent = this;
            pictureBox3.Parent = this;
            pictureBox4.Parent = this;
            
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;

            label5.Text = highscore.ToString();
            label6.Text = score.ToString();
            label7.Text = time.ToString();
            label8.Text = chances.ToString();


        }





        //Game Starts on clicking the ball
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            random = new Random();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = false;

            timer1.Start();
            timer2.Start();
            play = true;
        }





                                                                                //Timers for froggys
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (play)
            {
                int frog = random.Next(1, 5);                                   //froakie image shows up
                if (frog == 1)
                {
                    pictureBox3.Visible = true;
                    pictureBox3.Location = new Point(random.Next(this.Location.X, this.Width - pictureBox4.Width), random.Next(this.Location.Y, this.Height - pictureBox4.Height));
                    timer1.Stop();
                    timer4.Start();                                             //timer starts for how long it will appear
                }
                



                else if(frog == 3)
                {
                    pictureBox2.Visible = true;                                 //fake froakie
                    pictureBox2.Location = new Point(random.Next(this.Location.X, this.Width - pictureBox4.Width), random.Next(this.Location.Y, this.Height - pictureBox4.Height));
                    timer1.Stop();
                    timer5.Start();                                             //timer starts for how long it will appear
                }





                int rare = random.Next(1, 20);
                if (rare == 2)
                {
                    pictureBox4.Visible = true;                                 //rare frog!!!!!
                    pictureBox4.Location = new Point(random.Next(this.Location.X, this.Width - pictureBox4.Width), random.Next(this.Location.Y, this.Height - pictureBox4.Height));
                    timer1.Stop();
                    timer3.Start();                                             //timer starts for how long it will appear
                }
            }
        }













                                                                          //the images vanish after a short time
        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            timer1.Start();
            timer3.Stop();
        }

        private void timer4_Tick_1(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            timer1.Start();
            timer4.Stop();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            timer1.Start();
            timer5.Stop();
        }






                                                                        //time goes down as we play the game
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (play)
            {
                time--;
                label6.Text = score.ToString();
                label7.Text = time.ToString();
                label8.Text = chances.ToString();

                if ((time == 0)||(chances < 1))
                {
                    gameover();
                }
            }
        }


        private void gameover()
        {
            play = false;

            pictureBox1.Visible = true;
            pictureBox1.Location = new Point(410, 75);
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;

            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();

            label2.Visible = true;
            label6.Visible = true;
            label9.Text = "score: " + score.ToString();
            label9.Visible = true;
            
            if (score > highscore)
            {
                highscore = score;
                label5.Text = highscore.ToString();
            }

            chances = 3;
            score = 0;
            time = 60;
        }















        //Events on clicking froggys
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            chances--;
            pictureBox2.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            score++;
            pictureBox3.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            score += 10;
            pictureBox4.Visible = false;
        }




        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }






        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


              





        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
