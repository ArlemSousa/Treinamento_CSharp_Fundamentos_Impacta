/*
 Coleções / Generics
 */

/*arrays*/

//array é uma variavel que recebe um conjunto de valores.

//Para se declarar um array de forma simples é necessário definir seu tipo <tipo>[] <identificador/var> = <tipo> inicialização[numero de posições]

/* 1º abordagem - definição direta e simples do array unidimensional.

int[] valoresNum = new int[5];

//praticar as atribuições

valoresNum[00] = 1;
valoresNum[01] = 21;
valoresNum[02] = 13;
valoresNum[03] = 14;
valoresNum[04] = 15;

for (int i = 0; i <= valoresNum.Length -1; i++)
{
    Console.WriteLine("Valores do array: " + valoresNum[i]);

}
*/

/*SEGUNDA ABORDAGEM 
using System.Linq;

Console.WriteLine("Uma nova forma de construir um array - fazendo o uso de um par de chaves{}");

int[] novosNumeros = { 65, 15, 540, 2, 58, 4, 3, 1, 0, 44 };

//iterar sobre o conjunto
for (int x = 0; x < novosNumeros.Length; x++)
{

    Console.WriteLine("Valores do array: " + novosNumeros[x]);
}
*/

/*terceira abordagem - arrays bidirecionais

int[,] bidirecional = new int[3, 4];
//acessar a var e seus indices posicionais

bidirecional[0, 0] = 89;
bidirecional[0, 1] = 23;
bidirecional[0, 2] = 55;
bidirecional[0, 3] = 69;

bidirecional[1, 0] = 99;
bidirecional[1, 1] = 13;
bidirecional[1, 2] = 65;
bidirecional[1, 3] = 79;

bidirecional[2, 0] = 81;
bidirecional[2, 1] = 26;
bidirecional[2, 2] = 51;
bidirecional[2, 3] = 75;


foreach(int v in bidirecional)
{
    Console.WriteLine(v);
}

*/

/*segunda abordagem de array bidirecional - array de tamanho variavel

int[,] novoBidirecional = new int[,]
{
    //com a instrução acima estamos definindo um array de tamanho variavel.

    {1,2,3,4 }, //1º conjunto
    {5,6,7,8 }, //2º conjunto
    {9,10,11,12 },

    //obs: no caso de um array bidirecional de tamanho variavel  sua estrutura possui duas dimensões serão definidas pela quantodade de linhas e quantidade de valores que compõe cada linha.
    //formando assim o numero de colunas.


};

//fazer o uso de alguns recursos importantes para manipular a matriz exibindo um "mapeamento" de suas caracteristicas.
Console.WriteLine("total de dimensões da matriz: " + novoBidirecional.Rank);
Console.WriteLine(new string('-',50));
Console.WriteLine("quantidade de posições da matriz: " + novoBidirecional.Length);
Console.WriteLine(new string('-', 50));
Console.WriteLine("total de elementos  dimensao 1 da matriz: " + novoBidirecional.GetLength(0));
Console.WriteLine(new string('-', 50));


//definir uma estrutura de repetição para iterar todos os valores da matriz.

//este vai iterar sobre a primeira dimensao(linhas) da matriz
for (int x = 0; x < 3; x++)
{

    //segundo loop para iterar sobre a segunda dimensão (colunas)
    for (int y = 0; y < 4; y++)
    {
        Console.WriteLine("A matriz é composta por [{0}, {1}] = {2}", x, y, novoBidirecional[x, y]);
    }
}

*/

/* terceira abordagem / uso da classe classeArray.

using Fundamentos.CSharp.Cap07_08.Colecoes.Genererics;

//fazendo o uso do metodo estatico da classe da primeira abordagem
//Console.WriteLine("Resultado do calculo da media: " + ClasseArray.CalcularMedia(9,2,8,10)); //na chamada do metodo, estamos passando valores - como argumento para o parametro de forma direta.

//este é um array simples com dados da mesma natureza (int).
int[] dadinho = { 1, 2, 3 };

//definir um array com dados de diferentes naturezas.
object[] dadinhoGeral = { "zé", 1, 2, "uma frase", "", dadinho };

ClasseArray.ExibirValores(dadinhoGeral);
*/

//neste passo vamos lidar com a collection arraylist

/*
Add()
Insert()
IndexOf() --verifica a veracidade de um valor dentro da collection
Remove() 
RemoveAt() - Remoer valores identificados
Sort() - organizar valores

*/

using Fundamentos.CSharp.Cap07_08.Colecoes.Genererics;
using System.Collections;
using System.Numerics;

ArrayList lista = new ArrayList();
Console.WriteLine("Uso do metodo add()");


lista.Add("lapis");
lista.Add("regua");
lista.Add("borracha");
lista.Add("caneta");
lista.Add("");
lista.Add("24");
lista.Add(12.3);

//definir uma estrutura de loop para iterar sobre o array
for (int i = 0; i< lista.Count; i++)
{
    Console.WriteLine(lista[i]);
}


//uso do metodo indexof - 
int umValor = lista.IndexOf("caneta");

//verificar a veracidade de indice posicional de um valor
if (umValor >=0 ) {
    Console.WriteLine("o valor esta na seguinte posicao " + umValor);
}
else
{
    Console.WriteLine("nao encontrado");
}

Console.WriteLine(new string ('-', 50));

//uso do metodo remove
lista.Remove("caneta");
//definir uma estrutura de loop para iterar sobre o array
for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine(lista[i]);
}

//uso do metodo remotat()
//remover o valor da lista a partir do indice posicional
Console.WriteLine(new string('-', 50));
lista.RemoveAt(5);
for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine(lista[i]);
}

//uso do metodo sort
//organizar valores que compõem a lista de dados
lista.Sort();
Console.WriteLine(new string('-', 50));
for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine(lista[i]);
}

Console.WriteLine(new string('-', 50));
Console.WriteLine();


/*****************   collection stack  *********************/
/*
metodo push()
peek()
pop()

*/

Stack empilhamento = new Stack();

Console.WriteLine("uso do metodo push() - classe stack()");

//compor o empilhamento
empilhamento.Push("regua");     //4
empilhamento.Push("lapis");     //3
empilhamento.Push("borracha");  //2
empilhamento.Push("apontador"); //1
empilhamento.Push(888);         //0

foreach (object i in empilhamento)
{
    Console.WriteLine(i);
}
Console.WriteLine(new string('-', 50));
Console.WriteLine();



Console.WriteLine("uso do metodo peek() - classe stack()");
//recupera o primeiro item da pilha de dados
Console.WriteLine("primeiro item da pilha é: " + empilhamento.Peek());
Console.WriteLine(new string('-', 50));
Console.WriteLine();



Console.WriteLine("uso do metodo pop() - classe stack()");
//exclui o primeiro item da pilha de dados
Console.WriteLine("primeiro item da pilha acaba de ser excluido: " + empilhamento.Pop());
Console.WriteLine();
foreach (object i in empilhamento)
{
    Console.WriteLine(i);
}
Console.WriteLine(new string('-', 50));
Console.WriteLine();



/*****************   collection queue  *********************/
/*
metodo 
enqueue() insercao de dados na fila
peek() retorna primeiro da fila
dequeue() remove um elemento da fila 

*/

//praticar a instancia da classe queue

Queue novaFila = new Queue();

Console.WriteLine("Método ENQUEUE - classe QUEUE");
//compor o enfileiramento
novaFila.Enqueue("lapis");
novaFila.Enqueue("regua");
novaFila.Enqueue("borracha");
novaFila.Enqueue("55");
novaFila.Enqueue("caderno");

foreach(object fila in novaFila)
{
    Console.WriteLine(fila);
}

Console.WriteLine(new string('-', 50));
Console.WriteLine();


//metodo peek da classe queue
Console.WriteLine("Método peek() - classe QUEUE()");

Console.WriteLine("o primeiro item da fila é: " + novaFila.Peek());
foreach (object fila in novaFila)
{
    Console.WriteLine(fila);
}

Console.WriteLine(new string('-', 50));
Console.WriteLine();


//dequeue tambem remove o primeiro item da fila
Console.WriteLine("Método dequeue() - classe QUEUE()");
novaFila.Dequeue();
foreach (object fila in novaFila)
{
    Console.WriteLine(fila);
}

Console.WriteLine(new string('-', 50));
Console.WriteLine();


/*****************   classe hashtable  *********************/
/*
 
metodo 
add()
remove()

os valores que compoem a collection hashtable  nao possuem indices posicionais - nem mesmo valores que odedeçam ordem sequencial

*/

//gerar obj da classe hashtable()
Hashtable valoresComposto = new Hashtable();

Console.WriteLine("uso do metodo add a partir da classe hashtable()");

//composição da collection
valoresComposto.Add(1, "regua");
valoresComposto.Add(2, "lapis");
valoresComposto.Add(3, "apontador");
valoresComposto.Add(4, "caderno");
valoresComposto.Add(5, "borracha");
valoresComposto.Add("um", "valor");

//definir umm loop para iterar sobre os valores
foreach (DictionaryEntry i in valoresComposto)
{
    Console.WriteLine(i.Key + " : " + i.Value);
}
Console.WriteLine(new string('-', 50));
Console.WriteLine();


//uso do metodo remove
Console.WriteLine("Uso do metodo remove() da classe hashtable()");
valoresComposto.Remove(5);
valoresComposto.Remove("lapis"); //nao é possivel excluir o registro, somente é possivel usando a chave.
foreach (DictionaryEntry i in valoresComposto)
{
    Console.WriteLine(i.Key + " : " + i.Value);
}
Console.WriteLine(new string('-', 50));
Console.WriteLine();




/*****************   classe LIST<T>  *********************/
/*
 
esta classe é uma collection genérica e permite trabalhar com valores duplicados

*/

List<int> listaInteiro = new List<int>();

Console.WriteLine("uso do metodo add() da classe list()");
listaInteiro.Add(5);
listaInteiro.Add(7);
listaInteiro.Add(8);
listaInteiro.Add(100);
listaInteiro.Add(99);

foreach(int i in listaInteiro)
{
    Console.WriteLine(i);
}
Console.WriteLine(new string('-', 50));
Console.WriteLine();


//segunda forma para criação da lista
List<string> lst = new List<string>() { 
"um","dois","tres", "quatro","cinco"
};

Console.WriteLine("Os itens da lista sao: ");
foreach (string i in lst)
{
    Console.WriteLine(i);
}
Console.WriteLine(new string('-', 50));
Console.WriteLine();


Console.WriteLine("classe list<datetime>");

List<DateTime> dateTimes = new List<DateTime>()
{
    new DateTime(2024, 1, 25),
    new DateTime(2024, 2, 25),
    new DateTime(2024, 3, 25),
    new DateTime(2024, 4, 25),
    new DateTime(2024, 5, 25)
};

Console.WriteLine("Os itens da lista sao: ");
foreach (var i in dateTimes)
{
    Console.WriteLine(i);
}
Console.WriteLine(new string('-', 50));
Console.WriteLine();


/*****************   classe hashset<T>  - sortedset<> *********************/
/*
 
esta classe é uma collection genérica e nao permite trabalhar com valores duplicados

*/
Console.WriteLine("uso da classe hashset()");

HashSet<string> values = new HashSet<string>()
{
    "c#", "asp.net", "angular", "html", "css", "javascript", "c#"
};
Console.WriteLine("qtd de elementos dentro da collections: " + values.Count());
Console.WriteLine();

Console.WriteLine("Os itens da lista sao: ");
foreach (var i in values)
{
    Console.WriteLine(i);
}
Console.WriteLine(new string('-', 50));
Console.WriteLine();


//implementação do sortedset()
Console.WriteLine("implementação do sortedset()");
SortedSet<string> novosTreinamentos = new SortedSet<string>
{
        "c#", "asp.net", "angular", "html", "css", "javascript", "analise de dados", "analise de dados"
};
Console.WriteLine("Os itens da lista sao: ");
foreach (var i in novosTreinamentos)
{
    Console.WriteLine(i);
}
Console.WriteLine(new string('-', 50));
Console.WriteLine();
//aqui já existe um ordenamento da lista pela tabela asc


//para exibir o contexto deste método será necessário definir, aqui um loop ppara iterar sobre o metodo que retorna os valores definidos na classe testeEnumerable() 

Console.WriteLine(testeEnumerable.ListaNomes());
foreach (var exibirNomes in testeEnumerable.ListaNomes())
{
    Console.WriteLine(exibirNomes);
}
