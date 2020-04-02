using System;

namespace Function
{
    public class Exp : UnaryFunction
    {
        public Exp(Function f) : base(f)
        {
            expression = (x) => Math.Exp(arg.Calc(x));
        }
        public override Function Diff()
        {
            return new Mult(arg.Diff(), this);
        }
        
    }
}