using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Csharp.Cap06.Interfaces
{
    //pratricar o mecanismo de heranca com a interface
    internal class Retangulo : IFigura
    {

        //definir o construtor
        public Retangulo() { }

        //definir as props
        public double Base { get; set; }
        public double Altura { get; set; }

        public double CalcularArea()
        {
            return this.Altura * this.Base;
        }
    }
}
