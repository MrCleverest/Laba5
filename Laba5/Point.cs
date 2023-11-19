using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    public class Point
    {
        double x, y, yCikl, yRek;

        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
        public double Y_cikl { get { return yCikl; } set { yCikl = value; } }
        public double Y_rek { get { return yRek; } set { yRek = value; } }

        public Point(double x, double y, double yCikl, double yRek)
        {
            this.x = x;
            this.y = y;
            this.yCikl = yCikl;
            this.yRek = yRek;
        }
    }
}
