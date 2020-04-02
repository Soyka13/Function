using System;

namespace Function
{
    public class Ln : UnaryFunction
    {
        public Ln(Function f) : base(f)
        {
            expression = (x) => Math.Log(arg.Calc(x));
        }
        public override Function Diff()
        {
            return new Div(new Const(1.0), arg);
        }
    }
}