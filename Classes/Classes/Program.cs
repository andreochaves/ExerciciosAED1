using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            if (p1.idade > p2.idade)
                Console.WriteLine("Mais Velho: {0}", p1.nome);
            else
                Console.WriteLine("Mais Velho: {0}", p2.nome);
            Console.ReadKey();
        }
    }
}
