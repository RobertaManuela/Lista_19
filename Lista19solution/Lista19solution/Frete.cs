using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista19solution
{
    class Frete
    {
        private double distancia, peso;

        public Frete(double d, double p)
        {
            if (d > 0)
            {
                distancia = d;
            }

            if (p > 0)
            {
                peso = p;
            }
        }

        public double GetPeso()
        {
            return peso;
        }

        public double GetDistancia()
        {
            return distancia;
        }

        public virtual decimal CalcFrete()
        {
            return Convert.ToDecimal(distancia * peso) * Convert.ToDecimal(0.01);

        }

        public override string ToString()
        {
            return $"{distancia} --- {peso} --- {CalcFrete()}";
        }
    }
}
