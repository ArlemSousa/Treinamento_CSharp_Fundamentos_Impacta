// para gerar um objeto da classe Automovel é necessário fazer referencia à ela
using Fundamentos.CSharp.Cap03.POO;

/* 1ª abordagem

// definir a instancia/inicialização da classe Automovel{} e gerar, a partir dela, um objeto - para esta modalidade vamos fazer uso do tipo construido Automovel - para definir o data type da nossa var
Automovel carro = new Automovel();

// acima, foi praticada a instancia/inicialização da classe Automovel => inicialização significa que todos os elementos que compõem a classe estão disponiveis para uso. É como se tivessemos dizendo que: "agora vamos usar e executar as operações descritas dentro da classe Automovel

// - Automovel -> é a classe que define o data type da var

// - carro     -> é a var que recebe como valor a instancia da classe Automovel(); portanto, seu objeto

// new         -> palavra reservada para gerar uma instancia da classe Automovel

//Automovel()  -> chamar uma classe à sua execução - do ponto de vista lógico - não faz sentido. Pois uma classe é tão-somente um elemento descritivo. Na verdade, quem está sendo chamado a sua execução é o método especial construtor da classe.

// fazer uso do objeto para manipular seus atributos/fields/propriedades/variaveis
carro.Fabricante = "Honda";
carro.Modelo = "Civic";
carro.Placa = "EVX1567";
carro.Cor = "Vermelho";
carro.Ano = 2023;

// exibir o resultado da manipulação dos atributos da classe Automovel{} - a partir do uso do objeto carro
Console.WriteLine("Fabricante: " + carro.Fabricante);
Console.WriteLine("Modelo: " + carro.Modelo);
Console.WriteLine("Placa: " + carro.Placa);
Console.WriteLine("Cor: " + carro.Cor);
Console.WriteLine("Ano: " + carro.Ano); */


/*2ª abordagem
Automovel carro = new Automovel();

// acessar as props a partir do uso do objeto
carro.Fabricante = "Toyota";
carro.Modelo = "Etios";

//exibição da manipulação dos atributos
Console.WriteLine("Fabricante: " + carro.Fabricante);
Console.WriteLine("Modelo: " + carro.Modelo);*/

/* 1ª abordagem - a partir da classe Colaborador{}

// gerar um objeto - a partir da classe Colaborador{}
Colaborador colab = new Colaborador();

// fazer acesso as "capsulas" publicas definidas na classe Colaborador{} para que seja possivel oferever algum valor para os atributos private

colab.Nome = "jimmy Page";
colab.Cargo = "Toca demais";
colab.Salario = 39.555;

// exibir os valores 
Console.WriteLine("Nome do colaborador(a): " + colab.Nome);
Console.WriteLine("Cargo: " + colab.Cargo);
Console.WriteLine("salario: " + colab.Salario);
Console.WriteLine("IRPF: " + colab.Irpf);*/


/*2ª abordagem: a partir da classe Colaborador

// uso da declaração this

// praticar a instancia da classe Colaborador{}
Colaborador colab = new Colaborador();

// fazer uso do objeto para acessar o método Atribuir()
colab.Atribuir("BillGates", "estagiario", 680.35);

// ao chamar o método Atribuir() à sua execução foi necessário oferecer aos seus 3 parametros, os respectivos argumentos*/

/* uso da enum

// praticar a instancia da clase TesteEnum{}
TesteEnum enumeradora = new TesteEnum();

// fazer uso do0 objeto para acessar o método
enumeradora.Percorrer();*/

/* 3ª abordagem - classe Automovel{}
// uso de elementos static - para lidar com elementos lógicos static - pertencentes as classes - NÃO É NECESSARIO PRATICARMOS AS INSTANCIAS DESTAS CLASSES. BASTA REFERENCIAR A CLASSE E ACESSAR O ELEMENTO STATIC DESEJADO

Automovel.Fabricante = "Gurgel";
Automovel.Modelo = "Itaipu E-400";

// exibir os valores
Console.WriteLine("Fabricante: "+ Automovel.Fabricante + "\nModelo: " + Automovel.Modelo);*/

/*uso da classe OutroElemStatic*/

/*
Console.WriteLine(OutroElemStatic.Multiplicar(12, 5));
*/

/*criacao de objetos anonimos/implicitos
//definir uma var para receber como valor uma instancia 

var objAnonimo = new //instancia de um elemento logico que se torna um objeto - um connjunto de valores.
{
    Descricao = "Este é um valor de uma prop de um objeto anonimo.",
    DataCriacao = DateTime.Now
    
};
//exibir os valores
Console.WriteLine("Descricao do obj: " + objAnonimo.Descricao + "Data: " + objAnonimo.DataCriacao);

*/

/*uso da struct

//2 passo  - inicializar
Endereco endResidencial = new Endereco();

//3 passo - fazer uso do objeto
endResidencial.Rua = "Rua da casinha, 01";
endResidencial.Bairro = "Bairro flores";
endResidencial.Cidade = "Limeira";
endResidencial.UF = "SP";

//4 passo - exibir os valores
Console.WriteLine(endResidencial.ExibirEndereco());



// 1º passo: definir a struct
struct Endereco
{
    //definir algumas props com encapsulamento implicito
    public string? Rua { get; set; }
    public string? Bairro { get; set; }
    public string? Cidade { get; set; }
    public string? UF { get; set; }
    public string? CEP { get; set; }

    //definir um método para exibição dos valores da struct
    public string ExibirEndereco()
    {
        return $"Rua: {Rua} \nBairro: {Bairro}\nCidade: {Cidade}\nUF: {UF}";

    }
}

*/

/*sobrecarga de metodo / overloading*/

Pessoa entregador = new Pessoa();
entregador.Nome = "Patrick";
entregador.Idade = 18;

Console.WriteLine(entregador.ExibirDados());
Console.WriteLine(new string('-', 54));

Console.WriteLine(entregador.ExibirDados("Inscrito no curso de c#"));
Console.WriteLine(new string('-', 54));

Console.WriteLine(entregador.ExibirDados("Inscrito no c#", "fez 10 aulas"));
Console.WriteLine(new string('-', 54));







