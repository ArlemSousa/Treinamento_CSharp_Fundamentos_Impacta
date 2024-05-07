using Fundamentos.CSharp.Cap06.Exercicio.Interfaces;


Livros religiao = new Livros()
{
    LivrosDiversos = new Religiao()
    {
        Titulo = "Café com Deus Pai",
        Autor = "Igreja evvangelica",
        Descricao = "Livro para devocionais",
        Genero = "Religião",
        QuantidadePaginas = 120,
        Preco = 100.50
    }

};

Livros poesia = new Livros()
{
    LivrosDiversos = new Poesia()
    {
        Titulo = "Vinicius de Moraes o poeta",
        Autor = "Vinicius de Moraes",
        Descricao = "Abrilhantar seu dia",
        Genero = "Poesia",
        QuantidadePaginas = 100,
        Preco = 20.99
    }

};

Livros biografia = new Livros()
{
    LivrosDiversos = new Biografia()
    {
        Titulo = "Nelson mandela a biografia",
        Autor = "Morgan Freeman",
        Descricao = "a vida do nelson mandela",
        Genero = "Biografia",
        QuantidadePaginas = 1800,
        Preco = 200.99
    }

};

Livros conto = new Livros()
{
    LivrosDiversos = new Conto()
    {
        Titulo = "Branca de neve e os 7 anões",
        Autor = "Pinoquio",
        Descricao = "conto de fadas pra criancinhas",
        Genero = "Conto de fadas",
        QuantidadePaginas = 200,
        Preco = 29.99
    }

};

Livros ficcao = new Livros()
{
    LivrosDiversos = new Ficcao()
    {
        Titulo = "Harry potter",
        Autor = "vc sabe quem",
        Descricao = "vingardium lave louça",
        Genero = "ficcao",
        QuantidadePaginas = 1800,
        Preco = 180.99
    }

};


//exibição dos valores
Console.WriteLine(religiao.MostrarLivrosDiversos());
Console.WriteLine(new string('-', 50));
Console.WriteLine(poesia.MostrarLivrosDiversos());
Console.WriteLine(new string('-', 50));
Console.WriteLine(biografia.MostrarLivrosDiversos());
Console.WriteLine(new string('-', 50));
Console.WriteLine(conto.MostrarLivrosDiversos());
Console.WriteLine(new string('-', 50));
Console.WriteLine(ficcao.MostrarLivrosDiversos());