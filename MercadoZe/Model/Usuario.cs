using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Model
{
    internal class Usuario
    {
        private static int IdUsuario;
        private static int IdFunci_Fk;
        private static string DataAcesso;
        private static string Tipo;
        private static string Senha;

        public static int IdUsuario1 { get => IdUsuario; set => IdUsuario = value; }
        public static int IdFunci_Fk1 { get => IdFunci_Fk; set => IdFunci_Fk = value; }
        public static string DataAcesso1 { get => DataAcesso; set => DataAcesso = value; }
        public static string Tipo1 { get => Tipo; set => Tipo = value; }
        public static string Senha1 { get => Senha; set => Senha = value; }
    }
}
