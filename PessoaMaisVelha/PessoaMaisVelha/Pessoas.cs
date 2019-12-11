namespace PessoaMaisVelha
{
    internal class Pessoas
    {
        private string nome;
        private int idade;

        public string getNome()
        {
            return nome;
        }
        public int getIdade()
        {
            return idade;
        }
        public Pessoas maisVelho(Pessoas outra)
        {
            if (idade > outra.idade) {
                return this;

            }
            else{
                return outra;
            }
        }
        public Pessoas()
        {
            nome = "Sem nome ainda!";
            idade = 0;
        }
        public Pessoas(string n, int i)
        {
            nome = n;
            idade = i;
        }

    }
}