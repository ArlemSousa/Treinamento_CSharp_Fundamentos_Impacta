using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    //praticar herança com a classe figura
    internal class Retangulo : Figura
    {
        //definir props particulares da classe retangulo para impementar o metodo calcularArea
        public double Base { get; set; }
        public double Altura { get; set; }

        public Retangulo() { } //este é o metodo especial construtor da classe retangulo - agora descrito de forma direta/explicita;


        public Retangulo(double Base, double Altura) { //os parametros são variaveis locais, observadas somente a partir da definicao do metodo construtor-custom.

            this.Base = Base;
            this.Altura = Altura;

        }

        public override double CalcularArea()
        {
            return this.Base * this.Altura;
        } //metodo construtor padrão

        //um construtor só pode ser declarado com public e nunca possui expressao de retorno.
    }
}
