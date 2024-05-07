using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    
        public class Incremento
        {

            private static int _numeroEstatico;

        //defina - como parte da classe uma propriedade estatica numérica
        public static int NumeroEstatico
            {
                get => _numeroEstatico;
                set => _numeroEstatico = value;
            }

        //um método que incrementa a propriedade estatica
            public static void IncrementarNumero()
            {
                NumeroEstatico++;
            }

        //um método que retorna o valor da propriedade estatica definida anteriormente
            public static int ObterNumero()
            {
                return NumeroEstatico;
            }
        }

    
}
