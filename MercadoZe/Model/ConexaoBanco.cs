using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Model
{
    internal class ConexaoBanco
    {
        public static string Conectar() 
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lucas.bflor1\source\repos\MercadoZe\MercadoZe\BancoDados\mercadobd.mdf;Integrated Security=True";
        }
    }
}
