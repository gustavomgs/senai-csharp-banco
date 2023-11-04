using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Cliente
    {
        public string nome;
        public double saldo;

        public void Creditar(double valor)
        {
            if(valor <= 0)
            {
                throw new Exception("Pora favor insira um valor válido");
            }

            this.saldo += valor;
        }
        public void Debitar(double valor)
        {
            this.saldo -= valor;
        }
    }
}
