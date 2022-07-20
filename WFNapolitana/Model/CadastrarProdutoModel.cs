using WFNapolitana.DAL;
using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFNapolitana.Model
{
    internal class CadastrarProdutoModel
    {
        public string nome, preco, quantidade;
        public string palavra_chave;

        public bool salvar()
        {
            CadastrarProdutoDAO dao = new CadastrarProdutoDAO();
            bool retorno = dao.insertProduto(this);
            return (retorno) ? true : false;
        }

        public MySqlDataReader getAllRows()
        {
            CadastrarProdutoDAO dao = new CadastrarProdutoDAO();
            return dao.selectAllProdutos();
        }
    }
}
