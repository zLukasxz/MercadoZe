using MercadoZe.Model;
using MercadoZe.View.TelasProduto;
using System;
using System.Collections.Generic;
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
    }
}
