using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Model
{
    class Professor : Pessoa
    {
        private string disciplina;
        public string Disciplina
        {
            get { return disciplina; }  
            set { disciplina = value; }
        }
    }
}
