﻿using MercadoZe.Controller;
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

namespace MercadoZe.View.TelasPedido
{
    public partial class TelaPDV : Form
    {
        public TelaPDV()
        {
            InitializeComponent();
        }

        private void btn_Confirma_Click(object sender, EventArgs e)
        {
            Produto.IdProduto1 = Convert.ToInt32(txb_CodBarras.Text);
            ManipulaProduto manipulaProduto = new ManipulaProduto();
            manipulaProduto.VisualizarProdutoCod();
            lbl_CodBarras.Text = txb_CodBarras.Text;
            lbl_Produto.Text = Produto.NomeProduto;
            lbl_Qtd.Text = txb_Qtd.Text;
            lbl_ValorUnit.Text = Produto.ValorProduto;
            lbl_ValorTotal.Text = Convert.ToString(Convert.ToInt64(lbl_Qtd.Text) * Convert.ToInt64(lbl_ValorUnit.Text));



            //dgv_PDV.DataSource = ManipulaProduto.VisualizarProduto();
            //dgv_PDV.Columns[0].HeaderCell.Value = "Código";
            //dgv_PDV.Columns[1].HeaderCell.Value = "Produto";
            //dgv_PDV.Columns[2].HeaderCell.Value = "Marca";
            //dgv_PDV.Columns[3].HeaderCell.Value = "Valor";
            //dgv_PDV.Columns[4].HeaderCell.Value = "Quantidade";
            //dgv_PDV.Columns[5].HeaderCell.Value = "Total";
        }
    }
}
