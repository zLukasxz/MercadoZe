using MercadoZe.View.TelasCliente;
using MercadoZe.View.TelasFuncionario;
using MercadoZe.View.TelasPedido;
using MercadoZe.View.TelasProduto;
using MercadoZe.View.TelasUsuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoZe.View.Menu
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btn_CadastroCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente();
            cadastroCliente.Show();
        }

        private void btn_AlterarCliente_Click(object sender, EventArgs e)
        {
            AlterarCliente alterarCliente = new AlterarCliente();
            alterarCliente.Show();
        }

        private void btn_BuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btn_DeletarCliente_Click(object sender, EventArgs e)
        {
            DeletarCliente deletarCliente = new DeletarCliente();
            deletarCliente.Show();
        }

        private void btn_CadastroFunci_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cadastroFuncionario = new CadastroFuncionario();
            cadastroFuncionario.Show();
        }

        private void btn_AlterarFunci_Click(object sender, EventArgs e)
        {
            AlterarFuncionario alterarFuncionario = new AlterarFuncionario();
            alterarFuncionario.Show();
        }

        private void btn_BuscarFunci_Click(object sender, EventArgs e)
        {

        }

        private void btn_DeletarFunci_Click(object sender, EventArgs e)
        {
            DeletarFuncionario deletarFuncionario= new DeletarFuncionario();
            deletarFuncionario.Show();
        }

        private void btn_CadastroPedido_Click(object sender, EventArgs e)
        {
            CadastroPedido cadastroPedido = new CadastroPedido();
            cadastroPedido.Show();
        }

        private void btn_AlterarPedido_Click(object sender, EventArgs e)
        {

        }

        private void btn_BuscarPedido_Click(object sender, EventArgs e)
        {
            TelaPDV telaPDV = new TelaPDV();
            telaPDV.Show();
        }

        private void btn_DeletarPedido_Click(object sender, EventArgs e)
        {

        }

        private void btn_CadastrarProduto_Click(object sender, EventArgs e)
        {
            CadastroProduto cadastroProduto = new CadastroProduto();
            cadastroProduto.Show();
        }

        private void btn_AlterarProduto_Click(object sender, EventArgs e)
        {
            AlterarProduto alterarProduto = new AlterarProduto();
            alterarProduto.Show();
        }

        private void btn_BuscarProduto_Click(object sender, EventArgs e)
        {

        }

        private void btn_DeletarProduto_Click(object sender, EventArgs e)
        {
            DeletarProduto deletarProduto = new DeletarProduto();
            deletarProduto.Show();
        }

        private void btn_CadastrarUsuario_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadastroUsuario = new CadastroUsuario();
            cadastroUsuario.Show();
        }

        private void btn_AlterarUsuario_Click(object sender, EventArgs e)
        {
            AlterarUsuario alterarUsuario = new AlterarUsuario();
            alterarUsuario.Show();
        }

        private void btn_BuscarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btn_DeletarUsuario_Click(object sender, EventArgs e)
        {
            DeletarUsuario deletarUsuario = new DeletarUsuario();
            deletarUsuario.Show();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}