using System;
using System.Collections.Generic;
using System.Text;

namespace la2
{
    class subtraction : BinarEx
    {
        public subtraction(IExpression left, IExpression right) : base(left, right) { }

        public override int Calculate()
        {
            return left.Calculate() - right.Calculate();
        }
    }
}
