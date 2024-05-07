using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.CSharp.Cap06.Exercicio.Interfaces
{
    internal class Livros
    {
        //referenciar a interface
        public ILivro? LivrosDiversos { get; set; }

        //acessar as props da interface
        public string? Titulo { get => LivrosDiversos.Titulo; set => LivrosDiversos.Titulo = value; }
        public string? Autor { get => LivrosDiversos.Autor; set => LivrosDiversos.Autor = value; }
        public string? Genero { get => LivrosDiversos.Genero; set => LivrosDiversos.Genero = value; }
        public string? Descricao { get => LivrosDiversos.Descricao; set => LivrosDiversos.Descricao = value; }
        public int QuantidadePaginas { get => LivrosDiversos.QuantidadePaginas; set => LivrosDiversos.QuantidadePaginas = value; }

        public string MostrarLivrosDiversos()
        {
            return LivrosDiversos.ExibirLivrosDiversos();
        }

    }
}
