using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Csharp.Cap06.Interfaces
{
    internal class DevSenior : IColaborador
    {

        public DevSenior() { }

        public string? Nome { get; set; }
        //public string? Nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
