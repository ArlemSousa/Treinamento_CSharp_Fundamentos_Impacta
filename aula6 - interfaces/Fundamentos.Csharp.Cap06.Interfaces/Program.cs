
using Fundamentos.Csharp.Cap06.Interfaces;

/*primeira abordagem
//gerar objetos das classes circulos e retangulos 
Retangulo retangulo = new Retangulo();
Circulo circulo = new Circulo();

circulo.Raio = 2.5;

retangulo.Base = 2.5;
retangulo.Altura = 1.5;


Console.WriteLine("Area do Circulo:" + circulo.CalcularArea());
Console.WriteLine(new string('-',50));
Console.WriteLine("Area do Retangilo:" + retangulo.CalcularArea());
*/

/*
//segunda abordagem : definir como tipo construido a Interface
IFigura circulo = new Circulo()
{
    Raio = 7.5
};

IFigura retangulo = new Retangulo()
{
    Altura = 2.5,
    Base = 1.5

};

Console.WriteLine("Area do Circulo:" + circulo.CalcularArea());
Console.WriteLine(new string('-', 50));
Console.WriteLine("Area do Retangilo:" + retangulo.CalcularArea());
*/

/*
//terceira abordagem
//praticar a instancia da classe cliente 
Cliente docCliente = new Cliente()
{
    //criar como propriedade de instancia de classe Cliente o objeto DocumentoPF
    Documento = new DocumentoPF()
    {
        //ao praticar a instancia da classe documentoPF{} é possivel acessar suas pros especificas
        Numero = "42245812301",
        NomeCliente = "Simão fantasma vacilão PF"

    }
};

Cliente docCliente2 = new Cliente()
{
    Documento = new DocumentoPJ()
    {
        Numero = "12345678900011",
        NomeCliente = "Simão fantasma vacilão PJ"
    }
};

Console.WriteLine(docCliente.Mostrar());
Console.WriteLine(new string('-',50));
Console.WriteLine(docCliente2.Mostrar());
*/

//quarta abordagem
//praticar as instancias das classes developer 


Developer devJ = new Developer()
{
    AlgunsDados = new DevPleno()
    {
        Nome = "Junior"
    }
};


Developer devP = new Developer()
{
    AlgunsDados = new DevPleno()
    {
        Nome = "Pleno"
    }
};


Developer devS = new Developer()
{
    AlgunsDados = new DevPleno()
    {
        Nome = "Senior"
    }
};

Console.WriteLine(devJ.Mostrar());
Console.WriteLine(devP.Mostrar());
Console.WriteLine(devS.Mostrar());