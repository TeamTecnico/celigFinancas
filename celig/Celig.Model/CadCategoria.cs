using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celig.Model
{
        

        public class Despesa
    {
        public Despesa(double valor, string descricao, string categoria)
        {
            this.valor = valor;
            this.descricao = descricao;
            Categoria = categoria;
        }


        public Despesa()
        {

        }

        public double valor { get; set; }
        public string descricao { get; set; }
        public string Categoria { get; set; }
    }
}
