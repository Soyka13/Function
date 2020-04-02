using System;

namespace Function
{
    public class AX : BinaryFunction
    {
        public AX(Function f1, Function f2) : base(f1, f2)
        {
            expression = (x) => Math.Pow(firstOperand.Calc(x), secondOperand.Calc(x));
        }
        
        public override Function Diff()
        {
           return new Mult(this, new Ln(firstOperand));
        }

        protected override string getBinaryExpressionSign()
        {
            return "^";
        }
    }
}