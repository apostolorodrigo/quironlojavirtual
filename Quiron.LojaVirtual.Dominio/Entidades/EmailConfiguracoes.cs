using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Entidades
{
    public class EmailConfiguracoes
    {
        public bool UsarSsl = false;
        public string ServidorSmtp = "localhost";
        public int ServidorPorta = 587;
        public string Usuario = "Rodrigo";
        public bool EscreverArquivo = false;
        public string PastaArquivo = @"F:\DevMidia\Formacao_net_Developer\ASP.NET_MVC\Criando_Uma_Loja_Virtual\Email";
        public string De = "rodrigo@marques.com.br";
        public string Para = "marques@rodrigo.com.br";
    }
}