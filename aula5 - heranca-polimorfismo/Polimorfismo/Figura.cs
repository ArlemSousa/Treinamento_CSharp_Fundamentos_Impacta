using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    //a classe figura originalmente é gerada com a palavra reservada "internal" (um modificado de acesso a classe).
    //agora passa a ser do tipo abstract e public.
    //uma classe abstract jamais poderá ser instanciada.
    public abstract class Figura
    {
        //elementos definidos como abstract podem somente serem descritos dentro de uma classe abstract

        //metodos descritos com a palavra reservada abstract nao podem ser impementados/definidos com suas operações dentro da classe abstract - podem somente ser declarados.

        //o metodo calcularArea() esta apenas declarado apenas aguardando sua impementacao assim que for praticada com essa classe o mecanismo de heranca.
        //todo elemento abstract de uma classe abstract é implicitamente virtual
        public abstract double CalcularArea();

        //definir um metodo nao-abstract
        public string ExibirInfosdasAbstracts()
        {
            string nomeClasse = this.GetType().Name;
            double area = this.CalcularArea();
            return $"classe: {nomeClasse} \nArea: {area}";
        }

    }
}
