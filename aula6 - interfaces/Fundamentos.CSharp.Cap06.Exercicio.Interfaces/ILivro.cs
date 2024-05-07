using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.CSharp.Cap06.Exercicio.Interfaces
{
    internal interface ILivro
    {

        //declaração de propriedades que podem ser em comum com qualquer tipo de livro
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public string? Genero { get; set; }
        public string? Descricao { get; set; }
        public int QuantidadePaginas { get; set; }
        public double Preco { get; set; }

        public string ExibirLivrosDiversos();

        //public string ExibirLivrosDiversos() => $"Titulo: {Titulo} \nAutor: {Autor} \nGenero: {Genero} \nDescrição: {Descricao} \nPaginas: {QuantidadePaginas}";
        //definir um método que atuará como instrumento lógico default (padrão) - isso significa que todas as classes com as quais for praticada os mecanismos de herança
        //com a interfacel, este metodo será disponibilizado.
    }
}
