using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Model
{
    class Aluno : Pessoa
    {
        private string mae;
        private string pai;

        public string Mae
        {
            get { return mae; }
            set { mae = value; }
        }
        public string Pai
        {
            get { return pai; }
            set { pai = value; }
        }
    }
}
