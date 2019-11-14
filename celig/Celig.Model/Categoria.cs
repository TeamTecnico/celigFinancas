using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celig.Model
{
    public class Categoria
    {
       
        public string Descricao { get; set; }

        public Categoria()
        {
              
        }

        public Categoria(string descricao)
        {
            Descricao = descricao;
        }
    }
}
