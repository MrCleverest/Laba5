using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Laba5
{
    public class CosDivX
    {
        double x;
        double sqr;
        double min = 0.001;
        public CosDivX()
        {
            x = 0;
        }
        public CosDivX(double xx)
        {
            x = xx;
            sqr = x * x;
        }
        public double X { get { return x; } set { x = value; } }
        public double CosDivX_cikle()
        {
            double sum = 1, current = 1;
            int n = 2, mul = -1;

            do
            {
                current = current * sqr / n++ / n++;
                sum = sum + mul * current;
                mul = -mul;
            }
            while (current > min || current < -min);
            return sum;
        }
        public void CosDivX_rec(double current, double mul, double n, ref double sum)
        {
            current = current * sqr / n++ / n++;
            sum = sum + mul * current;
            mul = -mul;
            if (current > min || current < -min)
                CosDivX_rec(current, mul, n, ref sum);
        }
    }
}
