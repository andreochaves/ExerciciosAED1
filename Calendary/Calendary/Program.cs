using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendary
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data1 = new Data(9,9,2016);
            Data data2 = new Data(21,9,2019);

            data1.Incrementa(3);

            Console.WriteLine("{0}/{1}/{2}",data1.getDias(), data1.getMes(), data1.getAno());
            Console.WriteLine("O mes é {0}", data1.NomeMes());
            Console.WriteLine(data1.Diferenca(data1.getDias(), data2.getDias()));
            Console.WriteLine();
            Console.WriteLine(data1.Bissexto());

            Console.ReadKey();
        }
    }
}
