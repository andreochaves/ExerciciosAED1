using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace PessoaMaisVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream myFamily = new FileStream("Familia.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(myFamily, Encoding.UTF7);

            Pessoas[] family = new Pessoas[10];
            string nome;
            int idade;
            Pessoas maisVelho = new Pessoas();

            maisVelho = family[0];

            for(int j = 0; j < 10; j++)
            {
                nome = sr.ReadLine();
                idade = int.Parse(sr.ReadLine());
                family[j] = new Pessoas(nome, idade);
            }
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("{0} - {1}",family[j].getNome(),family[j].getIdade());
            }
            for (int j = 0; j < 10; j++)
            {
                Pessoas mais_Velho = family[j].maisVelho(family[j]);
                maisVelho = mais_Velho;
            }
            Console.WriteLine("A pessoa mais velha é:{0} com {1}", maisVelho.getNome(),maisVelho.getIdade());


            Console.ReadKey();

         
        }
    }
}
