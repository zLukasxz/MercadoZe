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

namespace MercadoZe.View.TelasFuncionario
{
    public partial class DeletarFuncionario : Form
    {
        public DeletarFuncionario()
        {
            InitializeComponent();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Funcionario.IdFunci1 = Convert.ToInt32(txb_MatriculaFunci.Text);
            ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
            manipulaFuncionario.VisualizarFuncionarioCod();

            txb_Nome.Text = Funcionario.NomeFunci;
            txb_Email.Text = Funcionario.EmailFunci;
            txb_Fone.Text = Funcionario.FoneFunci;
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            Funcionario.IdFunci1 = Convert.ToInt32(txb_MatriculaFunci.Text);
            ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
            manipulaFuncionario.DeletarFuncionario();
            txb_Nome.Text = "";
            txb_Email.Text = "";
            txb_Fone.Text = "";
        }
    }
}
