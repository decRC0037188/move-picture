using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace move_picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //buttons to move 
        private void Button1_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Location.X > 0)
            {
                pictureBox2.Location = new Point(pictureBox1.Location.X - 5, pictureBox2.Location.Y);
            }
        }

        private void Button2_Click(object sender, EventArgs e)

        {
            if (pictureBox2.Location.X + 5 < ClientRectangle.Width)
            { 
            pictureBox2.Location = new Point(pictureBox1.Location.X + 5, pictureBox2.Location.Y);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox1.Location.Y + 5, pictureBox2.Location.X);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox1.Location.Y - 5, pictureBox2.Location.X);
        }
        private void Button1_click(object sender, EventArgs e)
        {
            
        }
 

