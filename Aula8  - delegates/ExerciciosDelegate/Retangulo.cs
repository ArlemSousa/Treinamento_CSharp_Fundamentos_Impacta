using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDelegate
{
    internal class Retangulo 
    {
        //gerar construtor padrao
        public Retangulo() { }

        //criar o delegate
        public delegate void CalcularArea(double alturaRet, double baseret);


        public void Calcular(double alturaRet, double baseRet )
        {
            Console.WriteLine( alturaRet * baseRet);
        }



    }
}
