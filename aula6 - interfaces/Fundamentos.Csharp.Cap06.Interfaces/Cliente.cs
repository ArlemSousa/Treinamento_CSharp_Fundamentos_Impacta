using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Csharp.Cap06.Interfaces
{
    internal class Cliente
    {

        public IDocumento? Documento { get; set; }

        //essa prop pertence exclusicamenta a classe cliente
        public string? Numero {

            get => Documento.Numero;
            set => Documento.Numero = value;
        }

        //definir um metodo especifico da classe cliente 
        public string Mostrar()
        {
            return Documento.MostrarDocumento();
        }

    }
}
