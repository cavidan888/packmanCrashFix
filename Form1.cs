using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Packman_Game
{
    public partial class Form1 : Form
    {

        public int leftPos = 2;
        public int topPos = 2;
        public int count = 0;
        public int findTimer = 0;

       

        public Form1()
        {
            InitializeComponent();
            packman.Left = 120;
            packman.Top = 100;

        }


       

        private void startGame_Click(object sender, EventArgs e)
        {
            count++;
            timer1.Start();

            if (count > 0)
            {
                startGame.Enabled = false;
            }
           
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            packman.Left += leftPos;
            timer1.Interval = 60;
           

            if (findTimer == 1)
            {
                packman.Left -= leftPos;
                packman.Top += topPos;

                if (packman.Location.Y >= obs4.Location.Y - packman.Width)
                {
                    timer1.Enabled = false;
                    packman.Left = 120;
                    packman.Top = 100;
                    startGame.Enabled = true;
                }

                
            }
            else if (findTimer == 2)
            {
                packman.Left -= leftPos;
                packman.Top -= topPos;


                if (packman.Location.Y <= obs3.Location.Y + packman.Width)
                {
                    timer1.Enabled = false;
                    MessageBox.Show(packman.Location.ToString());
                }
                
            }
            else if (findTimer == 3)
            {

                packman.Left -= leftPos;
                packman.Left += leftPos;

                if (packman.Location.X >= obs2.Location.X-packman.Width)
                {
                    timer1.Enabled = false;
                    MessageBox.Show(packman.Location.ToString());
                }
                


            }
            else if (findTimer == 4)
            {
                packman.Left -= leftPos + 1;

                if (packman.Location.X <= obs.Location.X+packman.Width)
                {
                    timer1.Enabled = false;
                    MessageBox.Show(packman.Location.ToString());
                }

               
            }
        }




        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                findTimer = 1;
            }
            else if (e.KeyCode == Keys.Up)
            {
                findTimer = 2;

                
            }
            else if (e.KeyCode == Keys.Right)
            {
                findTimer = 3;


               
            }
            else if (e.KeyCode == Keys.Left)
            {
                findTimer = 4;

                
            }

          
        }




        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
