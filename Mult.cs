using System;

namespace Function
{
    public class Mult : BinaryFunction
    {
        public Mult(Function f1, Function f2) : base(f1, f2)
        {
            expression = (x) => firstOperand.Calc(x) * secondOperand.Calc(x);
        }
        

        public override Function Diff()
        {
            return new Add(new Mult(firstOperand.Diff(), secondOperand), new Mult(firstOperand, secondOperand.Diff()));
        }

        protected override string getBinaryExpressionSign()
        {
            return "*";
        }
    }
}