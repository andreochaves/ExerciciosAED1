namespace Calendary
{
    internal class Data
    {
        private int dias, mes, ano;
        

        public Data()
        {
            dias = 01;
            mes = 01;
            ano = 1900;
        }

        public Data(int dias,int mes,int ano)
        {
            this.dias = dias;
            this.mes = mes;
            this.ano = ano;
        }
        public int getDias()
        {
            return dias;
        }
        public int getMes()
        {
            return mes;
        }
        public int getAno()
        {
            return ano;
        }
        public void setDias(int d)
        {
            dias = d;
        }
        public void setMes(int m)
        {
            mes = m;
        }
        public void setAno(int a)
        {
            ano = a;
        }
        public string NomeMes()
        {
            string nMes="mes";
            if (mes == 01)
            {
                nMes = "Janeiro";
            }
            if (mes == 02)
            {
                nMes = "Fevereiro";
            }
            if (mes == 03)
            {
                nMes = "Março";
            }
            if (mes == 04)
            {
                nMes = "Abril";
            }
            if (mes == 05)
            {
                nMes = "Maio";
            }
            if (mes == 06)
            {
                nMes = "Junho";
            }
            if (mes == 07)
            {
                nMes = "Julho";
            }
            if (mes == 08)
            {
                nMes = "Agosto";
            }
            if (mes == 09)
            {
                nMes = "Setembro";
            }
            if (mes == 10)
            {
                nMes = "Outubro";
            }
            if (mes == 11)
            {
                nMes = "Novembro";
            }
            if (mes == 12)
            {
                nMes = "Dezembro";
            }
            return nMes;
        }
        public bool Bissexto()
        {
            bool bissexto = false;

            if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
                bissexto = true;
            return bissexto;
        }
        public bool Maior(Data outra_data)
        {

        }
        public void Incrementa(int dia)
        {
            this.dias = this.dias + dia;
        }
        public int Diferenca(int d1,int d2)
        {
            int dMais;
            dMais = d2 - d1;
            return dMais;
        }
    }
}