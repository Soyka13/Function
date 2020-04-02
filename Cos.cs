using System;

namespace Function
{
    public class Cos : UnaryFunction
    {
        public Cos(Function f) : base(f)
        {
            expression = (x) => Math.Cos(arg.Calc(x));
        }

        public override Function Diff()
        {
            return new Mult(arg.Diff(), new Mult(new Const(-1), new Sin(arg)));
        }
    }
}