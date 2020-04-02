using System;
using System.Xml;

namespace Function
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Function f1 = new CTan(new Tan(new Mult(new Const(5), new ArgX()))); // ctg(tg(5x))
            Function f2 = new Add(new Mult(new Const(3), new AX(new Const(2), new ArgX())), new Sin(new ArgX())); // 3*2^x+sin(x)
            Function f3 = new Substract(new Ln(new ArgX()), new Exp(new ArgX())); // ln(x) - e^x
            Function f4 = new Div(new Cos(new ArgX()), new ArgX()); // cos(x)/x
            Function f6 = new Exp(new Mult(new Mult(new Const(-1), new ArgX()), new ArgX())); // e^(-x^2)

            double[] koef = new Double[4] {1, 3, 12, 8}; // x^3+3*x^2+12*x+8

            Function f5 = new Polinom(koef);
            Console.WriteLine(f5.ToString());

            XmlDocument document = f4.createXMLDoc("Function");
            Console.WriteLine(XmlUtils.PrintXML(document));
            //document.Save("f4.xml");

            //Bisection method
            Console.WriteLine(CalculationMethods.bisec(f5, -100, 100, Double.Epsilon));

            //Simpson method
            Console.WriteLine(CalculationMethods.Simpson(f6, 0, 1, 10));
        }
    }
}