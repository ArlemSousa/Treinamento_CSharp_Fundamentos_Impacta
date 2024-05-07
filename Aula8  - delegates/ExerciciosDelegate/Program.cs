using ExerciciosDelegate;

//instanciar o circulo
Circulo circulo = new Circulo();

//instanciar o retangulo
Retangulo ret = new Retangulo();

//Circulo = classe - CalcularArea = delegate - circulo.Calcular = função de calcular da classe Circulo 
Circulo.CalcularArea calculoAreaCirculo = new Circulo.CalcularArea(circulo.Calcular);
Retangulo.CalcularArea calculoAreaRetangulo = new Retangulo.CalcularArea(ret.Calcular);

Console.WriteLine("Informe a area do circulo");
double area = double.Parse(Console.ReadLine());
calculoAreaCirculo(area);


Console.WriteLine(new string('-', 100));
Console.WriteLine();

double largura;
double altura;

Console.WriteLine("Informe a altuira do ret");
altura = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a base do ret");
largura = double.Parse(Console.ReadLine());

calculoAreaRetangulo(altura, largura);

/********************************************************************************************************/



