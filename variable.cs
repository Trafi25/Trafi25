using System;
using System.Collections.Generic;
using System.Text;

namespace la2
{
    class variable : IExpresion
    {
        private string num;

        public variable(string num)
        {
            this.num = num;
        }


        public string Calculate()
        {
            return num;
        }
    }
}
