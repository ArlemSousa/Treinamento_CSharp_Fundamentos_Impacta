using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.CSharp.Cap07_08.Colecoes.Genererics
{
    internal class ClasseArray
    {
        /*primeira abordagem

        //definir um metodo static
        public static decimal CalcularMedia(params decimal[] notas)
        {
            //definir uma var que recebe um valor inicial
            decimal soma = 0;


            //definir um loop para iterar sobre o conjunto de dados que é o nosso array de notas
            for(int i = 0; i < notas.GetLength(0); i++)
            {
                soma = soma + notas[i];
            }

            return soma / notas.Length;

        }    
        */


        public static void ExibirValores(params object[] valoresDiferentes) //fazendo o uso de object é possivel compor um array com valores de diferentes naturezas.
        {
            //definir uma estrutura de repetição para iterar sobre io cj de dados.
            foreach (object vascular in valoresDiferentes)
            {
                //exibir os valores do array
                Console.WriteLine("Valores encontrados: " + vascular);

                //exibir os datatypes encontrados dentro da coleção
                Console.WriteLine("tipo de dados encontrado: " + vascular.GetType().ToString());



            }

        }

    }
}
