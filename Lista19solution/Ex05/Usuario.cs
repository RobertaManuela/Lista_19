using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Usuario : Contato
    {
        private int cc, gg;
        private Contato[] contatos = new Contato[130];
        private Grupo[] grupos = new Grupo[25];

        public Usuario(string n, string f) : base(n, f) { }

        public void InserirContato(Contato c)
        {
            contatos[cc++] = c;
        }

        public void InserirGrupo(Grupo g)
        {
            grupos[gg++] = g;
        }

        public Contato[] ListarContatos()
        {
            Contato[] c = new Contato[cc];
            Array.Copy(contatos, c, cc);
            return c;
        }

        public Grupo[] ListarGrupos()
        {
            Grupo[] g = new Grupo[gg];
            Array.Copy(grupos, g, gg);
            return g;
        }

        public override string ToString()
        {
            return $"contatos:{cc} - grupos: {gg}";
        }
    }
}
