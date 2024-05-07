using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Csharp.Cap06.Interfaces
{
    internal class Developer 
    {
        //referenciar a interface
        public IColaborador? AlgunsDados { get; set; }


        //definir e acessar a pro nome
        public string? Nome
        {
            get => AlgunsDados.Nome;
            set => AlgunsDados.Nome = value;

        }


        public string Mostrar()
        {
            return AlgunsDados.MostrarInfos();
        }
    }
}
