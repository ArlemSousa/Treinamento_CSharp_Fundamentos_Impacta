using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Csharp.Cap06.Interfaces
{
    internal interface IDocumento
    {

        //definir os instrumentos logicos para compor a interface
        public string? Numero { get; set; }

        //declarar metodo
        public string MostrarDocumento();
    }
}
