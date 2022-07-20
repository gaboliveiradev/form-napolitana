using MySql.Data.MySqlClient;
using WFNapolitana.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFNapolitana.DAL
{
    internal class CadastrarProdutoDAO
    {
        connMySQL conexao = new connMySQL();
        MySqlCommand stmt = new MySqlCommand();

        public CadastrarProdutoDAO()
        {
            stmt.Connection = conexao.conectar();
        }

        public MySqlDataReader selectAllProdutos()
        {
            stmt.CommandText = "SELECT * FROM Produto";
            return stmt.ExecuteReader();
        }

        public bool insertProduto(CadastrarProdutoModel model)
        {
            try
            {
                stmt.CommandText = "INSERT INTO Produto (nome, preco, quantidade) VALUES (@nome, @preco, @quantidade)";
                stmt.Parameters.AddWithValue("@nome", model.nome);
                stmt.Parameters.AddWithValue("@preco", model.preco);
                stmt.Parameters.AddWithValue("@quantidade", model.quantidade);

                stmt.ExecuteReader();
                return true;
            } catch (MySqlException err)
            {
                Console.WriteLine("Mensagem de ERRO:" + err.Message);
                return false;
            } finally
            {
                conexao.desconectar();
            }
        }
    }
}
