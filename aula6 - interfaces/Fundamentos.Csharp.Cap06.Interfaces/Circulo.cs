using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Csharp.Cap06.Interfaces
{
    //praticar o mecanismo de herança com a interface
    internal class Circulo : IFigura
    {

        //criar o construtor padrao 
        public Circulo() { }

        //definir uma propriedade para receber o encapsulamento implicito
        public double Raio { get; set; }

        //implementar o metodo descrito na estrutura da interface
        public double CalcularArea()
        {
            //definir a expressão de retorno do método
            return Math.PI * Math.Pow(this.Raio, 2);
        }
    }
}
