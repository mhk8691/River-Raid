using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace River_Raid
{
    public partial class Form2 : Form
    {

        void tirplayer()
        {
            int playerX = player.Location.X;
            int playerY = player.Location.Y;

            int tirX = tir.Location.X;
            int tirY = tir.Location.Y;


            tirY -= 10;

            tir.Location = new Point(tirX, tirY);
            tir.Visible = true;
            if (tirY < -20)
            {
                int tirYplayer = playerY;
                tirYplayer += 32;
                int tirXplayer = playerX;
                tirXplayer += 51;
                tir.Location = new Point(tirXplayer, tirYplayer);
                shoting = false;
                tir.Visible = false;
            }
        }

        bool shoting = false;
        public Form2()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            timer5.Start();


        }

        int enemyspeed = 5;
        int myscore = 0;
        int ghalb = 3;
        int ghost = 0;
        int ghost2 = 0;

        void ghalbgame()
        {
            if (ghalb == 2)
            {

                int ghalbX = ghalb4.Location.X;
                int ghalbY = ghalb4.Location.Y;
                ghalbY += 10;
                ghalb4.Location = new Point(ghalbX, ghalbY);

                ghalb4.Visible = true;
                if (ghalbY > this.Size.Height)
                {
                    Random rnd = new Random();
                    int randomNumber = rnd.Next(100, 700);

                    int randomY = rnd.Next(-6000, -5000);

                    ghalb4.Location = new Point(randomNumber, randomY);
                }

                if (player.Bounds.IntersectsWith(ghalb4.Bounds))
                {
                    ghalb++;
                    ghalb3.Visible = true;
                    ghalb4.Visible = false;

                    ghalb4.Location = new Point(Location.X, -2000);
                }



            }

            if (ghalb == 1)
            {
                int ghalbX = ghalb5.Location.X;
                int ghalbY = ghalb5.Location.Y;
                ghalbY += 10;
                ghalb5.Location = new Point(ghalbX, ghalbY);

                ghalb5.Visible = true;
                if (ghalbY > this.Size.Height)
                {
                    Random rnd = new Random();
                    int randomNumber = rnd.Next(100, 700);

                    int randomY = rnd.Next(-6000, -5000);

                    ghalb5.Location = new Point(randomNumber, randomY);
                }

                if (player.Bounds.IntersectsWith(ghalb5.Bounds))
                {
                    ghalb++;
                    ghalb2.Visible = true;
                    ghalb5.Visible = false;

                    ghalb5.Location = new Point(Location.X, -2000);
                }



            }
        }

        void stargame()
        {
            //star:
            int star1X = star1.Location.X;
            int star1Y = star1.Location.Y;
            star1Y += enemyspeed;
            star1.Location = new Point(star1X, star1Y);

            if (star1Y > this.Size.Height)
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(100, 200);

                int randomY = rnd.Next(-100, -50);

                star1.Location = new Point(randomNumber, randomY);
            }

            int star2X = star2.Location.X;
            int star2Y = star2.Location.Y;
            star2Y += enemyspeed;
            star2.Location = new Point(star2X, star2Y);

            if (star2Y > this.Size.Height)
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(250, 300);

                int randomY = rnd.Next(-200, -150);

                star2.Location = new Point(randomNumber, randomY);
            }

            int star3X = star3.Location.X;
            int star3Y = star3.Location.Y;
            star3Y += enemyspeed;
            star3.Location = new Point(star3X, star3Y);

            if (star3Y > this.Size.Height)
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(350, 450);

                int randomY = rnd.Next(-400, -300);

                star3.Location = new Point(randomNumber, randomY);
            }

            int star4X = star4.Location.X;
            int star4Y = star4.Location.Y;
            star4Y += enemyspeed;
            star4.Location = new Point(star4X, star4Y);

            if (star4Y > this.Size.Height)
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(500, 700);

                int randomY = rnd.Next(-500, -450);

                star4.Location = new Point(randomNumber, randomY);
            }
        }

        void enemy()
        {
            int playerX = player.Location.X;
            int playerY = player.Location.Y;

            int tirX = tir.Location.X;
            int tirY = tir.Location.Y;

            if (ghost % 2 == 0)
            {
                player.Image = Properties.Resources.player;
            }
            int enemy1X = enemy1.Location.X;
            int enemy1Y = enemy1.Location.Y;
            enemy1Y += enemyspeed;
            enemy1.Location = new Point(enemy1X, enemy1Y);

            if (enemy1Y > this.Size.Height)
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(100, 200);

                int randomY = rnd.Next(-300, -200);

                enemy1.Location = new Point(randomNumber, randomY);
            }

            int enemy2X = enemy2.Location.X;
            int enemy2Y = enemy2.Location.Y;
            enemy2Y += enemyspeed;
            enemy2.Location = new Point(enemy2X, enemy2Y);

            if (enemy2Y > this.Size.Height)
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(500, 700);

                int randomY = rnd.Next(-500, -400);

                enemy2.Location = new Point(randomNumber, randomY);
            }

            int enemy3X = enemy3.Location.X;
            int enemy3Y = enemy3.Location.Y;
            enemy3Y += enemyspeed;
            enemy3.Location = new Point(enemy3X, enemy3Y);

            if (enemy3Y > this.Size.Height)
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(301, 450);

                int randomY = rnd.Next(-400, -300);

                enemy3.Location = new Point(randomNumber, randomY);
            }

            if (enemy1.Bounds.IntersectsWith(tir.Bounds))
            {

                tir.Visible = false;
                Random rnd = new Random();
                int randomNumber = rnd.Next(100, 200);


                int randomY = rnd.Next(-500, -200);

                enemy1.Location = new Point(randomNumber, randomY);
                myscore += 2;
                label1.Text = myscore + "";
                int tirYplayer = playerY;
                tirYplayer += 32;
                int tirXplayer = playerX;
                tirXplayer += 51;
                tir.Location = new Point(tirXplayer, tirYplayer);
                shoting = false;
            }

            if (enemy2.Bounds.IntersectsWith(tir.Bounds))
            {
                tir.Visible = false;
                Random rnd = new Random();
                int randomNumber = rnd.Next(500, 700);


                int randomY = rnd.Next(-1500, -1000);



                enemy2.Location = new Point(randomNumber, randomY);
                myscore += 2;
                label1.Text = myscore + "";
                int tirYplayer = playerY;
                tirYplayer += 32;
                int tirXplayer = playerX;
                tirXplayer += 51;
                tir.Location = new Point(tirXplayer, tirYplayer);
                shoting = false;
            }

            if (enemy3.Bounds.IntersectsWith(tir.Bounds))
            {
                tir.Visible = false;
                Random rnd = new Random();
                int randomNumber = rnd.Next(301, 450);


                int randomY = rnd.Next(-700, -500);

                enemy3.Location = new Point(randomNumber, randomY);


                myscore += 2;
                label1.Text = myscore + "";
                int tirYplayer = playerY;
                tirYplayer += 32;
                int tirXplayer = playerX;
                tirXplayer += 51;
                tir.Location = new Point(tirXplayer, tirYplayer);
                shoting = false;
            }

            if (player.Bounds.IntersectsWith(enemy1.Bounds) && ghost % 2 == 0 && ghost2 % 2 == 0)
            {



                if (ghalb == 3)
                {
                    ghalb--;
                    ghalb3.Visible = false;

                }
                else if (ghalb == 2)
                {
                    ghalb--;
                    ghalb2.Visible = false;
                }





                else
                {

                    ghalb1.Visible = false;
                    ghalb--;

                }
                if (ghalb == 0)
                {
                    gameover.Visible = true;
                    timer1.Stop();
                    timer2.Stop();
                    myscore = 0;
                    enemyspeed = 5;
                }
                tir.Visible = false;


                timer1.Stop();
                timer2.Stop();
                timer3.Stop();

                enemyspeed = 5;
                player.Image = Properties.Resources.explosion_05;

            }

            else if (player.Bounds.IntersectsWith(enemy2.Bounds) && ghost % 2 == 0 && ghost2 % 2 == 0)
            {

                if (ghalb == 3)
                {
                    ghalb--;
                    ghalb3.Visible = false;

                }
                else if (ghalb == 2)
                {
                    ghalb--;
                    ghalb2.Visible = false;
                }

                else
                {
                    ghalb1.Visible = false;
                    ghalb--;
                }

                if (ghalb == 0)
                {
                    gameover.Visible = true;
                    timer1.Stop();
                    timer2.Stop();
                    myscore = 0;
                    enemyspeed = 5;
                }



                timer1.Stop();
                timer2.Stop();
                timer3.Stop();

                enemyspeed = 5;
                player.Image = Properties.Resources.explosion_05;
            }

            else if (player.Bounds.IntersectsWith(enemy3.Bounds) && ghost % 2 == 0 && ghost2 % 2 == 0)
            {

                if (ghalb == 3)
                {
                    ghalb--;
                    ghalb3.Visible = false;

                }
                else if (ghalb == 2)
                {
                    ghalb--;
                    ghalb2.Visible = false;
                }

                else
                {
                    ghalb1.Visible = false;
                    ghalb--;
                }
                if (ghalb == 0)
                {
                    gameover.Visible = true;
                    timer1.Stop();
                    timer2.Stop();
                    myscore = 0;
                    enemyspeed = 5;
                }



                timer1.Stop();
                timer2.Stop();
                timer3.Stop();

                enemyspeed = 5;
                player.Image = Properties.Resources.explosion_05;

            }



        }




        private void RiverRaid_KeyDown(object sender, KeyEventArgs e)
        {
            int playerX = player.Location.X;
            int playerY = player.Location.Y;

            int tirX = tir.Location.X;
            int tirY = tir.Location.Y;

            if (e.KeyCode == Keys.Right)
            {
                if (tir.Visible == false)
                {
                    tirX += 15;

                    tir.Location = new Point(tirX, tirY);
                }

                playerX += 15;
                player.Location = new Point(playerX, playerY);
                if (playerX > 844)
                {
                    if (tir.Visible == false)
                    {
                        tirX = 834;
                        tir.Location = new Point(tirX, tirY);

                    }
                    playerX = 834;
                    player.Location = new Point(playerX, playerY);
                }

            }
            else if (e.KeyCode == Keys.Left)
            {
                if (tir.Visible == false)
                {
                    tirX -= 15;

                    tir.Location = new Point(tirX, tirY);
                }

                playerX -= 15;

                player.Location = new Point(playerX, playerY);
                if (playerX < -10)
                {
                    if (tir.Visible == false)
                    {
                        tirX = 0;
                        tir.Location = new Point(tirX, tirY);

                    }
                    playerX = 0;

                    player.Location = new Point(playerX, playerY);

                }

            }

            else if (e.KeyCode == Keys.Up)
            {

                if (ghalb == 0)
                {


                    myscore = 0;
                    gameover.Visible = false;
                    label1.Text = myscore + "";
                    player.Image = Properties.Resources.player;
                    BackColor = Color.Cyan;
                    timer1.Start();
                    timer2.Start();
                    timer3.Start();
                    ghalb = 3;
                    ghalb1.Visible = true;
                    ghalb2.Visible = true;
                    ghalb3.Visible = true;
                    ghalb4.Visible = false;
                    ghalb5.Visible = false;
                    ghalb4.Location = new Point(Location.X, -2000);
                    ghalb5.Location = new Point(Location.X, -2000);
                    enemy1.Location = new Point(109, 137);
                    enemy2.Location = new Point(250, 12);
                    enemy3.Location = new Point(772, -73);
                }

            }
            else if (e.KeyCode == Keys.Down)
            {
                ghost++;


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            enemy();
            ghalbgame();

            stargame();

            if (shoting == true)
            {
                tirplayer();
            }

            if (myscore >= 20 && myscore < 30)
            {
                BackColor = Color.Black;
                label1.BackColor = Color.White;
                tir.Image = Properties.Resources.bullet2;
            }
            else if (myscore >= 30)
            {
                BackColor = Color.Cyan;
                tir.Image = Properties.Resources.bullet;
            }





        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            enemyspeed += 1;

        }



        private void timer3_Tick(object sender, EventArgs e)
        {
            myscore += 1;
            label1.Text = myscore + "";

        }

        private void mouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                shoting = true;
                tirplayer();

                //tir.Top = player.Top - 30;
                //tir.Left = player.Left + (player.Width / 2);


            }


        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (ghalb != 0)
            {
                if (player.Bounds.IntersectsWith(enemy1.Bounds) && ghost % 2 == 0 || player.Bounds.IntersectsWith(enemy2.Bounds) && ghost % 2 == 0 || player.Bounds.IntersectsWith(enemy3.Bounds) && ghost % 2 == 0)
                {

                    ghost2 = 1;
                    player.Image = Properties.Resources.player1;

                    label1.Text = myscore + "";

                    timer1.Start();
                    timer2.Start();
                    timer3.Start();



                }


            }



        }

        private void timer5_Tick(object sender, EventArgs e)
        {

            ghost2 = 0;
            player.Image = Properties.Resources.player;


        }




    }
}



