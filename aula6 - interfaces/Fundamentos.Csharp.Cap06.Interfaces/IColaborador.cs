using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Csharp.Cap06.Interfaces
{
    internal interface IColaborador
    {
        //vamos declarar dois elementos lógicos
        public string? Nome { get; set; }
        bool pagtoHora => false;

        //definir um método que atuará como instrumento lógico default (padrão) - isso significa que todas as classes com as quais for praticada os mecanismos de herança
        //com a interfacel, este metodo será disponibilizado.

        public string MostrarInfos() => $"Nome do dev: {Nome}; recebe por hora:" + (pagtoHora ? "Sim" : "não");
    }
}
