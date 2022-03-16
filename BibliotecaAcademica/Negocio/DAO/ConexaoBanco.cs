using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Negocio.DAO
{
    public class ConexaoBanco
    {
        public static MySqlConnection Conectar()
        {
            string stringConexao = @"Server=localhost;database=connectcsharptomysql;User=root;";
            MySqlConnection conexao = new MySqlConnection(stringConexao);
            conexao.Open();
            return conexao;
        }
    }
}
