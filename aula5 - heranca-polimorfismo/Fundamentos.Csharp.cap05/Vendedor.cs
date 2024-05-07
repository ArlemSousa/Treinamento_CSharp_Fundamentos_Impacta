using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Csharp.cap05.heranca.construtores
{
    //agora será praticado o mecanismo de herança entre as classes: vendedor e o funcionario
    internal class Vendedor : Funcionario
    { //neste momento ao usar o caractere :  - a classe vendedor é a classe filha ou sub classe ou  classe derivada. e a classe funcionario é a classe pai ou super classe ou classe base


        public double PercentialComissao { get; set; }
        public string? DocId { get; set; }

    }
}
