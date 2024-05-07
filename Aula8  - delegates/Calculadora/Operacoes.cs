using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Operacoes
    {
        public Operacoes() { }

        public delegate void Soma(int a, int b);
        public delegate void Subtracao(int a, int b);
        public delegate void Divisao(int a, int b);
        public delegate void Multiplicacao(int a, int b);

        public void Somar(int a, int b)
        {
            Console.WriteLine("Somando valores a resposta {0}", a + b);
        }

        public void Subtrair(int a, int b)
        {
            Console.WriteLine("Subtraindo valores a resposta {0}", a - b);
        }

        public void Dividir(int a, int b)
        {
            Console.WriteLine("Dividindo valores a resposta {0}", a / b);
        }

        public void Multiplicar(int a, int b)
        {
            Console.WriteLine("Multiplicando valores a resposta {0}", a * b);
        }


    }
}
