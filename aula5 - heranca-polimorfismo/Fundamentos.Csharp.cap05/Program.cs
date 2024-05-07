//estudo do mecanismo de herança
//indicacao da diretiva 

using Fundamentos.Csharp.cap05.heranca.construtores;

/* 1 abordagem */
Vendedor vendedor = new Vendedor();

vendedor.Nome = "Francisco";
vendedor.Cargo = "Programador jr";
vendedor.PercentialComissao = 0.19;

//exibir as props
Console.WriteLine("Dados do vendedor - Nome: " + vendedor.Nome + "\nCargo: " + vendedor.Cargo + "\nComissao: " + vendedor.PercentialComissao);
Console.WriteLine(new string('-', 50));


Entregador entregador = new Entregador();

entregador.Nome = "Jarvis";
entregador.Cargo = "Entregador";
entregador.QuantidadeEntregas = 121;

Console.WriteLine("Dados do entregador - Nome: " + entregador.Nome + "\nCargo: " + entregador.Cargo + "\nQuantidade de entregas: " 
                                                 + entregador.QuantidadeEntregas + "\nFab Moto: " + entregador.MotoFab);
Console.WriteLine(new string('-', 50));

Terceirizado terceirizado = new Terceirizado();

terceirizado.Nome = "Agnaldo Timoteo"; //pai
terceirizado.Cargo = "estagiario"; //pai
terceirizado.DocId = "crachá";  //vendedor 
terceirizado.pagtoBonus = 26.563; //neto

Console.WriteLine("Dados do terceirizado - Nome: " + terceirizado.Nome + "\nCargo: " + vendedor.Cargo + "\nBonus: " + terceirizado.pagtoBonus);
Console.WriteLine(new string('-', 50));

Agregado agregado = new Agregado();

agregado.Nome = "Agregado motoca fantasma";
agregado.QuantidadeEntregas = 15;
agregado.Cargo = "Motoca autonomo";
Console.WriteLine(agregado.Nome + "\n" + agregado.Cargo + "\n" + agregado.ExibirDadosMoto() + "\n" + agregado.QuantidadeEntregas);
Console.WriteLine(new string('-', 50));