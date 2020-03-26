using System;
using System.Collections.Generic;
using System.Text;

namespace la2
{
    class multiplication : BinarEx
    {
		public multiplication(IExpression left, IExpression right) : base(left, right)
		{
		}

		public override int Calculate()
		{		
			return left.Calculate() * right.Calculate();
		}
	}
}
