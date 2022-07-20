using WFNapolitana.Model;
using MySql.Data.MySqlClient;
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
    public partial class frmEstoque : Form
    {
        Thread t1;

        public frmEstoque()
        {
            InitializeComponent();

            lsvProdutos.View = System.Windows.Forms.View.Details;
            lsvProdutos.LabelEdit = false;
            lsvProdutos.AllowColumnReorder = false;
            lsvProdutos.FullRowSelect = true;
            lsvProdutos.GridLines = true;

            lsvProdutos.Columns.Add("ID", 50, HorizontalAlignment.Left);
            lsvProdutos.Columns.Add("NOME", 300, HorizontalAlignment.Left);
            lsvProdutos.Columns.Add("PREÇO", 50, HorizontalAlignment.Left);
            lsvProdutos.Columns.Add("QUANTIDADE", 300, HorizontalAlignment.Left);

            EstoqueModel model = new EstoqueModel();
            MySqlDataReader dr = model.getAllRows();

            while (dr.Read())
            {
                string[] row =
                {
                    dr.GetString("id"),
                    dr.GetString("nome"),
                    dr.GetString("preco"),
                    dr.GetString("quantidade")
                };

                var linha_lsv = new ListViewItem(row);

                lsvProdutos.Items.Add(linha_lsv);
            }
        }

        private void picRestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            picExpandir.Visible = true;
            picRestaurar.Visible = false;
        }

        private void picExpandir_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            picExpandir.Visible = false;
            picRestaurar.Visible = true;
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picFechar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            EstoqueModel model = new EstoqueModel();
            model.palavra_chave = txt_buscar.Text;

            lsvProdutos.Items.Clear();

            MySqlDataReader dr = model.buscar();
            while (dr.Read())
            {
                string[] row =
                {
                    dr.GetString("id"),
                    dr.GetString("nome"),
                    dr.GetString("preco"),
                    dr.GetString("quantidade")
                };

                var linha_lsv = new ListViewItem(row);
                lsvProdutos.Items.Add(linha_lsv);
            }
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
    }
}
