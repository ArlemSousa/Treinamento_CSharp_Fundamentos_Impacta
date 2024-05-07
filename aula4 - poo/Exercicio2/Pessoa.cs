using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4Exercicio
{
    internal class Pessoa
    {

        public string? Nome { get; set; }


        public string ExibirDados()
        {
            return string.Format("Pimeiro Nome: {0}", Nome);
        }

        public string ExibirDados(string segundoNome)
        {
            return string.Format("Pimeiro Nome: {0}\nSegundo Nome: {1} ", Nome, segundoNome);
        }

        public string ExibirDados(string segundoNome, string ultimoNome)
        {
            return string.Format("Pimeiro Nome: {0}\nSegundo Nome: {1}\nUltimo Nome: {2} ", Nome, segundoNome, ultimoNome);
        }

    }
}
