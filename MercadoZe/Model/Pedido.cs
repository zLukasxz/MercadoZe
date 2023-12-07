using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Model
{
    internal class Pedido
    {
        private static int IdPedido;
        private static int IdCliente_Fk;
        private static int IdFunci_Fk;
        private static int IdItensProduto_Fk;
        private static DateTime DataCompra;
        private static int intTotalPedido;

        public static int IdPedido1 { get => IdPedido; set => IdPedido = value; }
        public static int IdCliente_Fk1 { get => IdCliente_Fk; set => IdCliente_Fk = value; }
        public static int IdFunci_Fk1 { get => IdFunci_Fk; set => IdFunci_Fk = value; }
        public static int IdItensProduto_Fk1 { get => IdItensProduto_Fk; set => IdItensProduto_Fk = value; }
        public static DateTime DataCompra1 { get => DataCompra; set => DataCompra = value; }
        public static int IntTotalPedido { get => intTotalPedido; set => intTotalPedido = value; }
    }
}
