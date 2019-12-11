using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobosdoChaves
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação de objetos do tipo Robo:
            Robo xpto = new Robo("XPTO");
            Robo r2d2 = new Robo("R2D2");

            //Utilização do método estático NovaMensagem.
            //Veja que o método é acessado a partir da clase:
            Robo.NovaMensagem("Somos todos iguais!");

            //Utilização dos métodos não estáticos de cada objeto:
            xpto.Mensagem();
            r2d2.Mensagem();

            r2d2.setCor(ConsoleColor.Red);
            Robo.NovaMensagem("Alguns mais iguais que os outros!");
            xpto.Mensagem();
            r2d2.Mensagem();


            Console.ReadKey();
            
        }
    }
    
}
