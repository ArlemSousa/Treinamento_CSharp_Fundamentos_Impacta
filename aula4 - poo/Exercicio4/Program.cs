
//2 passo  - inicializar
Livro bibliotecaCentral = new Livro();

Livro livro2 = new Livro();


for (int i = 0; i < 2; i++)
{
    Console.WriteLine("Digite o nome do livro 1: ");
    bibliotecaCentral.Título = Console.ReadLine();

    Console.WriteLine("Digite o autor do livro 1: ");
    bibliotecaCentral.Autor = Console.ReadLine();

    Console.WriteLine("Digite o genero do livro 1: ");
    bibliotecaCentral.Genero = Console.ReadLine();

    Console.WriteLine("Digite o registro do livro 1: ");
    bibliotecaCentral.Registro = Console.ReadLine();

    //4 passo - exibir os valores
    Console.WriteLine(bibliotecaCentral.ExibirLivros());
    Console.WriteLine(new string('-', 50));
}


struct Livro
{
    public string? Título;
    public string? Autor;
    public string? Genero;
    public string? Registro;


    public string ExibirLivros()
    {
        return $"Título: {Título} \nAutor: {Autor}\nGenero: {Genero}\nRegistro: {Registro}";
    }
}