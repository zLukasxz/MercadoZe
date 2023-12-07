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
        public void DeletarFuncionario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_DeletarFunci", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdFunci", Funcionario.IdFunci1);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Excluído com Sucesso.");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void VisualizarFuncionarioCod()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_BuscarCodigoFunci", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdFunci", Funcionario.IdFunci1);
                cn.Open();
                var dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Funcionario.IdFunci1 = Convert.ToInt32(dr["IdFunci"]);
                    Funcionario.NomeFunci = dr["NomeFunci"].ToString();
                    Funcionario.FoneFunci = dr["FoneFunci"].ToString();
                    Funcionario.EmailFunci = dr["EmailFunci"].ToString();
                }
                else
                {
                    Funcionario.IdFunci1 = 0;
                    Funcionario.NomeFunci = "";
                    Funcionario.FoneFunci = "";
                    Funcionario.EmailFunci = "";
                    MessageBox.Show("Funcionário(a) não encontrado.");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AlterarFunci()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_AlterarFunci", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdFunci", Funcionario.IdFunci1);
                cmd.Parameters.AddWithValue("@nomeFunci", Funcionario.NomeFunci);
                cmd.Parameters.AddWithValue("@foneFunci", Funcionario.FoneFunci);
                cmd.Parameters.AddWithValue("@emailFunci", Funcionario.EmailFunci);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionário Alterado com Sucesso.");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Usuário não alterado");
            }
            finally { cn.Close(); }
        }

    }
}

