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
    public partial class DeletarCliente : Form
    {
        public DeletarCliente()
        {
            InitializeComponent();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            Cliente.IdCliente1 = Convert.ToInt32(txb_MatriculaCliente.Text);
            ManipulaCliente manipulaCliente = new ManipulaCliente();
            manipulaCliente.DeletarCliente();
            txb_Nome.Text = "";
            txb_Email.Text = "";
            txb_Fone.Text = "";
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Cliente.IdCliente1 = Convert.ToInt32(txb_MatriculaCliente.Text);
            ManipulaCliente manipulaCliente = new ManipulaCliente();
            manipulaCliente.VisualizarClienteCod();
            txb_Nome.Text = Cliente.NomeCliente;
            txb_Fone.Text = Cliente.FoneCliente;
            txb_Email.Text = Cliente.EmailCliente;
        }
    }
}
