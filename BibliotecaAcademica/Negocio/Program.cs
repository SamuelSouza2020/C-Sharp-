﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.DAO;

namespace Negocio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConexaoBanco.Conectar();
        }
    }
}
