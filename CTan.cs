using System;

namespace Function
{
    public class CTan : UnaryFunction
    {
        public CTan(Function f) : base(f)
        {
            expression = (x) => 1.0 / Math.Tan(arg.Calc(x));
        }
        public override Function Diff()
        {
            return new Mult(arg.Diff(), new Div(new Const(-1), new Mult(new Sin(arg), new Sin(arg))));
        }
    }
}