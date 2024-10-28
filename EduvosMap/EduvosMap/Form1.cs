using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduvosMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            p1.Parent = pictureBox1; //.parent allows for the picture box and text to transparent to the SA map picture not to the form
            c1.Parent = pictureBox1;

            p2.Parent = pictureBox1;
            c2.Parent = pictureBox1;

            p3.Parent = pictureBox1;
            c3.Parent = pictureBox1;

            p4.Parent = pictureBox1;
            c4.Parent = pictureBox1;

            p5.Parent = pictureBox1;
            c5.Parent = pictureBox1;

            p6.Parent = pictureBox1;
            c6.Parent = pictureBox1;

            p7.Parent = pictureBox1;
            c7.Parent = pictureBox1;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //the picture properties are already set to visible = false
            if (!p1.Visible) //the operator makes so that if the picture or label is not visible it will then display but only after 30 seconds, this works due to the timer object
            {
                p1.Visible = true;
                c1.Visible = true;
            }
            else if (!p2.Visible) //this is the same as !p1.visible these will all get executed after 30 seconds
            {
                p2.Visible = true;
                c2.Visible = true;
            }
            else if (!p3.Visible)
            {
                p3.Visible = true;
                c3.Visible = true;
            }
            else if(!p4.Visible)
            {
                p4.Visible = true;
                c4.Visible = true;
            }
            else if(!p5.Visible)
            {
                p5.Visible = true;
                c5.Visible = true;
            }
            else if(!p6.Visible)
            {
                p6.Visible = true;
                c6.Visible = true;
            }
            else
            {
                p7.Visible = true;
                c7.Visible = true;
            }
             

        }
    }
}
