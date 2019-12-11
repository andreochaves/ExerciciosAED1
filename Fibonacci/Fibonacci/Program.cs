using System;


namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
             string texto = "";
             // textoSeparado;
            char[] textoMaisSeparado;

             Console.WriteLine("Digite um texto");
             texto = Console.ReadLine();
             for(int i = 0; i < texto.Length; i++)
             {
                string[] textoSeparado = texto.Split(new string[](","));
                 Console.WriteLine(textoSeparado[i]);
             }
           /*  for (int i = 0; i < textoMaisSeparado.Length; i++)
             {
                 textoMaisSeparado[i] = char.Parse(textoSeparado[i]);
                 Console.WriteLine(textoMaisSeparado[i]);
             }*/


     


           
            Console.ReadKey();
        }
    }
}
/* char inter = '?';
            char excla = '!';
            string texto = " ";

            Console.WriteLine("Digite um texto gritado:");
            texto = Console.ReadLine();

            while(inter in texto.Length){

            }

*/
