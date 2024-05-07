using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.CSharp.Cap0910.Delegates.Lambda
{
    internal class ClasseDeleg1
    {
        // definir um método static
        public static void Delegado1(string texto)
        {
            // tarefa a ser executada
            Console.WriteLine("Chamada do método Delegado1 -> " + texto);
        }
    }
}
