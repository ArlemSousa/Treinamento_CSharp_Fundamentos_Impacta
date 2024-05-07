using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.CSharp.Cap0910.Delegates.Lambda
{
    internal class Operacoes
    {

        //construtor padrão
        public Operacoes() { }

        //definir 2 delegates
        public delegate void Soma(int a, int b);
        public delegate void Subtracao(int a, int b);

        //criar agora dois metodos um para fazer subtracao e outro adicao

        public void Somar(int a, int b)
        {
            Console.WriteLine("Somando valores a resposta {0}", a + b);

        }

        public void Subtrair(int a, int b)
        {
            Console.WriteLine("Subtraindo valores a resposta {0}", a - b);

        }




    }
}
