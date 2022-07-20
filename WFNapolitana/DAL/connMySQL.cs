using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WFNapolitana.DAL
{
    internal class connMySQL
    {
        private string server = "localhost";
        private string port = "3307";
        private string banco = "napolitanadb";
        private string user = "root";
        private string pass = "etecjau";

        private MySqlConnection conexao;

        public connMySQL()
        {
            string dsn = $"server={server};Port={port};database={banco};Uid={user};Pwd={pass}";
            conexao = new MySqlConnection(dsn);
        }

        public MySqlConnection conectar()
        {
            if(conexao.State == System.Data.ConnectionState.Closed) conexao.Open();
            return conexao;
        }

        public void desconectar()
        {
            if(conexao.State == System.Data.ConnectionState.Open) conexao.Close();
        }
    }
}
