using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Csharp.cap05.heranca.construtores
{
    internal class Entregador : Funcionario
    {
        public int QuantidadeEntregas { get; set; }
        //public string? MotoFab { get; set; }

        public string MotoFab = "Honda";

    }
}
