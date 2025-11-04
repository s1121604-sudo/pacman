using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PACMAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool goup,godown,goright,goieft = false;
        PictureBox[] pictureBoxes = new PictureBox[20];
        Panel[] panels;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (goup)
            {
                PACMAN.Top -= 5;
            }
            if (godown)
            {
                PACMAN.Top += 5;
            }
            if (goright)
            {
                PACMAN.Left -= 5;
            }
            if (goieft)
            {
                PACMAN.Left += 5;
            }
            for (int i = 0; i < 10; i++)
            {
                if (PACMAN.Bounds.IntersectsWith(pictureBoxes[i].Bounds))
                {
                    pictureBoxes[i].Visible = false;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (PACMAN.Bounds.IntersectsWith(panels[i].Bounds))
                {
                    goup = godown = goieft = goright = false;
                }
            }
            //if (PACMAN.Bounds.IntersectsWith(pictureBox1.Bounds))
            //{
            //    pictureBox1.Visible = false;
            //}
            //if (PACMAN.Bounds.IntersectsWith(pictureBox2.Bounds))
            //{
            //    pictureBox2.Visible = false;
            //}
            //if (PACMAN.Bounds.IntersectsWith(pictureBox3.Bounds))
            //{
            //    pictureBox3.Visible = false;
            //}
            //if (PACMAN.Bounds.IntersectsWith(pictureBox4.Bounds))
            //{
            //    pictureBox4.Visible = false;
            //}
            //if (PACMAN.Bounds.IntersectsWith(pictureBox5.Bounds))
            //{
            //    pictureBox5.Visible = false;
            //}
            //if (PACMAN.Bounds.IntersectsWith(pictureBox6.Bounds))
            //{
            //    pictureBox6.Visible = false;
            //}
            //if (PACMAN.Bounds.IntersectsWith(pictureBox7.Bounds))
            //{
            //    pictureBox7.Visible = false;
            //}
            //if (PACMAN.Bounds.IntersectsWith(pictureBox8.Bounds))
            //{
            //    pictureBox8.Visible = false;
            //}
            //if (PACMAN.Bounds.IntersectsWith(pictureBox9.Bounds))
            //{
            //    pictureBox9.Visible = false;
            //}
            //if (PACMAN.Bounds.IntersectsWith(pictureBox10.Bounds))
            //{
            //    pictureBox10.Visible = false;
            //}
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 5;
            timer1.Enabled = true;

            panels = new Panel[4]
            {
                panel1,panel2,panel3,panel4
            };
            
            pictureBoxes = new PictureBox[10]
            {
                pictureBox1,pictureBox2,pictureBox3,pictureBox4,pictureBox5,pictureBox6,pictureBox7,pictureBox8,pictureBox9,pictureBox10
            };
        }
        
            

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Up)
            //{
            //    goup = false;
            //}
            //if (e.KeyCode == Keys.Down)
            //{
            //    godown = false;
            //}
            //if (e.KeyCode == Keys.Left)
            //{
            //    goright = false;
            //}
            //if (e.KeyCode == Keys.Right)
            //{
            //    goieft = false;
            //}

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            goup = godown = goieft = goright = false;
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
                PACMAN.Image = Properties.Resources.pacmanup;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
                PACMAN.Image = Properties.Resources.pacmandown;
            }
            if (e.KeyCode == Keys.Left)
            {
                goright = true;
                PACMAN.Image = Properties.Resources.pacmanleft;
            }
            if (e.KeyCode == Keys.Right)
            {
                goieft = true;
                PACMAN.Image = Properties.Resources.pacman;
            }
            

        }
    }
}
