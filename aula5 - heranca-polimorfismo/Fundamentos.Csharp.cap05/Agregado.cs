using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Csharp.cap05.heranca.construtores
{
    internal class Agregado : Entregador
    {
        //ao definir a prop motofab  - observando a descricao - 
        //estamos explicitamente ocultando o valor da motofab da classe pai.
        //como? fazendo uso de um objeto string
        public new string MotoFab = "Yamaha";

        //definir um metodo
        public string ExibirDadosMoto()
        {
            return "\nNome do Fabricante descrita na classe pai: " + base.MotoFab + "\nNome da fabricante da classe filha: " + MotoFab;
            //classe pai é entregador e classe filha é a agregado
        }


    }
}
