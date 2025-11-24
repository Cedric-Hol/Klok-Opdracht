using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        public static double S = 150;
        public static double f = 2 * Math.PI;
        public static double O = S * Math.Sin(f);
        public static double A = S * Math.Cos(f);

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Point p0 = new Point(500, 250);
            Point p1 = new Point((int)(p0.X + A), (int)(p0.Y + O));
            using (Pen pen = new Pen(Color.Red, 2))
            {
                g.DrawLine(pen, p0, p1);
            }
        }
    }
}
