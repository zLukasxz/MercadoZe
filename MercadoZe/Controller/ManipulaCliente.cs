using MercadoZe.Model;
using MercadoZe.View.TelasCliente;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Controller
{
    internal class ManipulaCliente
    {
        public void AdicionaCliente() 
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_InserirCliente", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@nomeCliente", Cliente.NomeCliente);
                cmd.Parameters.AddWithValue("emailCliente", Cliente.EmailCliente);
                cmd.Parameters.AddWithValue("foneCliente", Cliente.FoneCliente);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Cadastrado com Sucesso.");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void DeletarCliente()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_DeletarClientes", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdCliente", Cliente.IdCliente1);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Excluído com Sucesso.");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void VisualizarClienteCod()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_BuscarCodigoCliente", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdCliente", Cliente.IdCliente1);
                cn.Open();
                var dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Cliente.IdCliente1 = Convert.ToInt32(dr["IdCliente"]);
                    Cliente.NomeCliente = dr["NomeCliente"].ToString();
                    Cliente.EmailCliente = dr["EmailCliente"].ToString();
                    Cliente.FoneCliente = dr["FoneCliente"].ToString();
                }
                else
                {
                    Cliente.IdCliente1 = 0;
                    Cliente.NomeCliente = "";
                    Cliente.EmailCliente = "";
                    Cliente.FoneCliente = "";
                    MessageBox.Show("Client não encontrado.");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AlterarCliente()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_AlterarClientes", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdCliente", Cliente.IdCliente1);
                cmd.Parameters.AddWithValue("@nomeCliente", Cliente.NomeCliente);
                cmd.Parameters.AddWithValue("@emailCliente", Cliente.EmailCliente);
                cmd.Parameters.AddWithValue("@foneCliente", Cliente.FoneCliente);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente Alterado com Sucesso.");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Cliente não alterado");
            }
            finally { cn.Close(); }
        }
    }
}
