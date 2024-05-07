/*praticas de polimorfismo
//indicacao da diretiva

using Polimorfismo;

Produto produto = new Produto();
produto.nome = "detergente";
produto.Preco = 1.9;

Console.WriteLine("infos sobre o produto: " + produto.ExibirInfos());

Livro hq = new Livro();

hq.nome = "batma - o cavalero das treva";
hq.Preco = 50.9;
hq.Npaginas = 200;

Console.WriteLine("Informações do livro: " + hq.ExibirInfos());

*/

using Polimorfismo;

/*pratica de membros abstratos
//primeira abordage: chamada do metodo contrutor-padrao da classe

Retangulo retangulo = new Retangulo();

retangulo.Base = 5.0;
retangulo.Altura = 6.0;

Console.WriteLine(retangulo.ExibirInfosdasAbstracts());


//segunda abordagem
//fazer a chamada do construtor custom da classe
//geraar um novo objeto a partir da classe retangulo

Retangulo retangulo1 = new Retangulo(3.0, 4.0);

Console.WriteLine(retangulo1.ExibirInfosdasAbstracts());



//primeira aborgagem classe circulo-
Circulo circulo = new Circulo();
circulo.raio = 3.0;
Console.WriteLine(  circulo.ExibirInfosdasAbstracts());


Circulo circulo1 = new Circulo(2.1);
Console.WriteLine(circulo.ExibirInfosdasAbstracts());
*/

/*praticas de classe estaticas*/

Estatica.Numero1 = 658;
Estatica.Leitura();
