using System;

namespace Function
{
    public class Tan : UnaryFunction
    {
        public Tan(Function f) : base(f)
        {
            expression = (x) => Math.Tan(arg.Calc(x));
        }

        public override Function Diff()
        {
            return new Div(new Const(1), new Mult(new Cos(arg), new Cos(arg)));
        }
    }
}