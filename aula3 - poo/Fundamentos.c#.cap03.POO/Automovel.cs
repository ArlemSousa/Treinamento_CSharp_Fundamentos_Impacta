//diretivas - "oferecem recursos" para serem utilizados durante a implementacao do programa 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespaces é o local onde se encontram todos os arquivos do projeto
namespace Fundamentos.c_.cap03.POO
{
    //definicao da classe, ou seja o nome da classe 
    internal class Automovel
    {
        /*primeira abordagem
        //definir elementos logicos que irão compor a estrutura descritiva da classe

        public string? Fabricante;
        public string? Modelo;
        public string? Placa;
        public string? Cor;
        public short Ano;
        //os elementos da classe agora são chamados de atributos ou propriedades.
        //são definidos com modificadores de acesso (public, internal, private) 
        */

        public string? Fabricante;

        private string? _modelo;

        public string? Modelo
        {
            get { return _modelo;  }
            set { _modelo = value; }
        }


    }
}
