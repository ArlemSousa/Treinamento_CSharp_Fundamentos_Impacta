/*
 ===============================================================
            DELEGATES - praticar a "transferencia de responsabilidade" de execução de tarefas
 ===============================================================
 */

/* 1º abordagem

// 1º passo: definir um método static que executa uma tarefa
static void ExibirMensagem()
{
    // tarefa: exibir uma mensagem
    Console.WriteLine("Primeira mensagem");
}

// 3º passo: observar a chamada do metodo - através da criação do objeto chamador - chamada direta do método
ExibirMensagem();

// 4º passo: agora que o delegate foi nomeado/criado é possivel praticar "transferencia de responsabilidade" de chamada/execução de um método
// como? R.: definir uma propriedade e atribuir à ela o delegate definido anteriormente. Isso vai  determinar que estamos criando uma propriedade delegada
DelegMensagem responsaTransf = new DelegMensagem(ExibirMensagem);

// 5º passo: chamar a execução o delegate
responsaTransf();

// 2º passo: *** para definir a tal trasnferencia de responsabilidade é necessário definir um instrumento lógico delegate. Ao defini-lo será possivel, a partir deste passo, utiliza-lo como tipo construido de uma propriedade qualquer 
public delegate void DelegMensagem();*/

//----------------------------------------------------------------

/* 2º abordagem

// 1º passo: definir um novo método que descreve uma nova tarefa
static void PrimeiraMensagem()
{
    // tarefa: exibir um conteudo
    Console.WriteLine("Um novo texto: MENSAGEM UM");
}

// 2º passo: definir um outro método para executar uma outra tarefa
static void SegundaMensagem()
{
    Console.WriteLine("Outro novo texto: MENSAGEM OUTRO");
}

// 4º passo: definir a propriedade 
DelegNovaMensagem conversa = null; // conversa é a prop delegada; a partir dela é que será realizada a trasnferencia de responsabilidade de chamada dos 2 métodos

// 5º passo: acessar a prop delegada conversa e coloca-la em operação
conversa = conversa + PrimeiraMensagem; // aqui, a prop delegada foi atribuida com a chamada do 1º método
conversa += SegundaMensagem; // aqui, a prop delegada conversa - que, inicialmente, foi atribuido pelo 1º método, agora, foi acumulada com o 2º método

// 6º passo: chamar o delegate à sua execução
conversa();


// 3º passo: definir um delegate
public delegate void DelegNovaMensagem();

// * ACIMA, É APRESENTADO, DE FORMA SIMPLES -AINDA - E IMPLICITA, O PRINCIPIO DA ASSINCRONICIDADE*/
// ---------------------------------------------------------------

/* 3º abordagem

// 2º passo: definir o conjunto de dados
string[] cidades = { "São Paulo - SP", "Santa Barbara D'Oeste - SP", "Paraguaçu Paulista - SP", "Patos - PB", "Sorocaba - SP"};

// 3º passo: definir a prop delegada
Buscar<string> pesquisa = p => p.Contains("t"); // esta é uma expressão lambda - uma expressão lambda - nada mais é do que uma pequena função anônima que, a partir do uso operador seta - retorna algo quando chamada a sua execução - () => {}
// p, aqui, é um parametro da expressão. Pelo fato de um ser contexto de parametro extremamente simples é desnecessario o uso dos parenteses que definem a expressão. Este contexto ja fica subententido

// 4º passo: expecificar onde a busca sera feita - para este proposito vamos definir um loop
foreach (var dados in cidades)
{
    // implementar a busca - a forma com a qual será realizada
    if (pesquisa(dados)) // aqui, é feita a chamada do delegate> a prop realiza a busca dentro da coleção de dados a partir da referencia a var iteradora
    {
        // exibir os valores
        Console.WriteLine(dados);
    }
}


// 1º passo: definir o delegate - este delegate será um elemento generic. Este delegate auxiliará na implementação de uma operação de busca de dados  - dentro um conjunto restritro e construido de forma simples.
public delegate bool Buscar<T>(T item); // o parametro (T item) é um parametro do delegate - receberá um argumento/valor correspondente a especificação dada ao delegate*/

// ---------------------------------------------------------------

/* 4ª abordagem

// 1º passo: definir o conjunto de dados
List<string> novasCidades = new List<string>()
{
    "Araçoiaba da Serra - SP", "Votorantim - SP", "São Roque - SP", "Tapirai - SP"
};

// 2º passo: fazer uso do delegate embarcado/interno/nativo/pré-fabricado implicito - diretamente do core do C#. Este delegate será usado a partir do Método Find(). Ele é do tipo Predicate

var novaBusca = novasCidades.Find(nb => nb.Contains("e"));

// o uso do delegate Find() resulta na 1ª ocorrencia encontrada - dentro do conjunto - e ignora as demais

// exibir o resultado
Console.WriteLine("Cidade(s) encontrada(s): " + novaBusca);*/

// --------------------------------------------------------------

/* 5ª abordagem 
using Fundamentos.CSharp.Cap0910.Delegates.Lambda;

// 2º passo: depois de definir o delegate é necessario definir a prop delegada
LidarComClasses deleg1 = ClasseDeleg1.Delegado1; // aqui, a prop delegada deleg1 acaba de receber a transferencia de responsabilidade de execução do método

// 3º passo: definir o caller: objeto chamador do delegate       
deleg1("Ola delegate");
Console.WriteLine(new string('-', 50));

// 4º passo: definir uma prop delegada para transferencia de responsabilidade de chamada do método da classe ClasseDeleg2
LidarComClasses deleg2 = ClasseDeleg2.Delegado2;

// 5º passo: definir o caller: objeto chamador do delegate
deleg2("Oi novo delegate!");
Console.WriteLine();
Console.WriteLine(new string('-', 50));

// 6º passo: definir - usando uma expressão lambda - um novo delegate
LidarComClasses delegLambda = (string msg) => Console.WriteLine("Expressão lambda -> " + msg);

// 7º passo: definir o caller - delegate delegLambda
delegLambda("delegate Lambda!");

// 1º passo: definir o delegate
public delegate void LidarComClasses(string msg); // este delegate está definido para lidar com os elementos que compõem as classes Delegado1 e Delegado2

*/

/* 6 abordagem */

using Fundamentos.CSharp.Cap0910.Delegates.Lambda;

Operacoes op = new Operacoes();

//segundo passo - acessar os delegates

//por ainda nao ter sido realizada a transferencia de responsabilidade, a operação com os delegates e metodos precisam de uma disposição diferente da usual.

Operacoes.Soma delegSoma = new Operacoes.Soma(op.Somar);

Operacoes.Subtracao delegSubtrair = new Operacoes.Subtracao(op.Subtrair);


//terceiro passo - definir os callers - objetos chamadores dos delegates
delegSoma(5, 10);
delegSubtrair(1002, 100);


