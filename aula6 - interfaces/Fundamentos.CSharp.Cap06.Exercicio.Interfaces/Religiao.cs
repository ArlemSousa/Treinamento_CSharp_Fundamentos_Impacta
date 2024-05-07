using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.CSharp.Cap06.Exercicio.Interfaces
{
    internal class Religiao : ILivro
    {
        //construtor padrão
        public Religiao() { }

        //definindo as props particulares dos livros 
        public bool CapaDura => true;
        public bool TemDesconto => false;
       

        //props da interface
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public string? Genero { get; set; }
        public string? Descricao { get; set; }
        public int QuantidadePaginas { get; set; }
        public double Preco { get; set; }

        public string ExibirLivrosDiversos()
        {
            return $"Titulo: {Titulo} \nAutor: {Autor} \nGenero: {Genero} \nDescrição: {Descricao} " +
                   $"\nPaginas: {QuantidadePaginas} \nCapa Dura: {this.CapaDura} \nDesconto: {this.TemDesconto}" +
                   $"\nPreco: {Preco}";
        }
    }
}

