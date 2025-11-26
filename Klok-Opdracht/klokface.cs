using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klok_Opdracht
{
    public class klokface
    {
        /// <summary>
        /// Draws the clockface with numbers around it
        /// </summary>
        /// <algo>
        /// Determens the radius and diameter of the clockface
        /// Then draws the circle at the center w,h with the diameter
        /// then it starts calculating the postion of the numbers
        /// And draws them around the clockface
        /// </algo>
        public static void draw_clockface(int w, int h, int s, Form f)
        {
            Graphics g = f.CreateGraphics();
            int radius = s + 100 / 2;
            int diameter = 2 * radius;
            g.DrawEllipse(new Pen(Color.Black, 3), w - radius, h - radius, diameter, diameter);
            s+=30;
            for (int i = 1; i <= 12; i++)
            {
                double angle = i * Math.PI / 6 - Math.PI / 2;
                int x = (int)(w + s * Math.Cos(angle));
                int y = (int)(h + s * Math.Sin(angle));
                g.DrawString(i.ToString(), new Font("Arial", 15), Brushes.Black, x - 10, y - 10);
            }
        }
    }
}
