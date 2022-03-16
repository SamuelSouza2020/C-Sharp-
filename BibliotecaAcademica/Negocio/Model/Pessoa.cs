using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Model
{
    public class Pessoa
    {
        private string nome;
        private string matricula;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
    }
}
