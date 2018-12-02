using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIB_EG
{
    class Cookie
    {
        public static int nivel;
    }
    class Parameters
    {
        //paths txt
        public class path
        {
            public static string produtos = "../../dados/produtos.txt";
            public static string usuarios = "../../dados/usuarios.txt";
            public static string senhas = "../../dados/backup/senhas.txt";
            public static string nivel = "../../dados/backup/nivel.txt";
            public static string bloqueados = "../../dados/backup/bloqueados.txt";
            public static string entrega = "../../dados/entrega.txt";
            public static string usuariosMorto = "../../dados/morto/usuarios.txt";
        }

    }

    class UserInformation
    {
        public static string usercode;
        public static string userinfo;
        public static string runUser;
        public static int nivelUser;
        public static string runPass;


    }
}
