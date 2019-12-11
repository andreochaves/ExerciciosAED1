using System;


internal class Robo
{
    private string nome;

    //Atributo estático. 
    //Pertence à classe, mas é compartilhado com os objetos.
    private static string mensagem_geral;

    //Método não estático: Cada objeto tem o seu próprio método:
    public void Mensagem()
    {
        Console.WriteLine("[{0}]:{1}", nome, mensagem_geral);
    }

    //Método estático. Só pode ser acessado diretamente pela classe:
    public static void NovaMensagem(string msg)
    {
        mensagem_geral = msg;
    }

    //construtor da classe: 
    public Robo(string n)
    {
        nome = n;
    }
    public setCor(ConsoleColor Red)
    {
        return Red;

    }

}


