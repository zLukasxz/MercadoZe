using MercadoZe.Model;
using MercadoZe.View.TelasProduto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Controller
{
    internal class ManipulaProduto
    {
        public void AdicionaProduto()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_InserirProduto", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@nomeProduto", Produto.NomeProduto);
                cmd.Parameters.AddWithValue("@marcaProduto", Produto.MarcaProduto);
                cmd.Parameters.AddWithValue("@valorProduto", Produto.ValorProduto);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Produto Cadastrado com Sucesso.");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void DeletarProduto()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_DeletarProduto", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdProduto", Produto.IdProduto1);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Excluído com Sucesso.");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void VisualizarProdutoCod()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_BuscarCodigoProduto", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdProduto", Produto.IdProduto1);
                cn.Open();
                var dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Produto.IdProduto1 = Convert.ToInt32(dr["IdProduto"]);
                    Produto.NomeProduto = dr["nomeProduto"].ToString();
                    Produto.MarcaProduto = dr["marcaProduto"].ToString();
                    Produto.ValorProduto = dr["valorProduto"].ToString();
                }
                else
                {
                    Produto.IdProduto1 = 0;
                    Produto.NomeProduto = "";
                    Produto.MarcaProduto = "";
                    Produto.ValorProduto = "";
                    MessageBox.Show("Produto não encontrado.");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AlterarProduto()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_AlterarProduto", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdProduto", Produto.IdProduto1);
                cmd.Parameters.AddWithValue("@nomeProduto", Produto.NomeProduto);
                cmd.Parameters.AddWithValue("@marcaProduto", Produto.MarcaProduto);
                cmd.Parameters.AddWithValue("@valorProduto", Produto.ValorProduto);
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
        public static BindingSource VisualizarProduto()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_BuscarCodigoProduto", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdProduto", Produto.IdProduto1);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;
        }
    }
}
