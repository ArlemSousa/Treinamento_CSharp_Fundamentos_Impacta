using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.CSharp.Cap03.POO
{
    internal class TesteEnum
    {
        enum EstadosCivis: byte
        {
            Casado,
            Solteiro,
            Viuvo,
            Divorciado,
            Outros
        }

        // definir um método/função para que seja possivel percorrer/iterar sobre a enum declarada
        public void Percorrer()
        {
            // implementar, dentro do método, um loop para iterar sobre os valores da enum
            foreach (byte i in Enum.GetValues(typeof(EstadosCivis)))
            {
                // exibir os valores encontrados pela var i
                Console.WriteLine(Enum.GetName(typeof(EstadosCivis), i));
            }
        }
    }
}
