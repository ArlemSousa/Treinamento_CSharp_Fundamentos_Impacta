using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.CSharp.Cap03.POO
{
    internal class OutroElemStatic
    {
        // definir um método private e static
        private static int _multiplicar(int valor1, int valor2)
        {
            // definir a expressão de retorno do método - por ser diferente de void
            return valor1 * valor2;
        }

        // definir o encapsulamento do método private
        public static int Multiplicar(int v1, int v2)
        {
            return _multiplicar(v1, v2); //aqui o metodo private é chamado a sua execução
        }

    }
}
