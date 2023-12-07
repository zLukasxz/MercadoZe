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
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Usuario.IdFunci_Fk1 = Convert.ToInt32(txb_NumeroMatricula.Text);
            Usuario.DataAcesso1 = txb_DataAcesso.Text;
            Usuario.Tipo1 = txb_Tipo.Text;
            Usuario.Senha1 = txb_Senha.Text;
            ManipulaUsuario manipulaUsuario = new ManipulaUsuario();
            manipulaUsuario.AdicionaUsuario();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Funcionario.IdFunci1 = Convert.ToInt32(txb_NumeroMatricula.Text);
            ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
            manipulaFuncionario.VisualizarFuncionarioCod();

            txb_Nome.Text = Funcionario.NomeFunci;
            txb_Email.Text = Funcionario.EmailFunci;
        }
    }
}
