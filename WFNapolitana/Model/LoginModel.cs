using WFNapolitana.DAL;
using WFNapolitana.View;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFNapolitana.Model
{
    internal class LoginModel : Form
    {
        public string name, password;
        public MySqlDataReader dr;
        public string id, nome;

        public bool autenticarLogin()
        {
            LoginDAO loginDAO = new LoginDAO();
            dr = loginDAO.selectByUserForLogin(this);
            while (dr.Read())
            {
                id = dr.GetString("id");
                nome = dr.GetString("nome");
            }

            if (id != null)
            {
                frmPrincipal principal = new frmPrincipal();
                principal.id_operador = int.Parse(id);
                principal.lblNomeOperador.Text = $"Seja Bem Vindo(a) {nome} | Seu ID: {id}";
                principal.Show();

                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
