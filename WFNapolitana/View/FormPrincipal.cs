using System.Threading;
using WFNapolitana.Model;
using WFNapolitana.View;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFNapolitana.View
{
    public partial class frmPrincipal : Form
    {
        Thread t1;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void picFechar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picExpandir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            picExpandir.Visible = false;
            picRestaurar.Visible = true;
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            picExpandir.Visible = true;
            picRestaurar.Visible = false;
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirFormCadastrarProduto);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirFormEstoque);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void AbrirFormEstoque(object obj)
        {
            Application.Run(new frmEstoque());
        }

        private void AbrirFormCadastrarProduto(object obj)
        {
            Application.Run(new frmCadastrarProduto());
        }

        private void btnControleEconomico_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirFormEconomico);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void AbrirFormEconomico(object obj)
        {
            Application.Run(new frmEconomico());
        }

        private void btnPVD_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirFormPDV);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void AbrirFormPDV(object obj)
        {
            Application.Run(new frmPDV());
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirFormCaixa);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void AbrirFormCaixa(object obj)
        {
            Application.Run(new frmCaixa());
        }
    }
}
