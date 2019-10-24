using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista19solution
{
    class FreteExpresso : Frete
    {
        private decimal seguro;

        public FreteExpresso(double p, double d, decimal seg) : base(p, d)
        {
            seguro = seg;
        }

        public override decimal CalcFrete()
        {
            return base.CalcFrete() * 2 + (decimal)(0.01) * seguro;
        }
        public override string ToString()
        {
            return $"FreteExpresso: {GetDistancia()} ----  {GetPeso()} {this.CalcFrete()}";
        }
     }

 }
