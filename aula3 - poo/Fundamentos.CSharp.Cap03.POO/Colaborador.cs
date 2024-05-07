using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.CSharp.Cap03.POO
{
    internal class Colaborador
    {
        /* 1ª abordagem

        //definir algumas props private
        private string? _nome;

        // definir o elemento public - "capsula/pelicula" - para a manipulação da prop private _nome
        public string? Nome
        {
            // ao fazer uso dos metodos acessores get e set estamos praticando o encapsulamento explicito/direto
            get { return _nome; }
            set { _nome = value;}
        }

        private string? _cargo;
        public string? Cargo
        {
            get { return _cargo; }
            set { _cargo = value;}
        }

        private double _salario;
        public double Salario
        {
            get { return _salario; }
            set { _salario = value; }
        }

        // definir uma nova prop, public, para que possa retornar o calculo do imposto mo valor do salario - será um valor de IRPF ficticio
        public double Irpf
        {
            get { return Salario * 0.1; }
        }*/


        /* 2ª abordagem 

        //definir algumas props private
        private string? _nome;

        // definir o elemento public - "capsula/pelicula" - para a manipulação da prop private _nome
        public string? Nome
        {
            // ao fazer uso dos metodos acessores get e set estamos praticando o encapsulamento a partir da tecnica conhecida como expressão de acesso
            get => _nome;
            set => _nome = value; 
        }

        private string? _cargo;
        public string? Cargo
        {
            get => _cargo; 
            set => _cargo = value; 
        }

        private double _salario;
        public double Salario
        {
            get => _salario; 
            set => _salario = value; 
        }

        // definir uma nova prop, public, para que possa retornar o calculo do imposto mo valor do salario - será um valor de IRPF ficticio
        public double Irpf
        {
            get => Salario * 0.1; 
        }*/


        /* 3ª abordagem 

        // encapsulamento implicito
        public string? Nome {  get; set; } // há um elemento private _nome
        public string? Cargo {  get; set; }
        public double Salario {  get; set; }

        public double Irpf => Salario * 0.3;*/


        /* 4ª abordagem: uso da declaração this*/

        // encapsulamento implicito
        public string? Nome { get; set; } // há um elemento private _nome
        public string? Cargo { get; set; }
        public double Salario { get; set; }

       

        // definir um método/função para atribuir valores as props
        public void Atribuir(
            // definir para o método 3 parametros
                string Nome, string Cargo, double Salario
            )
        {
            // o que é um parametro => um parametro de método é uma variavel, necessariamente, local -> particular do método

            // aqui, estão sendo acessadas as props descrita na classe - fora do método
            // neste contexto é fundamental o uso da declaração this - por que? R: Porque as props estão definidas e pertencem a classe. Já os parametros pertencem UNICA E EXCLUSIVAMENTE AO MÉTODO. 

            this.Nome = Nome;
            this.Cargo = Cargo;
            this.Salario = Salario;

            // exibir os valores das props
            Console.WriteLine("Nome: " + Nome + "\nCargo: " + Cargo + "\nSalario: " + Salario);
        }

       
    }
}
