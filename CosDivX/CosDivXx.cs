using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CosDivX
{
    public class CosDivXx
    {
        double x;
        double sqr;
        double min = 0.001;
        public CosDivXx()
        {
            x = 0;
        }
        public CosDivXx(double xx)
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