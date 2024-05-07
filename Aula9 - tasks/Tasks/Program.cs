// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Threading.Channels;
using Tasks;


//TestandoTasks testandoTasks = new TestandoTasks();

//TestandoTasks.Imprimir();

/*
//1º teste: este é um novo contexto de execução de tarefas - acessar o metodo static que será dado como  argumento para a instancia da classe  nativa Task().


//uma task é construida em pedaços

//1º pedaco: definir uma prop quie receberá como valor a instancia da classe Task().

Task tarefaTask = new Task(TestandoTasks.Imprimir);

//2 pedaco: consiste em fazer o uso do objeto/task definido a partir da instancia da classe
tarefaTask.Start(); //metodo start é usado para inicializar a execução da tarefa.

//3º pedaco: definir um elemento manipulador da task
Thread.Sleep(6000); //oficio a ser executado

//4º passo: definir a instrucao que mostra que a tarefa foi finalizada
Console.WriteLine("tarefa principal finalizada");

*/

/*segundo teste

//definir uma nova task - usar como argumento - explicitamente o delegate Action Task.
Task exibirPontinhos = new Task(new Action(TestandoTasks.MostrarPontinhos));

//inicializar a task
exibirPontinhos.Start();

//estabelecer um loop = na tarefa principal - para que seja possivel imprimir um outro caractere considerando um outro tambem, intervalo de tempo.
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine("&\n");

    //manipulador de tempo especifico da tarefa principal
    Thread.Sleep(1500);

}
//acima está descrito em estrutura logica, simples direta e clara o principio da programação

*/

/*terceiro teste
//definir uma nova teask - criar uma tarefa assincrona, explicita.

Task criarUmaAsync = Task.Run(() =>
{
    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine(":D");

        //manipulador de tempo especifico da tarefa principal
        Thread.Sleep(5500);

    }
});

//aqui surge o uso de forma explicita do elemento/recurso wait()
criarUmaAsync.Wait(); //o metodo wait() determina que a task aguarde  - sempre a finalização para na sequencia iniciar a proxima acao a ser executada.
                      //isso ocorre ate que o loop seja interrompido.

*/

/*quarto teste
//executar um conjunto de tarefas

Task[] arrayTarefas = new Task[3]
{
    //Definir as tarefas para exec
    Task.Run(() => Console.WriteLine("Esta é uma tarefa")),
    Task.Run(() => Console.WriteLine("Esta outra uma tarefa")),
    Task.Run(() => Console.WriteLine("Esta é mais uma tarefa"))

};

Task.WaitAll(arrayTarefas);

//depois que as tasks forem executadas nos vamos exibir o conteudo abaixo 3 segundos depois
Thread.Sleep(3000);
Console.WriteLine();
Console.WriteLine("Fim da execução");
*/



/*quinto teste
//definir diretamente um metodo  / tarefa assincrona para que no arquivo principal

static async Task<IEnumerable<string>> ListarNomes()
{
    //definir um conjunto de dados
    var nomes = new List<string>()
    {
        "Jeff", "richie", "eric", "Jimi", "SRV", "Page", "chimbinha"
    };

    foreach (var item in nomes)
    {
        if (item.Contains("i"))
        {
            await Console.Out.WriteLineAsync(item);
            await Task.Delay(3000); 
        }
    }

    return nomes;

}

var listando = ListarNomes().Result; //metodo implicito get
Console.WriteLine(listando);
Console.WriteLine(new string('-',50));

//definir uma var para acumular valor
int x = 0;

foreach (var todosNomes in listando)
{
    Console.WriteLine($"nomes na posicao {x++} é: " + todosNomes);
}
*/

//abordagem 6


//passo 2: definir um novo metodo assincrono para fazerr o uso das props definidos agora no metodo infosParticulares()

async static void MetrodoAssincrono()
{
    // de forma assincrona, aqui será feita a chamada do metodo infosParticulares
    DadosPessoais infos = await InfosParticulares();
    await Console.Out.WriteLineAsync($"{infos.Id}");
}


//passo 1
static Task<DadosPessoais> InfosParticulares()
{
    //praticar a instancia da classe
    DadosPessoais dados = new DadosPessoais()
    {
        Id = 1,
        Nome = "Assincrono",
        Altura = 181.8
    };

    //definir dentro da tarefa - manipulador de tempo
    Thread.Sleep(3000);

    //definicao da expressao de retorno
    return Task.FromResult(dados); // a partir da definição do metodo -  de forma especfica pela classe DadosPessoais() - o recurso fromResult compõe
                                   // a expressao de retorno pois buscamos retornar um resultado muito especifico a partir da definição da tarefa.
                                   // 
}

MetrodoAssincrono();