using System;

namespace la2
{
    class Program
    {
        public static void menu() {
            bool spos = true;
            Console.WriteLine("Введите ваше выражение к примеру (A=7) или (С=4+2)");
            string expression = "";
            expression = Console.ReadLine();
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '*' || expression[i] == '/' || expression[i] == '+' || expression[i] == '-')
                {
                    spos = false;
                }
            }
            if (!spos)
            {
                for (int i = 0; i < expression.Length; i++)
                {
                    string s0, s1, s2;
                    if (expression[i] == '*')
                    {

                        int K = expression.IndexOf('=');
                        int k = expression.IndexOf('*');
                        s0 = expression.Substring(0, K);
                        s1 = expression.Substring(K + 1, k - 2);
                        s2 = expression.Substring(k + 1);
                        IExpression fir = new constant(Convert.ToInt32(s1));//литсты
                        IExpression sec = new constant(Convert.ToInt32(s2));
                        IExpression mul = new multiplication(fir, sec);//Контейнер
                        Console.WriteLine(string.Format("{0}={1}", s0, mul.Calculate()));
                    }
                    if (expression[i] == '/')
                    {

                        int K = expression.IndexOf('=');
                        int k = expression.IndexOf('/');
                        s0 = expression.Substring(0, K);
                        s1 = expression.Substring(K + 1, k - 2);
                        s2 = expression.Substring(k + 1);
                        IExpression fir = new constant(Convert.ToInt32(s1));//литсты
                        IExpression sec = new constant(Convert.ToInt32(s2));
                        IExpression div = new Division(fir, sec); //Контейнер
                        Console.WriteLine(string.Format("{0}={1}", s0, div.Calculate()));
                    }
                    if (expression[i] == '+')
                    {

                        int K = expression.IndexOf('=');
                        int k = expression.IndexOf('+');
                        s0 = expression.Substring(0, K);
                        s1 = expression.Substring(K + 1, k - 2);
                        s2 = expression.Substring(k + 1);
                        IExpression fir = new constant(Convert.ToInt32(s1));//литсты
                        IExpression sec = new constant(Convert.ToInt32(s2));
                        IExpression add = new Addition(fir, sec);//Контейнер
                        Console.WriteLine(string.Format("{0}={1}", s0, add.Calculate()));
                    }
                    if (expression[i] == '-')
                    {

                        int K = expression.IndexOf('=');
                        int k = expression.IndexOf('-');
                        s0 = expression.Substring(0, K);
                        s1 = expression.Substring(K + 1, k - 2);
                        s2 = expression.Substring(k + 1);
                        IExpression fir = new constant(Convert.ToInt32(s1));//литсты
                        IExpression sec = new constant(Convert.ToInt32(s2));
                        IExpression sub = new subtraction(fir, sec);//Контейнер
                        Console.WriteLine(string.Format("{0}={1}", s0, sub.Calculate()));
                    }
                }


            }
            else
            {
                string s1, s2;
                int k = expression.IndexOf('=');
                s1 = expression.Substring(0, k);
                s2 = expression.Substring(k + 1);
                int Num, nom;
                bool isNum = int.TryParse(s2, out Num);
                if (isNum)
                {
                    IExpresion num = new variable(s2);//литст
                    Console.WriteLine(string.Format("{0}={1}", s1, num.Calculate()));
                }
                else
                {
                    nom = Convert.ToInt32(s2);
                    IExpression var = new constant(nom);//литст
                    Console.WriteLine(string.Format("{0}={1}", s1, var.Calculate()));
                }
            }
            menu();
        }
        static void Main(string[] args)
        {
            menu();                   
        }
    }
}
