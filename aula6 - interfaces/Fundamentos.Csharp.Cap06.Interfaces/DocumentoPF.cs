using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Csharp.Cap06.Interfaces
{
    internal class DocumentoPF : IDocumento
    {

        public DocumentoPF() { } //construtor padrao

        public string? NomeCliente { get; set; }

        //definir uma prop private
        private string? _numero;

        //encapsular 
        public string? Numero
        {
            get => _numero;
            set => _numero = value.Length == 11 ? value : throw new Exception("Numero de CPF invalido!");
        }

        //sobrescrita do metodo herdado da heranca
        public string MostrarDocumento()
        {
            //se o metodo é diferente de void, definir uma expressao de return;
            return "O cliente " + this.NomeCliente + "possui o CPF de numero " + this.Numero;
        }
    }
}
