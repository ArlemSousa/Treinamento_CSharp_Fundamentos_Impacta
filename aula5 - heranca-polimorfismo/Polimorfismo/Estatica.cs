using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public static class Estatica
    {
        public static int Numero1 { get; set; }

        public static void Leitura()
        {
            Console.WriteLine( Numero1);
        }

    }
}
