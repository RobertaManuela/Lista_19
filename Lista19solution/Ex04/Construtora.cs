using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Construtora
    {
        private List<Funcionario> funcs = new List<Funcionario>();

        public void Inserir(Funcionario f)
        {
            funcs.Add(f);
        }

        public List<Funcionario> Funcionarios()
        {
            return funcs;
        }

        public List<Engenheiro> Engenheiros()
        {
            List<Engenheiro> e = new List<Engenheiro>();
            foreach (Funcionario f in funcs)
            {
                if (f is Engenheiro)
                e.Add(f as Engenheiro);
            }
            return e;
        }

        public List<Motorista>Motoristas()
        {
            List<Motorista> t = new List<Motorista>();
            foreach (Funcionario f in funcs)
                if (f is Motorista)
                t.Add(f as Motorista);

        }
        return t;

       }
    }
}
