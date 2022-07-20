using WFNapolitana.View;
using WFNapolitana.Model;
using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WFNapolitana
{
    public partial class frmLogin : Form
    {        
        public frmLogin()
        {
            InitializeComponent();
        }

        public void entrar()
        {
            string user = txt_usuario.Text;
            string senha = txt_senha.Text;
            LoginModel loginModel = new LoginModel();

            loginModel.name = user;
            loginModel.password = senha;
            bool retorno = loginModel.autenticarLogin();

            Console.WriteLine(retorno);
            if(retorno)
            {
                this.Hide();
            } else
            {
                lblMsgErro.Text = "Usuário e/ou senha incorretos. Verifique e tente novamente.";
            }
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            entrar();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
