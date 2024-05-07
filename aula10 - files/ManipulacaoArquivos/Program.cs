// manipulação de arquivos e pastas.

//definida uma variavel que atuará como referenci=, porque receberá como valor o caminho/path que escolhemos para guardar os files que serão manipulados

using System.IO;

//string caminho = @"C:\Users\User\OneDrive\Documentos\Impacta C#\NovaPastaC#\"; //@ significa at - aqui.

/*
//primeira op é criar um novo file
File.Create(caminho);

string conteudo = "Conteúdo: Gravação usando WriteAllText";
File.WriteAllText(caminho, conteudo);

//3 operacao, lleitura do arquivo
File.ReadAllLines(caminho);

string leituraConteudo = File.ReadAllText(caminho);
Console.WriteLine(leituraConteudo);
*/

/*
//4 operacao

string[] treinamento =
{
    "Curso 1 : c#",
    "Curso 2 : .net",
    "Curso 3 : banco"
};

File.WriteAllLines(caminho, treinamento);

File.ReadAllLines(caminho);

string leituraConteudo = File.ReadAllText(caminho);
Console.WriteLine(leituraConteudo);
*/

/*
//5 passo - escrer novo texto e manter o que ja existe.
string[] novosCursos =
{
    "\n\nCurso 4: angular",
    "Curso 5: logica",
    "Curso 6: git"
};

File.AppendAllLines(caminho, novosCursos);
Console.WriteLine(File.ReadAllText(caminho));
*/

/*
//6 passo - criar um novo diretorio

string caminho2 = @"C:\Users\User\OneDrive\Documentos\Impacta C#\Teste C#";

//usara classe nativa /embarcada / interna Directory(){}

Directory.CreateDirectory(caminho2);

*/

/*
//7 operacao - deletar o diretorio 
string caminho2 = @"C:\Users\User\OneDrive\Documentos\Impacta C#\Teste C#";
Directory.Delete(caminho2);
*/

/*
//8 operacao
string caminho2 = @"C:\Users\User\OneDrive\Documentos\Impacta C#\Teste C#";
if (Directory.Exists(caminho2))
{
    Console.WriteLine("Existe");
}
else
{
    Console.WriteLine("Nao existe");
}
*/

/*
//8 operacao  passo 2
string meuArquivo = "NovoArquivo.txt";

string caminhoPastaArquivo = Path.Combine(caminho, meuArquivo);

string umConteudo = "Este é o conteudo que será escrito no txt";

try
{
    if (!Directory.Exists(caminho))
    {
        Directory.CreateDirectory(caminho);
        Console.WriteLine($"A pasta {caminho} foi criada com sucesso.");
    }

    if (!File.Exists(caminhoPastaArquivo))
    {
        File.Create(caminhoPastaArquivo).Close();
        Console.WriteLine($"O arquivo {caminhoPastaArquivo} foi criado com sucesso.");
    }

    File.WriteAllText(caminhoPastaArquivo, umConteudo);
    Console.WriteLine("Arquivo escrito com sucesso");
}
catch (Exception excessao)
{
    Console.WriteLine("Ocorreu um erro. foi este: " + excessao.Message);
}

*/

/*

//operacao 9
//consiste em verificar ocorrencia de diretorios num determinado local

string caminho0 = @"C:\Users\User\OneDrive\Documentos\Impacta C#\"; //@ significa at - aqui.

string[] pastasVerificadas = Directory.GetDirectories(caminho0);

//exibir os valores contidos na pastaVerificas

foreach(var pastas in pastasVerificadas)
{
    Console.WriteLine(pastas);
}



//operacao 10 - verificar a existencia de arquivos num local
string[] arquivosVerificados = Directory.GetFiles(caminho0);
foreach (var arqs in arquivosVerificados)
{
    Console.WriteLine("Files: " + arqs);
}

*/

//11 operacao

//string caminho11 = @"C:\Users\User\OneDrive\Documentos\Impacta C#\arq.txt"; //@ significa at - aq

//FileStream arquivoStream = new FileStream(caminho11, FileMode.Open);

//StreamReader lendoDados = new StreamReader(arquivoStream);

//while (lendoDados.Peek() != -1)
//{
//    Console.WriteLine((char)lendoDados.Read());
//    //conversao implicita
//}
//lendoDados.Close();
//arquivoStream.Close();


//12 operacao
string caminho12 = @"C:\Users\User\OneDrive\Documentos\Impacta C#\arq.txt"; //@ significa at - aq

StreamReader leitorStream = new StreamReader(caminho12);

string linha;

while ((linha = leitorStream.ReadLine()) != null) 
{
    Console.WriteLine(linha);

}
leitorStream.Close();


//13 operacao
//escrever um conteudo streamado

//definir uma var pra receber como valor a instancia da classe StreamWriter(){}


StreamWriter escritorConteudo = new StreamWriter(caminho12);

escritorConteudo.WriteLine("Olá Stream de escrita");

escritorConteudo.Close();

Console.WriteLine("Escrita OK");
