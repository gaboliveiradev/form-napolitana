using System.Threading;

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
    public partial class frmCaixa : Form
    {
        Thread t1;
        public frmCaixa()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirFormDashboard);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void AbrirFormDashboard(object obj)
        {
            Application.Run(new frmPrincipal());
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

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirFormProduto);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void AbrirFormProduto(object obj)
        {
            Application.Run(new frmCadastrarProduto());
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picExpandir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            picExpandir.Visible = false;
            picRestaurar.Visible = true;
        }

        private void picRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            picExpandir.Visible = true;
            picRestaurar.Visible = false;
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
