using MercadoZe.Model;
using MercadoZe.View.TelasFuncionario;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Controller
{
    internal class ManipulaFuncionario
    {
        public void AdicionaFuncionario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_InserirFunci", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@nomeFunci", Funcionario.NomeFunci);
                cmd.Parameters.AddWithValue("@foneFunci", Funcionario.FoneFunci);
                cmd.Parameters.AddWithValue("@emailFunci", Funcionario.EmailFunci);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário Cadastrado com Sucesso.");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
