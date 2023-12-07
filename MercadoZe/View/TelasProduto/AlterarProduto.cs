using MercadoZe.Controller;
using MercadoZe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoZe.View.TelasProduto
{
    public partial class AlterarProduto : Form
    {
        public AlterarProduto()
        {
            InitializeComponent();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Produto.IdProduto1 = Convert.ToInt32(txb_CodigoProduto.Text);
            ManipulaProduto manipulaProduto = new ManipulaProduto();
            manipulaProduto.VisualizarProdutoCod();

            txb_Nome.Text = Produto.NomeProduto;
            txb_Marca.Text = Produto.MarcaProduto;
            txb_Valor.Text = Produto.ValorProduto;
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            Produto.IdProduto1 = Convert.ToInt32(txb_CodigoProduto.Text);
            Produto.NomeProduto = txb_Nome.Text;
            Produto.MarcaProduto = txb_Marca.Text;
            Produto.ValorProduto = txb_Valor.Text;
            ManipulaProduto manipulaProduto = new ManipulaProduto();
            manipulaProduto.AlterarProduto();
        }
    }
}
