using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Quadrado : Retangulo
    {
        private double l;
        public Quadrado(double l) : base(l, l) { }

       
        public override string ToString()
        {
            return $"{CalcDiagonal()} -- {CalcArea()}";
        }
    }
}
       

