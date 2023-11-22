using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Model
{
    internal class Funcionario
    {
        private static int IdFunci;
        private static string nomeFunci;
        private static string foneFunci;
        private static string emailFunci;

        public static int IdFunci1 { get => IdFunci; set => IdFunci = value; }
        public static string NomeFunci { get => nomeFunci; set => nomeFunci = value; }
        public static string FoneFunci { get => foneFunci; set => foneFunci = value; }
        public static string EmailFunci { get => emailFunci; set => emailFunci = value; }
    }
}
