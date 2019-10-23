using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Celig.Model;

namespace Celig.Controller
{
    public class ControlerLogin
    {

        public bool Acessar(Login log)
        {
            LoginDao dao = new LoginDao();
            log.validacao = dao.Teste(log);
            return log.validacao;
        }

    }
}
