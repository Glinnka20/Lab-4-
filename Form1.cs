using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP4
{
    public partial class Form1 : Form
    {
        public int area1, area2;
        public Form1()
        {
            int area1 = Convert.ToInt32(label12);
            int area2 = Convert.ToInt32(label13);
            InitializeComponent();

        }
        public void funktion()
        {
            int area3 = area1 + area2;
            label11.Text = Convert.ToString(area3);
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            double area = 0;
            area1 = Convert.ToInt32(Math.PI * 20 * (a - b));
            label12.Text = Convert.ToString(area1);
        }

        public void Button2_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox3.Text);
            var g = pictureBox2.CreateGraphics();
            g.FillEllipse(Brushes.Red, new Rectangle(a, a, 100, 100));
            Invalidate();

            double area = 0;
            area2 = Convert.ToInt32(Math.PI * 20 * a);
            label13.Text = Convert.ToString(area2);
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
        public void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(System.Drawing.Pens.Black, 10, 10, 100, 60);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            funktion();
        }
    }
}