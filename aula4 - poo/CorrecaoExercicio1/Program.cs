using CorrecaoExercicio1;

Cubo cuboCalculado = new Cubo();

cuboCalculado.Lado = 6;

Console.WriteLine(cuboCalculado.ExibirVolumeCubo());


//referenciar a classe vendar e acessar a prop static para que seja possivel atribui-la de algum valor.

Venda.Quantidade = 0;

//instanciar a classe venda para acessar seus metodos que naoo sao estaticos
Venda exercico3 = new Venda();

exercico3.Incrementar();
exercico3.Incrementar();
exercico3.Incrementar();
exercico3.Incrementar();

Console.WriteLine(exercico3.RetornarQuantidade());