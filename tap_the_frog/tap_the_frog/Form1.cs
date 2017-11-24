using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tap_the_frog
{
    public partial class Form1 : Form
    {
        Random random;
        int score = 0;
        int max_score = 0;
        int lives = 3;
        int time_counter = 0;
        int change_counter = 15;
        bool play = false;
        bool clicked = true;

        public Form1()
        {
            InitializeComponent();
            frog.Parent = pond;
            pictureBox1.Parent = pond;
            redfrog.Parent = pond;
            label1.Parent = pond;
        }
        
        
        private void timer1_Tick(object sender, EventArgs e)
        {

            if(play)
            {
                
                if (clicked == false)
                {
                    lives--;
                }
                int det_frog = random.Next(1, 4);
                if(det_frog != 1)
                {
                    redfrog.Visible = false;
                    clicked = false;
                    frog.Size = new Size(141, 132);
                    int det_size = random.Next(1, 10);
                    switch (det_size)
                    {
                        case 1:
                            frog.Size = new Size(frog.Width -= frog.Width * 25 / 100, frog.Height -= frog.Height * 25 / 100);
                            break;
                        case 2:
                            frog.Size = new Size(frog.Width -= frog.Width * 40 / 100, frog.Height -= frog.Height * 40 / 100);
                            break;
                        case 3:
                            frog.Size = new Size(frog.Width -= frog.Width * 55 / 100, frog.Height -= frog.Height * 55 / 100);
                            break;
                    }
                    frog.Location = new Point(random.Next(pond.Location.X, pond.Width - frog.Width), random.Next(pond.Location.Y, pond.Height - frog.Height));
                    frog.Visible = true;
                }
                else
                {
                    frog.Visible = false;
                    redfrog.Size = new Size(141, 132);
                    int det_size = random.Next(1, 10);
                    switch (det_size)
                    {
                        case 1:
                            redfrog.Size = new Size(redfrog.Width -= redfrog.Width * 25 / 100, redfrog.Height -= redfrog.Height * 25 / 100);
                            break;
                        case 2:
                            redfrog.Size = new Size(redfrog.Width -= redfrog.Width * 40 / 100, redfrog.Height -= redfrog.Height * 40 / 100);
                            break;
                        case 3:
                            redfrog.Size = new Size(redfrog.Width -= redfrog.Width * 55 / 100, redfrog.Height -= redfrog.Height * 55 / 100);
                            break;
                    }
                    redfrog.Location = new Point(random.Next(pond.Location.X, pond.Width - redfrog.Width), random.Next(pond.Location.Y, pond.Height - redfrog.Height));
                    redfrog.Visible = true;
                    clicked = true;
                }
            }
            if(lives <= 1)
            {
                //allagh xromatos sto lives 1
                label3.ForeColor = Color.Red;
            }

            if (lives < 1)
            {
                label3.Text = "0";
                game_over();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(play)
            {
                score = time_counter;
                time_counter++;
                if (label4.Visible == true)
                {
                    label4.Visible = false;
                }
                if (time_counter > change_counter)
                {
                    lives++;
                    if (lives > 1)
                    {
                        //allagh xromatos sto lives 1
                        label3.ForeColor = Color.Yellow;
                    }
                    label4.Visible = true;
                    change_counter += change_counter;
                    timer1.Interval -= timer1.Interval * 10 / 100;
                }
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            random = new Random();
            pictureBox1.Visible = false;
            label1.Visible = false;
            timer1.Start();
            timer2.Start();
            timer3.Start();
            play = true;
        }

        private void redfrog_Click(object sender, EventArgs e)
        {
            redfrog.Visible = false;
            lives--;
        }

        private void redfrog_MouseHover(object sender, EventArgs e)
        {

        }

        private void frog_Click(object sender, EventArgs e)
        {
            frog.Visible = false;
            clicked = true;
        }

        private void frog_MouseHover(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label2.Text = score.ToString();
            label3.Text = lives.ToString();
        }

        private void game_over()
        {
            play = false;
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            frog.Visible = false;
            redfrog.Visible = false;
            pictureBox1.Visible = true;
            if(score > max_score)
            {
                max_score = score;
            }
            highscore.Text = max_score.ToString();
            label3.ForeColor = Color.Yellow;
            label1.Text = "score: " + score.ToString();
            label1.Visible = true;
            lives = 3;
            score = time_counter = 0;           
        }

        private void pond_MouseHover(object sender, EventArgs e)
        {
        }

        private void pond_MouseEnter(object sender, EventArgs e)
        {
        }
        private void pond_MouseLeave(object sender, EventArgs e)
        {
        }

        private void pond_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
