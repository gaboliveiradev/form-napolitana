using WFNapolitana.DAL;
using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFNapolitana.Model
{
    internal class EstoqueModel
    {
        public string palavra_chave;

        public MySqlDataReader buscar()
        {
            EstoqueDAO dao = new EstoqueDAO();
            return dao.buscarProduto(this);
        }

        public MySqlDataReader getAllRows()
        {
            EstoqueDAO dao = new EstoqueDAO();
            return dao.selectAllProdutos();
        }
    }
}
