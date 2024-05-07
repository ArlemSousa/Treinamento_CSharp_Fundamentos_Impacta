using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    /*
    //praticar herança com a classe abstract figura
    internal class Circulo : Figura
    {
        //definir uma prop
        public double raio { get; set; }

        //definir o construtor padrao
        public Circulo()
        {

        }

        public Circulo( double raio)
        {
            this.raio = raio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(this.raio, 2); //PI * R^2
        }
    }

    */

    //praticar herança com a classe abstract figura
    public sealed class Circulo : Figura
    {
        //definir uma prop
        public double raio { get; set; }

        //definir o construtor padrao
        public Circulo()
        {

        }

        public Circulo(double raio)
        {
            this.raio = raio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(this.raio, 2); //PI * R^2
        }
    }

}
