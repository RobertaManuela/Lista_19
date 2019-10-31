using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Contato
    {
        private string nome, fone;

        public Cont(string n, string f)
        {
            nome = n;
            fone = f;
        }

        public Contato() { }
        public override string ToString()
        {
            return $"{nome} - {fone}";
        }
    }
}
