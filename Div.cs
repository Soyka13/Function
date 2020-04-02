using System;

namespace Function
{
    public class Div : BinaryFunction
    {
        
        public Div(Function f1, Function f2) : base(f1, f2)
        {
            expression = (x) => firstOperand.Calc(x) / secondOperand.Calc(x);
        }
        

        public override Function Diff()
        {
            return new Div(new Substract(new Mult(firstOperand.Diff(), secondOperand), new Mult(firstOperand, secondOperand.Diff())), new Mult(secondOperand, secondOperand));
        }

        protected override string getBinaryExpressionSign()
        {
            return "/";
        }
    }
}