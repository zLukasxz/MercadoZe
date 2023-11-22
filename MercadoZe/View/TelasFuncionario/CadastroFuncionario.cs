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
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
        }
        private void btn_CadastrarFunci_Click_1(object sender, EventArgs e)
        {
            Funcionario.NomeFunci = txb_NomeFunci.Text;
            Funcionario.FoneFunci = txb_FoneFunci.Text;
            Funcionario.EmailFunci = txb_EmailFunci.Text;

            ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
            manipulaFuncionario.AdicionaFuncionario();
        }
    }
}
