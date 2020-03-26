using System;
using System.Collections.Generic;
using System.Text;

namespace la2
{
	abstract class BinarEx : IExpression
	{	
			protected readonly IExpression left;
			protected readonly IExpression right;

			protected BinarEx(IExpression left, IExpression right)
			{
				this.left = left;
				this.right = right;
			}

			public abstract int Calculate();
		
	}
}
