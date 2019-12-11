using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Autocenter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chamando Tela Inicial
            int selecao = 0;
            TelaInicial novaTela = new TelaInicial(selecao);

            //Chamando Formulario de Cadastro
            string nome = "";
            string rua = "";
            string bairro = "";
            string cidade = "";
            string estado = "";
            int numero = 0;
            string placa = "";
            string modelo = "";
            string marca = "";
            CadastrarCliente novoCliente = new CadastrarCliente(nome, rua, numero, bairro, cidade, estado,modelo,marca,placa);

        

            //Verificar dados
            string verificar = "";
            FileStream meuArq = new FileStream("placa.txt", FileMode.Open, FileAccess.Read);
            VerificarDados novaVerificacao = new VerificarDados(verificar,meuArq);
            StreamReader sr = new StreamReader(meuArq, Encoding.UTF8);
            Console.WriteLine("Digite opção desejada:");
            selecao = int.Parse(Console.ReadLine());
            while (selecao > 0 && selecao < 3)
            {
                //Começo do Programa
                Console.WriteLine("Digite opção desejada:");
                selecao = int.Parse(Console.ReadLine());

                if (selecao == 1)
                {
                    //Gravar Arquivo
                    FileStream novo = new FileStream("placa.txt", FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(novo, Encoding.UTF8);

                    Console.WriteLine("Qual seu nome?");
                    nome = Console.ReadLine();
                    Console.WriteLine("Seu Endereço?");
                    rua = Console.ReadLine();
                    Console.WriteLine("Numero?");
                    numero = int.Parse(Console.ReadLine());
                    Console.WriteLine("Bairro?");
                    bairro = Console.ReadLine();
                    Console.WriteLine("Cidade?");
                    cidade = Console.ReadLine();
                    Console.WriteLine("Estado?");
                    estado = Console.ReadLine();

                    sw.WriteLine(novoCliente.getNome(), novoCliente.getRua(), novoCliente.getNumero(), novoCliente.getBairro(), novoCliente.getCidade(), novoCliente.getEstado());
                    sw.Close();
                    novo.Close();
                }
                else if (selecao == 2)
                {
                    verificar = sr.ReadLine();
                    Console.WriteLine(novaVerificacao.getArquivo());
                }
                else
                {
                    Console.WriteLine("Opção Invalida!");
                }

            }

          

          

           
            meuArq.Close();
            sr.Close();
            
            Console.ReadKey();
        }
    }
}
