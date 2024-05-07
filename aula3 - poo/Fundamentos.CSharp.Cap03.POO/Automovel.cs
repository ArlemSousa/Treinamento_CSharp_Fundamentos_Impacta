// diretivas - "oferecem" recursos para serem utilizados durante a implementação do programa - se, assim, for necessario
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// este é o "local" onde se encontram todos os arquivos do projeto
namespace Fundamentos.CSharp.Cap03.POO
{
    // definição da classe - o nome da classe
    internal class Automovel
    {
        /*1ª abordagem

        // definir/descrever um conjunto de "elementos" lógicos que irão compor a estrutura descritiva da classe

        // os "elementos" -> atributos/variaveis/fields/propriedades descritos abaixo são definidos com o modificador de acesso public. Significa que, teoricamente, podem ser "vistos" e acessados por qualquer outro "pedaço" do programa - desde que faça a devida referencia a esta classe
        public string? Fabricante;
        public string? Modelo;
        public string? Placa;
        public string? Cor;
        public short Ano;*/

        /* 2ª abordagem 

        // definir algumas props
        // a prop/atributo abaixo poderá ser acessada - está visivel - por todos os "pedaços" do programa
        public string? Fabricante;

        // a prop/atributo abaixo NÃO PODERÁ SER ACESSADA POR NENHUM OUTRO "PEDAÇO" DO PROGRAMA - a não ser por esta mesma classe, ou seja, pode ser acessada somente aqui.
        private string? _modelo;

        // _modelo é uma convenção que o C# utiliza para descrever uma prop private

        // fazer uso dos métodos acessores para manipular a propriedade private/privada

        // criar o lemento publico para  a manipulação da prop private -  a partir dos métodos acessores
        public string? Modelo // é a "pelicula" que esta posta acima da tela de vidro do seu celular 
        {
            get { return _modelo; } // o métdo acessor get - quando chamado a sua execução - tem como retorno o acesso a prop private _modelo
            set { _modelo = value;} // o método acessor set - quando chamado a sua execução - tem como funcionalidade a manipulação da prop private - oferecendo à ela algum valor
        }*/

        /* 3ª abordagem*/

        // FAZER USO DA CLASSE PARA IMPELEMENTAR ELEMENTOS STATIC
        // definir uma prop private static
        private static string? _fabricante;

        // definir o encapsulamento explicito
        public static string? Fabricante
        {
            get { return _fabricante; }
            set { _fabricante = value; }
        }

        private static string? _modelo;
        public static string? Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }
    }
}
