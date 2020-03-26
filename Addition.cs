using System;
using System.Collections.Generic;
using System.Text;

namespace la2
{
    class Addition : BinarEx
    {
        public Addition(IExpression left, IExpression right) : base(left, right) { }

        public override int Calculate()
        {
            int leftValue = left.Calculate();
            int rightValue = right.Calculate();
            return leftValue + rightValue;
        }
    }
}
