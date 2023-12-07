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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btn_Entrar_Click_1(object sender, EventArgs e)
        {
            string usuario = txb_UsuarioLogin.Text;
            string senha = txb_SenhaLogin.Text;

            if (usuario == "admin" && senha == "123")
            {
                this.Hide();
                MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.FormClosed += (s, args) => this.Close();
                menuPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Credenciais incorretas.");
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
