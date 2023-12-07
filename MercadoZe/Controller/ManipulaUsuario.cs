using MercadoZe.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Controller
{
    internal class ManipulaUsuario
    {
        public void AdicionaUsuario() 
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_InserirUsuario", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@IdFunci_Fk", Usuario.IdFunci_Fk1);
                cmd.Parameters.AddWithValue("@DataAcesso", Usuario.DataAcesso1);
                cmd.Parameters.AddWithValue("@Tipo", Usuario.Tipo1);
                cmd.Parameters.AddWithValue("@Senha", Usuario.Senha1);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Usuário Cadastrado com Sucesso.");

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeletarUsuario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_DeletarUsuario", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdUsuario",Usuario.IdUsuario1);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Excluído com Sucesso.");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void VisualizarUsuarioCod()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_BuscarCodigoUsuario", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdFuncionario", Usuario.IdUsuario1);
                cn.Open();
                var dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Usuario.IdUsuario1 = Convert.ToInt32(dr["IdUsuario"]);
                    Usuario.IdFunci_Fk1 = Convert.ToInt32(dr["IdFunci_Fk"]);
                    Usuario.DataAcesso1 = dr["DataAcesso"].ToString();
                    Usuario.Tipo1 = dr["Tipo"].ToString();
                    Usuario.Senha1 = dr["Senha"].ToString();
                    Funcionario.NomeFunci = dr["NomeFunci"].ToString();
                    Funcionario.EmailFunci = dr["EmailFunci"].ToString();
                }
                else 
                {
                    Usuario.IdUsuario1 = 0;
                    Usuario.IdFunci_Fk1 = 0;
                    Usuario.DataAcesso1 = "";
                    Usuario.Tipo1 = "";
                    Usuario.Senha1 = "";
                    MessageBox.Show("Busca não Executada.");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AlterarUsuario() 
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_AlterarUsuario", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdFunci_Fk", Usuario.IdFunci_Fk1);
                cmd.Parameters.AddWithValue("@Tipo", Usuario.Tipo1);
                cmd.Parameters.AddWithValue("@Senha", Usuario.Senha1);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário Alterado com Sucesso.");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Usuário não alterado");
            }
            finally { cn.Close(); }
        }
        public static BindingSource VisualizarTipoUsuario() 
            {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_BuscarTipoUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@TipoUsuario", Usuario.Tipo1);
            cn.Open();
            cmd.ExecuteNonQuery() ;

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;
            }
    }
}
