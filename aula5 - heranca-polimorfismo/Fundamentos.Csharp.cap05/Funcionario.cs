using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Csharp.cap05.heranca.construtores
{
    internal class Funcionario
    {
        private string? _nome;

        //definir encapsulamento
        public string? Nome
        {
            //uso dos metodos acessores
            get { return _nome; }
            set { _nome = value; }
        }

        private string? _cargo;
        public string? Cargo
        {
            //uso dos metodos acessores
            get { return _cargo; }
            set { _cargo = value; }
        }
    }
}
