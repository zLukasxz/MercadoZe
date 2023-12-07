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

namespace MercadoZe.View.TelasUsuario
{
    public partial class DeletarUsuario : Form
    {
        public DeletarUsuario()
        {
            InitializeComponent();
        }

        private void btn_BuscarUsuario_Click(object sender, EventArgs e)
        {
            Usuario.IdUsuario1 = Convert.ToInt32(txb_MatriculaUsuario.Text);
            ManipulaUsuario manipula = new ManipulaUsuario();
            manipula.VisualizarUsuarioCod();

            txb_TipoUsuario.Text = Usuario.Tipo1;
            txb_NomeUsuario.Text = Funcionario.NomeFunci;
            txb_EmailUsuario.Text = Funcionario.EmailFunci;
            txb_NumeroUsuario.Text = Usuario.IdUsuario1.ToString();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            Usuario.IdUsuario1 = Convert.ToInt32(txb_NumeroUsuario.Text);
            ManipulaUsuario manipulaUsuario = new ManipulaUsuario();
            manipulaUsuario.DeletarUsuario();
            txb_NomeUsuario.Text = "";
            txb_EmailUsuario.Text = "";
            txb_TipoUsuario.Text = "";
        }
    }
}
