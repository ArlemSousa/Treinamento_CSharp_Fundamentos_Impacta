using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CorrecaoExercicio1
{
    internal class Venda
    {
        //prop estatica inteirra
        public static int Quantidade { get; set; }

        //metodo que incrementa a prop estatica
        public void Incrementar()
        {
            Quantidade++;
        }

        //retornar
        public int RetornarQuantidade()
        {
            return Quantidade;
        }

    }
}
