using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.cap13.DB
{
    internal class Categorias
    {
        //esta classe será a Model domain - provê um conjunto de regras pelas quais os dados serao manipulados

        //construtor padrao
        public Categorias()
        {
        }

        //propriedades com encapsulamento implicito
        public int IdCategoria { get; set; }
        public string Descricao { get; set; }




    }
}
