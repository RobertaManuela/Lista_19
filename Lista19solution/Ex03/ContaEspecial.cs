using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class ContaEspecial : ContaCorrente
    {
        private double limite;
        
        public ContaEspecial(string titular, string NumeroConta, double limite) : base(titular, NumeroConta) {

            this.limite = limite;
        }

        public override bool Sacar( double valor)
        {

        }
    }
}
