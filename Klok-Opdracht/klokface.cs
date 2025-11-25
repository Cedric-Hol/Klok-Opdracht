using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klok_Opdracht
{
    public class klokface
    {
        public static void draw_clockface(int w, int h, int s, Form f)
        {
            Graphics g = f.CreateGraphics();
            int radius = s + 100 / 2;
            int diameter = 2 * radius;
            g.DrawEllipse(new Pen(Color.Black, 3), w - radius, h - radius, diameter, diameter);
        }



        /*
        public static void remove_clockface(int w, int h, int s, Form f)
        {
            Graphics g = f.CreateGraphics();
            int radius = s + 100 / 2;
            int diameter = 2 * radius;
            g.DrawEllipse(new Pen(f.BackColor, 3), w - radius, h - radius, diameter, diameter);
        }
        */
    }
}
