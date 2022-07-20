using MySql.Data.MySqlClient;
using WFNapolitana.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFNapolitana.DAL
{
    internal class EstoqueDAO
    {
        connMySQL conexao = new connMySQL();
        MySqlCommand stmt = new MySqlCommand();

        public EstoqueDAO()
        {
            stmt.Connection = conexao.conectar();
        }

        public MySqlDataReader selectAllProdutos()
        {
            stmt.CommandText = "SELECT * FROM Produto";
            return stmt.ExecuteReader();
        }

        public MySqlDataReader buscarProduto(EstoqueModel model)
        {
            stmt.CommandText = "SELECT * FROM Produto WHERE nome LIKE @palavra_chave";
            string palavraChave = "%" + model.palavra_chave + "%";
            stmt.Parameters.AddWithValue("@palavra_chave", palavraChave);

            return stmt.ExecuteReader();
        }
    }
}
