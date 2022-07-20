using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WFNapolitana.Model;

namespace WFNapolitana.DAL
{
    internal class LoginDAO
    {
        connMySQL conexao = new connMySQL();
        MySqlCommand stmt = new MySqlCommand();

        public LoginDAO()
        {
            stmt.Connection = conexao.conectar();
        }

        public MySqlDataReader selectByUserForLogin(LoginModel model)
        {
            stmt.CommandText = "SELECT * FROM Funcionario WHERE nome = @nome AND senha = sha1(@senha)";
            stmt.Parameters.AddWithValue("@nome", model.name.ToUpper());
            stmt.Parameters.AddWithValue("@senha", model.password);

            return stmt.ExecuteReader();
        }

    }
}
