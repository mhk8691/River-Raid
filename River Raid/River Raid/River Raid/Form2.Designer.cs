namespace River_Raid
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            player = new PictureBox();
            enemy1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            enemy2 = new PictureBox();
            enemy3 = new PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            tir = new PictureBox();
            timer3 = new System.Windows.Forms.Timer(components);
            ghalb1 = new PictureBox();
            ghalb2 = new PictureBox();
            ghalb3 = new PictureBox();
            gameover = new Label();
            star1 = new PictureBox();
            star2 = new PictureBox();
            star3 = new PictureBox();
            star4 = new PictureBox();
            ghalb4 = new PictureBox();
            ghalb5 = new PictureBox();
            timer4 = new System.Windows.Forms.Timer(components);
            timer5 = new System.Windows.Forms.Timer(components);
            timer6 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ghalb1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ghalb2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ghalb3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ghalb4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ghalb5).BeginInit();
            SuspendLayout();
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.Image = Properties.Resources.player;
            player.Location = new Point(414, 436);
            player.Name = "player";
            player.Size = new Size(110, 98);
            player.SizeMode = PictureBoxSizeMode.AutoSize;
            player.TabIndex = 0;
            player.TabStop = false;
            // 
            // enemy1
            // 
            enemy1.BackColor = Color.Transparent;
            enemy1.Image = Properties.Resources.enemy;
            enemy1.Location = new Point(109, 138);
            enemy1.Name = "enemy1";
            enemy1.Size = new Size(100, 85);
            enemy1.SizeMode = PictureBoxSizeMode.AutoSize;
            enemy1.TabIndex = 1;
            enemy1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 15;
            timer1.Tick += timer1_Tick;
            // 
            // enemy2
            // 
            enemy2.BackColor = Color.Transparent;
            enemy2.Image = Properties.Resources.images_PhotoRoom3;
            enemy2.Location = new Point(474, 12);
            enemy2.Name = "enemy2";
            enemy2.Size = new Size(105, 89);
            enemy2.SizeMode = PictureBoxSizeMode.AutoSize;
            enemy2.TabIndex = 2;
            enemy2.TabStop = false;
            // 
            // enemy3
            // 
            enemy3.BackColor = Color.Transparent;
            enemy3.Image = Properties.Resources.images_PhotoRoom4;
            enemy3.Location = new Point(772, -73);
            enemy3.Name = "enemy3";
            enemy3.Size = new Size(109, 89);
            enemy3.SizeMode = PictureBoxSizeMode.AutoSize;
            enemy3.TabIndex = 3;
            enemy3.TabStop = false;
            // 
            // timer2
            // 
            timer2.Interval = 7000;
            timer2.Tick += timer2_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(28, 32);
            label1.TabIndex = 4;
            label1.Text = "0";
            // 
            // tir
            // 
            tir.BackColor = Color.Transparent;
            tir.Image = Properties.Resources.bullet;
            tir.Location = new Point(465, 403);
            tir.Name = "tir";
            tir.Size = new Size(7, 27);
            tir.SizeMode = PictureBoxSizeMode.AutoSize;
            tir.TabIndex = 5;
            tir.TabStop = false;
            tir.Visible = false;
            // 
            // timer3
            // 
            timer3.Interval = 5000;
            timer3.Tick += timer3_Tick;
            // 
            // ghalb1
            // 
            ghalb1.BackColor = Color.Transparent;
            ghalb1.Image = Properties.Resources.ship_0006;
            ghalb1.Location = new Point(8, 12);
            ghalb1.Name = "ghalb1";
            ghalb1.Size = new Size(32, 32);
            ghalb1.SizeMode = PictureBoxSizeMode.AutoSize;
            ghalb1.TabIndex = 6;
            ghalb1.TabStop = false;
            // 
            // ghalb2
            // 
            ghalb2.BackColor = Color.Transparent;
            ghalb2.Image = Properties.Resources.ship_0006;
            ghalb2.Location = new Point(46, 12);
            ghalb2.Name = "ghalb2";
            ghalb2.Size = new Size(32, 32);
            ghalb2.SizeMode = PictureBoxSizeMode.AutoSize;
            ghalb2.TabIndex = 7;
            ghalb2.TabStop = false;
            // 
            // ghalb3
            // 
            ghalb3.BackColor = Color.Transparent;
            ghalb3.Image = Properties.Resources.ship_0006;
            ghalb3.Location = new Point(84, 12);
            ghalb3.Name = "ghalb3";
            ghalb3.Size = new Size(32, 32);
            ghalb3.SizeMode = PictureBoxSizeMode.AutoSize;
            ghalb3.TabIndex = 8;
            ghalb3.TabStop = false;
            // 
            // gameover
            // 
            gameover.AutoSize = true;
            gameover.BackColor = Color.Black;
            gameover.Font = new Font("Swis721 Blk BT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            gameover.ForeColor = Color.Red;
            gameover.Location = new Point(414, 213);
            gameover.Name = "gameover";
            gameover.Size = new Size(165, 29);
            gameover.TabIndex = 9;
            gameover.Text = "Game over!";
            gameover.Visible = false;
            // 
            // star1
            // 
            star1.BackColor = Color.Transparent;
            star1.Image = Properties.Resources.tile_0006;
            star1.Location = new Point(373, 28);
            star1.Name = "star1";
            star1.Size = new Size(16, 16);
            star1.SizeMode = PictureBoxSizeMode.AutoSize;
            star1.TabIndex = 10;
            star1.TabStop = false;
            // 
            // star2
            // 
            star2.BackColor = Color.Transparent;
            star2.Image = Properties.Resources.tile_0006;
            star2.Location = new Point(46, 256);
            star2.Name = "star2";
            star2.Size = new Size(16, 16);
            star2.SizeMode = PictureBoxSizeMode.AutoSize;
            star2.TabIndex = 11;
            star2.TabStop = false;
            // 
            // star3
            // 
            star3.BackColor = Color.Transparent;
            star3.Image = Properties.Resources.tile_0006;
            star3.Location = new Point(299, 324);
            star3.Name = "star3";
            star3.Size = new Size(16, 16);
            star3.SizeMode = PictureBoxSizeMode.AutoSize;
            star3.TabIndex = 14;
            star3.TabStop = false;
            // 
            // star4
            // 
            star4.BackColor = Color.Transparent;
            star4.Image = Properties.Resources.tile_0006;
            star4.Location = new Point(737, 269);
            star4.Name = "star4";
            star4.Size = new Size(16, 16);
            star4.SizeMode = PictureBoxSizeMode.AutoSize;
            star4.TabIndex = 17;
            star4.TabStop = false;
            // 
            // ghalb4
            // 
            ghalb4.BackColor = Color.Transparent;
            ghalb4.Image = Properties.Resources.ship_0006;
            ghalb4.Location = new Point(621, -2000);
            ghalb4.Name = "ghalb4";
            ghalb4.Size = new Size(32, 32);
            ghalb4.SizeMode = PictureBoxSizeMode.AutoSize;
            ghalb4.TabIndex = 18;
            ghalb4.TabStop = false;
            ghalb4.Visible = false;
            // 
            // ghalb5
            // 
            ghalb5.BackColor = Color.Transparent;
            ghalb5.Image = Properties.Resources.ship_0006;
            ghalb5.Location = new Point(186, -1500);
            ghalb5.Name = "ghalb5";
            ghalb5.Size = new Size(32, 32);
            ghalb5.SizeMode = PictureBoxSizeMode.AutoSize;
            ghalb5.TabIndex = 19;
            ghalb5.TabStop = false;
            // 
            // timer4
            // 
            timer4.Interval = 1000;
            timer4.Tick += timer4_Tick;
            // 
            // timer5
            // 
            timer5.Interval = 2000;
            timer5.Tick += timer5_Tick;
            // 
            // timer6
            // 
            timer6.Interval = 1000;
            timer6.Tick += timer6_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            BackgroundImage = Properties.Resources.purple;
            ClientSize = new Size(943, 546);
            Controls.Add(ghalb5);
            Controls.Add(ghalb4);
            Controls.Add(star4);
            Controls.Add(star3);
            Controls.Add(star2);
            Controls.Add(star1);
            Controls.Add(gameover);
            Controls.Add(ghalb3);
            Controls.Add(ghalb2);
            Controls.Add(ghalb1);
            Controls.Add(tir);
            Controls.Add(label1);
            Controls.Add(enemy3);
            Controls.Add(enemy2);
            Controls.Add(enemy1);
            Controls.Add(player);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form2";
            Text = "River Raid";
            KeyDown += RiverRaid_KeyDown;
            MouseDown += mouseDown;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy3).EndInit();
            ((System.ComponentModel.ISupportInitialize)tir).EndInit();
            ((System.ComponentModel.ISupportInitialize)ghalb1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ghalb2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ghalb3).EndInit();
            ((System.ComponentModel.ISupportInitialize)star1).EndInit();
            ((System.ComponentModel.ISupportInitialize)star2).EndInit();
            ((System.ComponentModel.ISupportInitialize)star3).EndInit();
            ((System.ComponentModel.ISupportInitialize)star4).EndInit();
            ((System.ComponentModel.ISupportInitialize)ghalb4).EndInit();
            ((System.ComponentModel.ISupportInitialize)ghalb5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox player;
        private PictureBox enemy1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox enemy2;
        private PictureBox enemy3;
        private PictureBox explosion;
        private System.Windows.Forms.Timer timer2;
        private Label label1;
        private PictureBox tir;
        private System.Windows.Forms.Timer timer3;
        private PictureBox ghalb1;
        private PictureBox ghalb2;
        private PictureBox ghalb3;
        private Label gameover;
        private PictureBox star1;
        private PictureBox star2;
        private PictureBox star3;
        private PictureBox star4;
        private PictureBox ghalb4;
        private PictureBox ghalb5;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
    }
}