
/*
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//uso  do metodo/funcao ReadKey
Console.ReadKey(); //faz a 'leitura' de alguma tecla que foi acessada pelo user, e assim a execução será interrompida.

*/

/*
/* segunda abordagem: driacao de variaveis */

using System.Runtime.ConstrainedExecution;

int umNumero = 3;

Console.WriteLine("Valor original da var umNUmero é: " + umNumero.ToString());

Console.WriteLine(new string('-', 50));
//define um objeto do tipo string


//reutilizando a variavel criada para acessa-la
umNumero = 5;
Console.WriteLine("O novo valor é :", umNumero);

Console.WriteLine(new string('-', 50));


/**************************************************************************************************************/

//TERCEIRA ABORDAGEM: VARIAVEIS DE INCREMENTO E DECREMENTO

//definir uma var com outro datatype numerico
byte novoNumero; //essa variavel  é inicialmente null

novoNumero = 8;

Console.WriteLine("Definicao do operador pre-incremental");
Console.WriteLine("valor inicial: " +novoNumero);
Console.WriteLine(2 + ++novoNumero);


//fazer uso do operador incremental de uma em uma unidade
Console.WriteLine("Definicao do operador pós-incremental");
Console.WriteLine("valor atual: " + novoNumero);
Console.WriteLine(2 + novoNumero++);



/**************************************************************************************************************/

//quarta 

//fazer uso de operadores relacionais com os logicos 

byte a = 30, b = 40, c = 50, d = 60;

Console.WriteLine(a < b || c == 50);