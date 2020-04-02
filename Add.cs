using System;

namespace Function
{
    public class Add : BinaryFunction
    {
        public Add(Function f1, Function f2) : base(f1, f2)
        {
            expression = (x) => this.firstOperand.Calc(x) + secondOperand.Calc(x);
        }
        
        protected override string getBinaryExpressionSign()
        {
            return "+";
        }

        public override Function Diff()
        {
            return new Add(firstOperand.Diff(), secondOperand.Diff());
        }
    }
}