using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, maior, menor, inter;

            Console.WriteLine("Digite o primeiro numero:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro numero:");
            num3 = int.Parse(Console.ReadLine());

            maior = num1;
            menor = num1;
            inter = num1;

            if (num2 > maior && num2>num3)
            {
                maior = num2;
            }

            else if (num2 < menor&& num2 < num3)
            {
                menor = num2;
            }

            else
            {
                inter = num2;
            }


            if (num3 > maior)
            {
                maior = num3;
            }

            else if (num3 < menor)
            {
                menor = num3;
            }

            else
            {
                inter = num3;
            }
                


            Console.WriteLine("Numero Menor: {0}", menor);
            Console.WriteLine("Numero Intermediario: {0}", inter);
            Console.WriteLine("Numero Maior: {0}", maior);

            Console.ReadKey();
        }
    }
}
