using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Sistema_login_3
{
    public class CoreBrige
    {
        public string User { get; set; }
        public string Password { get; set; }
        public string email { get; set; }
        public string CPF { get; set;}
        public string Phone { get; set; }
        public int Caracter { get; set; }
        
        public bool loginvalido { get;  set; }
        

        public CoreBrige ()
        {
            Caracter = 8;
        }
        public bool Condiçoes()
        {
            return Password.Length < Caracter;

        }
     
    }
    public static class GerenciadorLogin
    {
        public static List<CoreBrige> Logins { get; private set; }
        static GerenciadorLogin()
        {
            Logins = new List<CoreBrige>();
        }
        public static void AdicionarLogin(CoreBrige B)
        {
            Logins.Add(B);
        }
    }

}
