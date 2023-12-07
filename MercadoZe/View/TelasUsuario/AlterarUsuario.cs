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
    public partial class AlterarUsuario : Form
    {
        public AlterarUsuario()
        {
            InitializeComponent();
        }

        private void btn_Alterar_Click_1(object sender, EventArgs e)
        {
            Usuario.IdUsuario1 = Convert.ToInt32(txb_NumeroUsuario.Text);
            Usuario.Senha1 = txb_Senha.Text;
            Usuario.Tipo1 = txb_Tipo.Text;
            ManipulaUsuario manipula = new ManipulaUsuario();
            manipula.AlterarUsuario();
        }

        private void btn_Buscar_Click_1(object sender, EventArgs e)
        {
            Usuario.IdUsuario1 = Convert.ToInt32(txb_MatriculaFunci.Text);
            ManipulaUsuario manipula = new ManipulaUsuario();
            manipula.VisualizarUsuarioCod();

            txb_Nome.Text = Funcionario.NomeFunci;
            txb_Email.Text = Funcionario.EmailFunci;
            txb_Tipo.Text = Usuario.Tipo1;
            txb_Senha.Text = Usuario.Senha1;
            txb_NumeroUsuario.Text = Usuario.IdUsuario1.ToString();
        }
    }
}
