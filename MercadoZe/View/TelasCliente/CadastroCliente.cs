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

namespace MercadoZe.View.TelasCliente
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Cliente.NomeCliente = txb_nome.Text;
            Cliente.EmailCliente = txb_email.Text;
            Cliente.FoneCliente = mtxb_telefone.Text; 

            ManipulaCliente manipulaCliente = new ManipulaCliente();
            manipulaCliente.AdicionaCliente();
        }
    }
}
