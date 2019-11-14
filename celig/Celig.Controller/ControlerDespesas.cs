using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Celig.Model;

namespace Celig.Controller
{
    public static class ControlerDespesas
    {
        

        public static int CadCat(Categoria cat)
        {
            CadCategoriaDao cDao = new CadCategoriaDao();
            int resultado = cDao.InsertCat(cat);
            return resultado;        


        }
    }
}
