using System;

namespace Function
{
    public class Substract : BinaryFunction
    {
        public Substract(Function f1, Function f2) : base(f1, f2)
        {
            expression = (x) => firstOperand.Calc(x) - secondOperand.Calc(x);
        }
        

        protected override string getBinaryExpressionSign()
        {
            return "-";
        }

        public override Function Diff()
        {
            return new Substract(firstOperand.Diff(), secondOperand.Diff());
        }
    }
}