using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Model
{
    internal class Produto
    {
        private static int IdProduto;
        private static string nomeProduto;
        private static string marcaProduto;
        private static string valorProduto;

        public static int IdProduto1 { get => IdProduto; set => IdProduto = value; }
        public static string NomeProduto { get => nomeProduto; set => nomeProduto = value; }
        public static string MarcaProduto { get => marcaProduto; set => marcaProduto = value; }
        public static string ValorProduto { get => valorProduto; set => valorProduto = value; }
    }
}
