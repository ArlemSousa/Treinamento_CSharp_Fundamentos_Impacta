using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class TestandoTasks
    {
        public TestandoTasks()
        {
        }

        //primeiro teste
        //public static void Imprimir()
        //{
        //    for (int i = 0; i< 6; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        //segundo teste;
        public static void MostrarPontinhos()
        {
            for(int i = 0; i < 10; i++)
            {
                //definir um timer: manipulador de tempo da execução da tarefa
                Thread.Sleep(3000);
                Console.WriteLine(".\n");

            } 
        }
    }
}
