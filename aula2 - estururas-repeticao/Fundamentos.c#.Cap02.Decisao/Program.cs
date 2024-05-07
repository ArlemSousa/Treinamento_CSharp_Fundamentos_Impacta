// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Diagnostics;

int umValor, outroValor;

Console.WriteLine("Primeira abordagem");
umValor = 15;
outroValor = 55;

if (umValor < outroValor)
{
    Console.WriteLine(umValor + " é menor que " + outroValor);
}

Console.WriteLine(new string('-', 50));
// ------------------------------------------------------------------------------ //

Console.WriteLine("Segunda abordagem");

umValor = 20;
outroValor = 13;

if (umValor < outroValor)
{
    Console.WriteLine(umValor + " é menor que " + outroValor);
} 
else
{
    Console.WriteLine(umValor + " é maior que " + outroValor);
}

Console.WriteLine(new string('-', 50));
// ------------------------------------------------------------------------------ //


Console.WriteLine("Terceira abordagem");

umValor = 32;
outroValor = 13;

if (umValor < outroValor)
{
    Console.WriteLine(umValor + " é menor que " + outroValor);
}
else
{
    Console.WriteLine(umValor + " é maior que " + outroValor);
}

Console.WriteLine(new string('-', 50));
// ------------------------------------------------------------------------------ //


Console.WriteLine("Quarta abordagem");

umValor = 88;
outroValor = 88;

if (umValor < outroValor)
{
    Console.WriteLine(umValor + " é menor que " + outroValor);
}
else if (umValor > outroValor )
{
    Console.WriteLine(umValor + " é maior que " + outroValor);
}
else
{
    Console.WriteLine(umValor + " é igual " + outroValor);
}

/*
Console.WriteLine(new string('-', 50));
// ------------------------------------------------------------------------------ //

Console.WriteLine("Quinta abordagem - switch/case");

Console.WriteLine("Informe um numero entre o intervalo entre 1 a 7");
string diaSemana = Console.ReadLine();

string resultado = "";

if (diaSemana.Trim() == "" )
{
    return;
}

switch (diaSemana)
{
    case "1" :
        resultado = "Domingo";
        break;
    case "2":
        resultado = "Segunda";
        break;
    case "3":
        resultado = "Terça";
        break;
    case "4":
        resultado = "Quarta";
        break;
    case "5":
        resultado = "Quinta";
        break;
    case "6":
        resultado = "Sexta";
        break;
    case "7":
        resultado = "Sabado";
        break;
    default:
        resultado = "Informe um valor valido";
        break;
}

Console.WriteLine("O valor indicado corresponde a " + resultado);

*/

Console.WriteLine(new string('-', 50));
// ------------------------------------------------------------------------------ //

/*
Console.WriteLine("Quinta abordagem - switch/case");

Console.WriteLine("Informe um numero entre o intervalo entre 1 a 7");
string diaSemana = Console.ReadLine();

string resultado = "";

if (diaSemana.Trim() == "")
{
    return;
}

switch (diaSemana)
{
    case "1":
        resultado = "Domingo - DIA DE DESCANSO";
        break;
    case "2":
    case "3":
    case "4":
    case "5":
    case "6":
        resultado = "Dias uteis";
        break;
    case "7":
        resultado = "Sabado";
        break;
    default:
        resultado = "Informe um valor valido";
        break;
}

Console.WriteLine("O valor indicado corresponde a " + resultado);
*/

Console.WriteLine(new string('-', 50));
// ------------------------------------------------------------------------------ //


Periodo tempinho = Periodo.V;

string descricao;

_ = (tempinho switch
{
    Periodo.M => descricao = "Manha",
    Periodo.T => descricao = "Tarde",
    Periodo.V => descricao = "Verspertino",
    _ => descricao = "Desconhecido"

});

Console.WriteLine("Perido selecionado é: " + descricao);


enum Periodo
{
    M, T, V, N
}


