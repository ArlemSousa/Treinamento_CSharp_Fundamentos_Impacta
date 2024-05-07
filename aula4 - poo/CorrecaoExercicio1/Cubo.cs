using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrecaoExercicio1
{
    internal class Cubo
    {
        /*primeira abordagem*/
        //definir uma prop private para receber  como valor um elemento numerico.
        private int _lado;

        public int Lado
        {
            get { return _lado; }
            set { _lado = value; }
        }

        //definir metodo para calculo do cubo
        private string _ExibirVolumeCubo()
        {
            //definir uma var para receber como valor o calculo do volume do cubo
            //int volume =  Lado * Lado * Lado;

            int resultVol = (int)Math.Pow(Lado, 3);

            return string.Format("O volume é: {0} ", resultVol); 
                ;
        }

        //encapsumar metodo privado pra conseguir acessar ele na main

        public string ExibirVolumeCubo()
        {
          return _ExibirVolumeCubo();

        }

    }
}
