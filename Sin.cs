using System;

namespace Function
{
    public class Sin : UnaryFunction
    {
        public Sin(Function f) : base(f)
        {
            expression = (x) => Math.Sin(arg.Calc(x));
        }
        
        public override Function Diff()
        {
            return new Mult(arg.Diff(), new Cos(arg));
        }
    }
}