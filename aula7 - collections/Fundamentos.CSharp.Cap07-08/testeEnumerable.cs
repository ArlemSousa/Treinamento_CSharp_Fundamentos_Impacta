using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.CSharp.Cap07_08.Colecoes.Genererics
{
    internal class testeEnumerable
    {
        //definir um metodo static para executar uma determinada tarefa

        public static IEnumerable<string> ListaNomes()
        {
            //a definir um array de nomes
            string[] nomes = { "daniel", "everton", "sandro", "julio", "priscila", "johson", "andre", "marcelo", "gustavo", "Francisco" };

            //definir um loop para iterar sobre a coleção
            foreach (string item in nomes)
            {
                //definir um parametro pelo qual a var iteradora poderá exibir alguns valores em tela.
                if (item.StartsWith("j"))
                {
                    yield return item;
                    //auxiliar de iteração
                    //quando o metodo for chamado a sua execução 
                }
            }
        }

    }
}
