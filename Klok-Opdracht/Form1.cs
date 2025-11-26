using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klok_Opdracht
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        Point p0, p1, p2, p3;
        static int S = 150;
        static double offset = Math.PI / 2;
        /// <summary>
        /// Starts the timer
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        /// <summary>
        /// Timer that updates every second
        /// </summary>
        /// <algo>
        /// Determines the cennter of the form and makes it p0
        /// clears the form to draw a new clock
        /// Draws the clockface and numbers
        /// makes the wisers for seconds, minutes and hours
        /// </algo>
        private void timer1_Tick(object sender, EventArgs e)
        {
            p0 = new Point(this.Width / 2, this.Height / 2);
            this.CreateGraphics().Clear(BackColor);
            int second = DateTime.Now.Second;
            int minute = DateTime.Now.Minute;
            int hour = DateTime.Now.Hour;

            klokface.draw_clockface(p0.X, p0.Y, S, this);
            wiser(second, 30, Color.Orange, p1);
            wiser(minute, 30, Color.Blue, p2);
            wiser(hour, 6, Color.Red, p3);
        }
        /// <summary>
        /// Draws a wiser based on the time in color c
        /// </summary>
        /// <algo>
        /// First calculates the Angle F based on the n(number) and t(time) minus the offset
        /// It calculates the O(opposite) and A(adjacent) using S(sizeness) and F(angle)
        /// then it calculates the new point p based on p0(center) plus A and O and draws a line from p0 to p
        /// </algo>
        private void wiser(int t, int n, Color C, Point p)
        {
            double F = Math.PI / n * t - offset;
            double O = (int)(S * Math.Sin(F));
            double A = (int)(S * Math.Cos(F));
            p = new Point((int)(p0.X + A), (int)(p0.Y + O));
            this.CreateGraphics().DrawLine(new Pen(C, 2), p0, p);
        }
    }
}