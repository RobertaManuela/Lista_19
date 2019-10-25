using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class ContaCorrente
    {
        private string titular;
        private string NumeroConta;
        protected double saldo;

        public ContaCorrente(string titular, string NumeroConta)
        {
            this.titular = titular;
            this.NumeroConta = NumeroConta;
        }

        public void Depositar( double valor)
        {

        }

        public virtual bool Sacar(double valor)
        {

        }

        public double RetornarSaldo()
        {
            return saldo;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
