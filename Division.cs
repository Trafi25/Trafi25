using System;
using System.Collections.Generic;
using System.Text;

namespace la2
{
    class Division : BinarEx
    {
        public Division(IExpression left, IExpression right) : base(left, right)
        {
        }

        public override int Calculate()
        {
            return left.Calculate() / right.Calculate();
        }
    }
}
