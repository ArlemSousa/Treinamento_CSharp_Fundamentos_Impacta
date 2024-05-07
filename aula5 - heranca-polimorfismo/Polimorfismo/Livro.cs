using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Livro : Produto
    {
        //definir uma prop especificac para classe livro
        public short Npaginas { get; set; }

        //acessar metodo exibir infos - da classe pai e tentar sibrescrever para praticar o polimorfismo
        public override string ExibirInfos()
        {
            return base.ExibirInfos() + "\nNumero de Paginas " + Npaginas;
            //essa expressao de retorno foi composta pela referencia a superclasse e a sobrescrita do metodo que a compoe.
            //alem disso foi possivel acrecentar algo em particular para que a sobrescrita funcione de acordo  com a necessidade da classe que herda o metodo  - definido na classe pai.

        }



    }
}
