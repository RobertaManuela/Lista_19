using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Grupo
    {
        private string descricao;
        private int k;

        private Contato[] contatos1 = new Contato[200];

        public Grupo(string d)
        {
            descricao = d;
        }

        public void Adicionar(Contato c)
        {
            contatos1[k++] = c;
        }

        public void Excluir(Contato c)
        {

        }

        public Contato[] ListarContatos()
        {
            Contato[] p = new Contato[k];
            Array.Copy(contatos1, p, k);
            return p;
        }

        public override string ToString()
        {
            return $"descrição:'{descricao}' - pessoas do grupo: {k}";
        }
    }
}
