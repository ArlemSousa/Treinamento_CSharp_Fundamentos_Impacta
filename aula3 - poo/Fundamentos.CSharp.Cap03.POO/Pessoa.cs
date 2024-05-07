using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.CSharp.Cap03.POO
{
    internal class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public string ExibirDados()
        {
            return string.Format("Nome: {0}\nIdade: {1} anos", Nome, Idade.ToString());
        }

        //a partir deste ponto será praticada a sobrecarga de metodo overloading.
        //para que a sobrecarga funcione é necessário alterar a assinatura do metodo (estrutura de construcao).

        public string ExibirDados(string observacao)
        {
            return string.Format("Nome: {0}\nIdade: {1} anos \nDescricao: {2}", Nome, Idade.ToString(), observacao);
        }

        public string ExibirDados(string observacao, string freq)
        {
            return string.Format("Nome: {0}\nIdade: {1} anos \nDescricao: {2}\nFrequencia: {3}", Nome, Idade.ToString(), observacao, freq);
        }
    }

    }

