using WFNapolitana.View;
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
    public partial class frmEconomico : Form
    {
        Thread t1;
        public frmEconomico()
        {
            InitializeComponent();

            lsvVenda.View = System.Windows.Forms.View.Details;
            lsvVenda.LabelEdit = false;
            lsvVenda.AllowColumnReorder = false;
            lsvVenda.FullRowSelect = true;
            lsvVenda.GridLines = true;

            lsvVenda.Columns.Add("NOME", 150, HorizontalAlignment.Left);
            lsvVenda.Columns.Add("PREÇO", 50, HorizontalAlignment.Left);
            lsvVenda.Columns.Add("QUANTIDADE", 100, HorizontalAlignment.Left);

            lsvDespesa.View = System.Windows.Forms.View.Details;
            lsvDespesa.LabelEdit = false;
            lsvDespesa.AllowColumnReorder = false;
            lsvDespesa.FullRowSelect = true;
            lsvDespesa.GridLines = true;

            lsvDespesa.Columns.Add("NOME", 150, HorizontalAlignment.Left);
            lsvDespesa.Columns.Add("PREÇO", 150, HorizontalAlignment.Left);
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirFormProdutos);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void AbrirFormProdutos(object obj)
        {
            Application.Run(new frmCadastrarProduto());
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

        private void bntSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        double SaldoVenda = 0, SaldoDespesa = 0, SaldoEmpresa = 0; 
        private void btnInserirVenda_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(txt_nomeproduto.Text);
            lvi.SubItems.Add(txt_preco.Text);
            lsvVenda.Items.Add(lvi);

            SaldoVenda = SaldoVenda + double.Parse(txt_preco.Text);
            SaldoTotal();
        }

        private void btnInserirNovo_Click(object sender, EventArgs e)
        {
            txt_nomeproduto.Clear();
            txt_preco.Clear();
            txt_nomedespesa.Clear();
            txt_valor.Clear();

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

        private void btnInserirDespesa_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(txt_nomedespesa.Text);
            lvi.SubItems.Add(txt_valor.Text);
            lsvDespesa.Items.Add(lvi);

            SaldoDespesa = SaldoDespesa + double.Parse(txt_valor.Text);
            SaldoTotal();
        }

        private void SaldoTotal()
        {
            SaldoEmpresa = SaldoVenda - SaldoDespesa;
            lblSaldo.Text = SaldoEmpresa.ToString("C");
        }
    }
}
