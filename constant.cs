using System;
using System.Collections.Generic;
using System.Text;

namespace la2
{
    class constant : IExpression
    {
        private int num;

    public constant(int num)
    {
        this.num = num;
    }
     public int Calculate()
    {
        return num;
    }
}
}

