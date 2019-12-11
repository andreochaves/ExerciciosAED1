using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Autocenter
{
    class VerificarDados
    {
        private string Arquivo;
        FileStream lendoArq = new FileStream("placa.txt", FileMode.Open, FileAccess.Read);
        //StreamReader sr = new StreamReader(lendoArq, Encoding.UTF8);

        public VerificarDados(string Arquivo, FileStream lendoArq)
        {
            this.Arquivo = Arquivo;
            this.lendoArq = lendoArq;
        }


        public string getArquivo()
        {
            return Arquivo;
        }
        public void setArquivo(string a)
        {
            Arquivo = a;
        }
       
    }
}
