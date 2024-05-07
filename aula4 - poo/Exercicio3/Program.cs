// Criando dois objetos da classe
using Exercicio3;


for (int i = 0; i < 25; i++)
{
    // Incrementando o valor da propriedade estática algumas vezes
    Incremento.IncrementarNumero();

    // Exibindo o resultado da propriedade incrementada
    Console.WriteLine($"Valor da propriedade estática: {Incremento.ObterNumero()}");
}

