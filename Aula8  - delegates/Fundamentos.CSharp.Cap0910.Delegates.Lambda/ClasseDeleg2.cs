using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.CSharp.Cap0910.Delegates.Lambda
{
    internal class ClasseDeleg2
    {
        // definir outro método static
        public static void Delegado2(string texto)
        {
            // tarefa
            Console.WriteLine("Esta é a chamada do método Delegado2: " + texto);
        }
    }
}
