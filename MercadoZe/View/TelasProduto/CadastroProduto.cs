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
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void btn_CadastroProduto_Click(object sender, EventArgs e)
        {
            Produto.NomeProduto = txb_nomeProduto.Text;
            Produto.MarcaProduto = txb_marcaProduto.Text;
            Produto.ValorProduto = txb_valorProduto.Text;

            ManipulaProduto manipulaProduto = new ManipulaProduto();
            manipulaProduto.AdicionaProduto();
        }
    }
}
