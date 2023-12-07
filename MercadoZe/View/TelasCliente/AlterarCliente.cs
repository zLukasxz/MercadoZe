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
    public partial class AlterarCliente : Form
    {
        public AlterarCliente()
        {
            InitializeComponent();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            Cliente.IdCliente1 = Convert.ToInt32(txb_MatriculaCliente.Text);
            Cliente.NomeCliente = txb_Nome.Text;
            Cliente.EmailCliente = txb_Email.Text;
            Cliente.FoneCliente = txb_Fone.Text;
            ManipulaCliente manipulaCliente = new ManipulaCliente();
            manipulaCliente.AlterarCliente();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Cliente.IdCliente1 = Convert.ToInt32(txb_MatriculaCliente.Text);
            ManipulaCliente manipulaCliente = new ManipulaCliente();
            manipulaCliente.VisualizarClienteCod();

            txb_Nome.Text = Cliente.NomeCliente;
            txb_Email.Text = Cliente.EmailCliente;
            txb_Fone.Text = Cliente.FoneCliente;
        }
    }
}
