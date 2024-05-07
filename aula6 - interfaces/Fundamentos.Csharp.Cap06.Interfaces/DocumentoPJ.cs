using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Csharp.Cap06.Interfaces
{
    internal class DocumentoPJ : IDocumento
    {

        //definir o construtor padrão
        public DocumentoPJ() { }

        public string? NomeCliente { get; set; }

        //definir uma prop private
        private string? _Numero;


        public string? Numero { get => _Numero; 
                                set => _Numero = value.Length == 14 ? value : throw new Exception("Numero de CPF invalido!");

        }
              
        public string MostrarDocumento()
        {
            return "O cliente " + this.NomeCliente + "possui o CNPJ de numero " + this.Numero;
        }
    }
}
