using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsGraphicsOOP
{
    class Shape
    {
        public GraphicsPath gp = new GraphicsPath();
        public Shape(float x, float y, float w, float h)
        {
            PointF p1 = new PointF(x + w / 2, y);
            PointF p2 = new PointF(x + w / 2, y + h);
            PointF p3 = new PointF(x, y + h / 2);
            PointF p4 = new PointF(x + w, y + h / 2);
            gp.AddLine(p1, p2);
            gp.AddLine(p3, p4);
        }
    }
}
