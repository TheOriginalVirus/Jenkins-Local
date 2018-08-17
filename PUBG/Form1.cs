using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUBG
{
    public partial class Form1 : Form
    {
        public int ARcount = 0;
        public int ARScopeCount = 0;
        public int ARMagCount = 0;
        public int ARMuzCount = 0;
        public int ARGripCount = 0;
        public Form1()
        {
            InitializeComponent();
            this.pictureBox1.MouseWheel += pictureBox1_MouseWheel;
            this.pictureBox2.MouseWheel += pictureBox2_MouseWheel;
            this.pictureBox3.MouseWheel += pictureBox3_MouseWheel;
            this.pictureBox4.MouseWheel += pictureBox4_MouseWheel;
            this.pictureBox5.MouseWheel += pictureBox5_MouseWheel;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Focus();

        }
        private void pictureBox2_MouseWheel(object sender, MouseEventArgs e)
        {

            //TOP
            if (e.Delta > 0 && ARScopeCount != 0)
            {
                ARScopeCount--;
                pictureBox2.Image = ARScope.Images[ARScopeCount];

                if (ARcount == 2 && ARScopeCount == 4)
                {
                    ARScopeCount = 3;
                    pictureBox2.Image = ARScope.Images[ARScopeCount];
                }
                else if (ARcount == 1 && ARScopeCount == 5)
                {
                    ARScopeCount = 3;
                    pictureBox2.Image = ARScope.Images[ARScopeCount];
                }
                else if (ARcount == 2 && ARScopeCount == 5)
                {
                    ARScopeCount = 3;
                    pictureBox2.Image = ARScope.Images[ARScopeCount];
                }
            }
            else if (e.Delta > 0 && ARScopeCount == 0)
            {

                if (ARcount == 1 | ARcount == 2)
                {
                    ARScopeCount = 3;
                    pictureBox2.Image = ARScope.Images[ARScopeCount];
                }
                else
                {
                    ARScopeCount = 5;
                    pictureBox2.Image = ARScope.Images[ARScopeCount];
                }
            }

            //BOTTOM
            if (e.Delta < 0 && ARScopeCount != 5)
            {

                ARScopeCount++;
                pictureBox2.Image = ARScope.Images[ARScopeCount];


                if (ARcount == 1 && ARScopeCount == 5)
                {
                    ARScopeCount = 0;
                    pictureBox2.Image = ARScope.Images[ARScopeCount];
                }
                else if (ARcount == 2 && ARScopeCount == 4)
                {
                    ARScopeCount = 0;
                    pictureBox2.Image = ARScope.Images[ARScopeCount];
                }


            }
            else if (e.Delta < 0 && ARScopeCount == 5)
            {
                ARScopeCount = 0;
                pictureBox2.Image = ARScope.Images[ARScopeCount];

            }


        }


        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            //TOP
            if (e.Delta > 0 && ARcount != 0)
            {
                ARcount--;
                pictureBox1.Image = AR.Images[ARcount];
            }
            else if (e.Delta > 0 && ARcount == 0)
            {
                ARcount = 5;
                pictureBox1.Image = AR.Images[ARcount];
            }
            //BOTTOM
            if (e.Delta < 0 && ARcount != 5)
            {
                ARcount++;
                pictureBox1.Image = AR.Images[ARcount];
            }
            else if (e.Delta < 0 && ARcount == 5)
            {
                ARcount = 0;
                pictureBox1.Image = AR.Images[ARcount];
            }

            if (ARcount == 2)
            {
                ARMuzs.Hide();
                //ARMag.Left = 14;
            }
            else
            {
                ARMuzs.Show();
                //ARMag.Left = 154;
            }

            if (ARcount == 0 | ARcount == 2 | ARcount == 4)
            {
                ARGrips.Hide();
            }
            else
            {
                ARGrips.Show();
            }
        }

        private void pictureBox3_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && ARMagCount != 0)
            {
                ARMagCount--;
                pictureBox3.Image = ARMags.Images[ARMagCount];
            }
            else if (e.Delta > 0 && ARMagCount == 0)
            {
                ARMagCount = 2;
                pictureBox3.Image = ARMags.Images[ARMagCount];
            }
            //BOTTOM
            if (e.Delta < 0 && ARMagCount != 2)
            {
                ARMagCount++;
                pictureBox3.Image = ARMags.Images[ARMagCount];
            }
            else if (e.Delta < 0 && ARMagCount == 2)
            {
                ARMagCount = 0;
                pictureBox3.Image = ARMags.Images[ARMagCount];
            }
        }

        private void pictureBox4_MouseWheel(object sender, MouseEventArgs e)
        {
            if(ARcount == 1)
            {
                ARMuzCount = 2;
                pictureBox4.Image = ARMuz.Images[ARMuzCount];
            }
            else
            {
                if (e.Delta > 0 && ARMuzCount != 0)
                {
                    ARMuzCount--;
                    pictureBox4.Image = ARMuz.Images[ARMuzCount];

                }
                else if (e.Delta > 0 && ARMuzCount == 0)
                {
                    ARMuzCount = 2;
                    pictureBox4.Image = ARMuz.Images[ARMuzCount];
                }
                //BOTTOM
                if (e.Delta < 0 && ARMuzCount != 2)
                {
                    ARMuzCount++;
                    pictureBox4.Image = ARMuz.Images[ARMuzCount];
                }
                else if (e.Delta < 0 && ARMuzCount == 2)
                {
                    ARMuzCount = 0;
                    pictureBox4.Image = ARMuz.Images[ARMuzCount];
                }
            }

           
        }

        private void pictureBox5_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && ARGripCount != 0)
            {
                ARGripCount--;
                pictureBox5.Image = ARGrip.Images[ARGripCount];
            }
            else if (e.Delta > 0 && ARGripCount == 0)
            {
                ARGripCount = 1;
                pictureBox5.Image = ARGrip.Images[ARGripCount];
            }
            //BOTTOM
            if (e.Delta < 0 && ARGripCount != 1)
            {
                ARGripCount++;
                pictureBox5.Image = ARGrip.Images[ARGripCount];
            }
            else if (e.Delta < 0 && ARGripCount == 1)
            {
                ARGripCount = 0;
                pictureBox5.Image = ARGrip.Images[ARGripCount];
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Focus();
        }

        private void ARVanila_Enter(object sender, EventArgs e)
        {

        }
    }
}
