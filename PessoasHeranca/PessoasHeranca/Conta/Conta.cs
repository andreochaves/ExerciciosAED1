using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoasHeranca.Conta
{
    class Conta
    {
        private string numero;
        private string titular;
        private float saldo;

        public bool Sacar(float qtd)
        {
            if (qtd > 0 && qtd <= saldo) 
            {
                saldo -= qtd;
                return true;
            }
            return false;
        }

        public string getNumero()
        {
            return numero;
        }

        public string getTitular()
        {
            return titular;
        }
        public float getSaldo()
        {
            return saldo;
        }

        public void setNumero(string novo_num)
        {
            numero = novo_num;
        }
        public void setTitular(string novo_tit)
        {
            titular=novo_tit;
        }
        public void setSaldo(float novo_saldo)
        {
            saldo=novo_saldo;
        }
        public bool Depositar(float qtd)
        {
            if (qtd > 0)
            {
                saldo += qtd;
                return true;
            }
            return false;
        }

    }
}
