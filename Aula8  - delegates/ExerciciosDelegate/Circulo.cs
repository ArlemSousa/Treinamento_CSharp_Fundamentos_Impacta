using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDelegate
{
    internal class Circulo : IFigura
    {
        //gerar construtor padrao
        public Circulo()
        {
        }
        
        public double Raio { get; set; }

        public delegate void CalcularArea(double Raio);

        double IFigura.CalcularArea()
        {
            return (Math.PI * Math.Pow(Raio, 2));
        }

        public void Calcular(double Raio)
        {
            Console.WriteLine(Math.PI * Math.Pow(Raio, 2));
        }
    }
}
