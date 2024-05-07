using System.Numerics;

int num = 0;

while (num < 50)
{
    Console.WriteLine(num);
    num++;
}


var num2 = 10;

do //faça algo -> independente da expressao de teste do loop
{
    Console.WriteLine("valor da variavel num2 é: " + num2);
    num2 += 1000;
} while ( num2 <= 1000);


for (int a = 1, b= 1; a < 300 || b < 300; a *= 3, b *= 2)
{
    Console.WriteLine("a" + a.ToString());
    Console.WriteLine("b" + b.ToString());
}



//segunda abordagem

//for (int a = 1; a <= 1000; a++)
//{
//    if (a > 20)
//    {
//        break;
//    }
//    Console.WriteLine("Valor de 'A': " + a);

//}


//terceira abordagem com for
//comando continue

for (int i = 1; i <= 20; i++)
{
    if (i > 3 && i < 5)
    {
        continue;
    }
    Console.WriteLine("Valor de 'I': " + i);

}

//quarta abordagem
//loop de alfabeto

for (char l = 'a'; l <= 'z'; l++)
{
    Console.WriteLine(l + " ");
   
}

Console.WriteLine(new string('-', 50));

for (char l = 'z'; l >= 'a'; l--)
{
    Console.WriteLine(l + " ");

}

Console.WriteLine(new string('-', 50));

//quinta abordagem
//foreach

//criar um conjunto de valores do mesmo tipo 
string[] listaPaises = { "Alemanha", "Argentina", "Brasil", "França", "Gana", "Japão", "Nigeria", "Costa do Marfim", "Koreia do Sul", "Uruguai", "Espanha"};

//definir o foreach para percorrer o conjunto de dados que é o nosso array listaPaises
foreach (string pais in listaPaises)
{
    
    //Console.WriteLine(pais);
    
    if (pais.StartsWith("A"))
    {
        Console.WriteLine(pais.ToUpper());
    }

    if (pais.Contains("n"))
    {
        Console.WriteLine(pais.ToUpper());
    }

}
