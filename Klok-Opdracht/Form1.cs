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
        private void button1_Click(object sender, EventArgs e)
        {
            p0 = new Point(this.Width / 2, this.Height / 2);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int second = DateTime.Now.Second;
            int minute = DateTime.Now.Minute;
            int hour = DateTime.Now.Hour;

            klokface.draw_clockface(p0.X, p0.Y, S, this);
            wiser(second, 30, Color.Orange, p1);
            wiser(minute, 30, Color.Blue, p2);
            wiser(hour, 6, Color.Red, p3);
        }
        private void wiser(int t, int n, Color C, Point p)
        {
            this.CreateGraphics().DrawLine(new Pen(BackColor, 2), p0, p);
            double F = Math.PI / n * t - offset;
            double O = (int)(S * Math.Sin(F));
            double A = (int)(S * Math.Cos(F));
            p = new Point((int)(p0.X + A), (int)(p0.Y + O));
            this.CreateGraphics().DrawLine(new Pen(C, 2), p0, p);
        }
    }
}
/*
private void second_hand()
{
    this.CreateGraphics().DrawLine(new Pen(BackColor, 2), p0, p1);
    int second = DateTime.Now.Second;
    double F = Math.PI / 30 * second - offset;
    double O = (int)(S * Math.Sin(F));
    double A = (int)(S * Math.Cos(F));
    p1 = new Point((int)(p0.X + A), (int)(p0.Y + O));
    this.CreateGraphics().DrawLine(new Pen(Color.Orange, 2), p0, p1);
}

private void minute_hand()
{
    this.CreateGraphics().DrawLine(new Pen(BackColor, 2), p0, p2);
    int minute = DateTime.Now.Minute;
    double F = Math.PI / 30 * minute - offset;
    double O = (int)(S * Math.Sin(F));
    double A = (int)(S * Math.Cos(F));
    p2 = new Point((int)(p0.X + A), (int)(p0.Y + O));
    this.CreateGraphics().DrawLine(new Pen(Color.Blue, 2), p0, p2);
}

private void hour_hand()
{
    this.CreateGraphics().DrawLine(new Pen(BackColor, 2), p0, p3);
    int hour = DateTime.Now.Hour;
    double F = Math.PI / 6 * hour - offset;
    double O = (int)(S * Math.Sin(F));
    double A = (int)(S * Math.Cos(F));
    p3 = new Point((int)(p0.X + A), (int)(p0.Y + O));
    this.CreateGraphics().DrawLine(new Pen(Color.Red, 2), p0, p3);
}
*/
