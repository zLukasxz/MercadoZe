﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Model
{
    internal class Cliente
    {
        private static int IdCliente;
        private static string nomeCliente;
        private static string emailCliente;
        private static string foneCliente;

        public static int IdCliente1 { get => IdCliente; set => IdCliente = value; }
        public static string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public static string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public static string FoneCliente { get => foneCliente; set => foneCliente = value; }
    }
}
