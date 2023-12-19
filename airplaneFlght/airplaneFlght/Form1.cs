using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airplaneFlght
{
    public partial class Form1 : Form
    {
        static int[] StepX = new int [999];
        List<PictureBox> bullets = new List<PictureBox>();
        List<PictureBox> enemy = new List<PictureBox>();
        int n = 0,Score=0;
        
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.SetBounds(0, 0, 800, 600);
            Air.Left = (this.Width - Air.Width) / 2;
            Air.Top = (this.Height - Air.Height)-50;
            timer1.Enabled = false;
            Air.Visible = false;
            score.Visible = false;
            time.Visible = false;
        }
        
        public void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            button1.Visible = false;
            Air.Visible = true;
            score.Visible = true;
            time.Visible = true;
            timer1.Enabled=true;
            time.Text = textBox1.Text;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Focus();
            if (n==0)
            {
                newene();
            }
            enemov();
            bobmov();
            double Time = double.Parse(time.Text);
            if (Time <= 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("GAME OVER");
                Form1 newWindow = new Form1();
                newWindow.Show();

                this.Hide();
            }
            else
            {
                Time -= 0.1;
                time.Text = Time.ToString("F1"); // 保持一位小數
            }

            for (int i = 0; i < bullets.Count; i++)
            {
                if(isOverlap(bullets[i].Bounds,enemy[n-1].Bounds))
                {
                    enemy[n - 1].Hide();
                    n += 1;
                    Score += 1;
                    score.Text = "" + Score.ToString();
                    newene();
                    /*timer1.Enabled = false;
                    MessageBox.Show("GAME OVER");
                    Form1 newWindow = new Form1();
                    newWindow.Show();

                    this.Hide();*/
                } 
            }
        }
        bool isOverlap(Rectangle r1,Rectangle r2)
        {
            if(r1.Left>r2.Left && r1.Left>r2.Right)
            {
                if (r1.Top > r2.Top && r1.Top <r2.Bottom)
                {
                    return true;
                }
            }
        return false;
        }
        public void enemov()
        { 
            for (int i = 0; i < enemy.Count; i++)
            {
                if (enemy[i].Right >= this.ClientSize.Width)
                {
                    StepX[i] = -1 * StepX[i];
                }
                if (enemy[i].Right <= 0)
                {
                    StepX[i] = -1 * StepX[i];
                }
                enemy[i].Left += StepX[i];
            }
        }
        public void bobmov()
        {
            for (int i = 0; i < bullets.Count; i++)
            {
                bullets[i].Top -= 10;
                if (bullets[i].Top <= 100)
                {
                    this.Controls.Remove(bullets[i]);
                    bullets.RemoveAt(i);
                    i--;
                    continue;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Space))
            {
                newBullet();
            }
            if (e.KeyCode.Equals(Keys.Escape))
            {
                Application.Exit();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                Air.Left -= 10;
            }
            else if (e.KeyCode.Equals(Keys.Right))
            {
                Air.Left += 10;
            }
            else if (e.KeyCode.Equals(Keys.Up))
            {
                Air.Top -= 10;
            }
            else if (e.KeyCode.Equals(Keys.Down))
            {
                Air.Top+=10;
            }
        }
        public void newBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.Image = bob.Image;
            bullet.Size = bob.Size;
            bullet.Left = (Air.Left + Air.Right - bullet.Width) / 2;
            bullet.Top = Air.Top;

            this.Controls.Add(bullet);
            this.Controls.SetChildIndex(bullet, 0);
            bullet.Visible  = true;
            bullets.Add(bullet);

        }
        public void newene()
        {
            if (n == 0)
            {
                n += 1;
            }
            PictureBox ene = new PictureBox();
            ene.Image = Enemy.Image;
            ene.Size = Enemy.Size;
            ene.Left = random.Next(0, this.Width - ene.Width); // X 軸隨機位置
            ene.Top = Enemy.Top;

            this.Controls.Add(ene);
            this.Controls.SetChildIndex(ene, 0);
            ene.Visible = true;
            enemy.Add(ene);
            StepX[enemy.Count - 1] = 10;
        }
    }
}
