using System;
using System.Xml;

namespace Function
{
    public class Polinom : Function
    {
        protected double[] koef;

        public Polinom(double[] koef)
        {
            expression = (x) =>
            {
                double res = 0.0;
                for (int i = 0, n = koef.Length - 1; i < koef.Length; i++, n--)
                {
                    res += koef[i] * Math.Pow(x, n);
                }

                return res;
            };
            
            this.koef = koef;
        }

        public override Function Diff()
        {
            double[] koef_copy = koef;
            for (int i = 0, n = koef_copy.Length - 1; i < koef_copy.Length - 1; i++, n--)
            {
                koef_copy[i] *= n;
            }

            return new Polinom(koef_copy);
        }

        public override void ToXML(XmlDocument doc, XmlNode previousNode)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string res = "";
            string sign = "";

            for (int i = 0, n = koef.Length - 1; i < koef.Length; i++, n--)
            {
                if (koef[i] > 0) sign = "+";
                if (koef[i] < 0) sign = "-";
                if (n == 0) res += sign + " " + koef[i];
                else res += sign + " " + koef[i] + "*" + "x^" + n + " ";
                
            }

            return res;
        }
    }
}