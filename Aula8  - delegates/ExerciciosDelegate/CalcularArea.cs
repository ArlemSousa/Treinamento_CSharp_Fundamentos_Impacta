using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDelegate
{
    internal class CalcularArea 
    {
        public CalcularArea()
        {
        }

        //criar os dois delegates
        public delegate void CalcularAreaCirculo(double raio); 
        public delegate void CalcularAreaRetangulo(double alturaRetangulo, double baseRetangulo);

        //criar os dois metodos para calcular as areas
        public void CalcularCirculo(double raio)
        {
            Console.WriteLine("o Raio do circulo informado é {0}", Math.PI * Math.Pow(raio, 2));

        }

        public void CalcularRetangulo(int tBase, int tAltura)
        {
            Console.WriteLine("Subtraindo valores a resposta {0}", tAltura * tBase);

        }

    }
}
