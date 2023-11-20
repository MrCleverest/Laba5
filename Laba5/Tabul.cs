using System;
using CosDivX;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    internal class Tabul
    {
        public List<Point> points = new List<Point>();

        public void add(Point point)
        {
            points.Add(point);
        }

        public void GetList(double xn, double xk, double h)
        {
            try
            {
                var x = xn;
                double y = 0, yCycle = 0, yRecursive = 1;
                while (x < xk)
                {
                    var cosDivX = new CosDivXx(x);
                    y = Math.Cos(x) / x;
                    yCycle = cosDivX.CosDivX_cikle();
                    yRecursive = 1;
                    cosDivX.CosDivX_rec(1, -1, 2, ref yRecursive);
                    var point = new Point(x, y, yCycle, yRecursive);
                    add(point);
                    x = x + h;
                }
            }
            catch (Exception ex) { }
        }
    }
}
