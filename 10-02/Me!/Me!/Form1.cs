using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Me_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Left -= 2;
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Left += 2;

        }

        private void zoominButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Height <= 400 && pictureBox1.Width <= 500)
            {
                pictureBox1.Left -= 3;
                pictureBox1.Width += 5;
                pictureBox1.Height += 5;
            }

        }

        private void zoomoutButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Height >= 207 && pictureBox1.Width >= 316)
            {
                pictureBox1.Left += 3;
                pictureBox1.Width -= 5;
                pictureBox1.Height -= 5;
            }
        }
        private int currentImage = 1;
        private void changeButton_Click(object sender, EventArgs e)
        {

            switch (currentImage)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.lastOfUs2;
                    currentImage = 2;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.lastOfUs3;
                    currentImage = 3;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.lastOfUs1;
                    currentImage = 1;
                    break;
            }

            //switch (pictureBox1.Image)
            //{
            //    case Properties.Resources.lastOfUs3:
            //        pictureBox1.Image = Properties.Resources.lastOfUs1;
            //        break;
            //    case Properties.Resources.lastOfUs2:
            //        pictureBox1.Image = Properties.Resources.lastOfUs3;
            //        break;
            //    case Properties.Resources.lastOfUs1:
            //        pictureBox1.Image = Properties.Resources.lastOfUs2;
            //        break;
            //    default:
            //        pictureBox1.Image = Properties.Resources.lastOfUs3;
            //        break;
            //}
                    

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Top += 3;

        }

        private void topButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Top -= 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
