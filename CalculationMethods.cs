using System;

namespace Function
{
    public class CalculationMethods
    {
        // to find roots
        public static Double bisec(Function fun, Double a, Double b, Double e)
        {
            Double c = 0.0;
            while (fun.Calc(b) - fun.Calc(a) > e)
            {
                c = (a + b) / 2;
                if (fun.Calc(b) * fun.Calc(c) < 0)
                    a = c;
                else
                    b = c;
            }

            return c;
        }

        // to find integral
        public static Double Simpson(Function fun, Double a, Double b, Double n)
        {
            Double h = (b - a) / n;
            Double k1 = 0, k2 = 0;
            for (int i = 1; i < n; i += 2)
            {
                k1 += fun.Calc(a + i * h);
                k2 += fun.Calc(a + (i + 1) * h);
            }

            return h / 3 * (fun.Calc(a) + 4 * k1 + 2 * k2);
        }
    }
}