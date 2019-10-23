using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celig.Model
{
   public class Login
    {
        public Login(string userName, string password, bool validacao)
        {
            this.userName = userName;
            this.password = password;
            this.validacao = validacao;
        }

        public Login()
        {

        }


        public string userName { get; set; }
        public string password { get; set; }
        public bool validacao { get; set; }



    }
}
