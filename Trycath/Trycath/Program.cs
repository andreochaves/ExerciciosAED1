using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trycath
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 0;
            try
            {
                Console.WriteLine("Divisão:{0}", num1 / num2);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Não é possivel dividir por zero.");
            }

            Console.ReadKey();
        }
    }
}
