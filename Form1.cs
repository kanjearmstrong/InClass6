using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inclass62
{
    public partial class Form1 : Form
    {
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Generates Dice ones Number
            int dice1;

            Random rand = new Random();


            dice1 = rand.Next(6);

            if (dice1 == 0)
            {
                d1.Text = "1";
            }
            else if (dice1 == 1)
            {
                d1.Text = "2";
            }
            else if (dice1 == 2)
            {
                d1.Text = "3";
            }
            else if (dice1 == 3)
            {
                d1.Text = "4";
            }
            else if (dice1 == 4)
            {
                d1.Text = "5";
            }
            else if (dice1 == 5)
            {
                d1.Text = "6";
            }

            //Generates Dice twos Numbers

            int dice2 = rand.Next(6);
            dice2 = rand.Next(6);
            if (dice2 == 0)
            {
                d2.Text = "1";
            }
            else if (dice2 == 1)
            {
                d2.Text = "2";
            }
            else if (dice2 == 2)
            {
                d2.Text = "3";
            }
            else if (dice2 == 3)
            {
                d2.Text = "4";
            }
            else if (dice2 == 4)
            {
                d2.Text = "5";
            }
            else if (dice2 == 5)
            {
                d2.Text = "6";
            }

            //Counts amount of rolls and reads checks for snake eyes
            counter++;


            if (dice1 == 0 && dice2 == 0)
            {
                MessageBox.Show("It took " + counter + " rolls to get the snake eyes");
                counter = 0;
            }
        }

        private void picturebox_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void d1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

