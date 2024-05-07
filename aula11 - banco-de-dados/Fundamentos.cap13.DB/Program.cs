using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using Fundamentos.cap13.DB;
using System.Runtime.InteropServices;

//definir uma var
//string conexao = @"Integrated Security=SSPI; Encrypt=False; Persist Security Info=false; Initial Catalog=Mercadorias; Data source=WinDev2401Eval";
string conexao = @"Server=WinDev2401Eval;Integrated Security=SSPI;Encrypt=False;Persist Security Info=false;Initial Catalog=Mercadorias";


//manipulacao da table tbCategorias.

/*
void IncluirCategoria()
{
    Console.WriteLine("Informe a Categoria:");
    string categoria = Console.ReadLine();

    using (var con = new SqlConnection(conexao)) 
    {
        var registro = con.Execute("Insert into TBCategorias (Descricao) values (@Descricao)", new { Descricao = categoria });
    }
}


IncluirCategoria();

*/


/*
void ListarCategorias()
{

    using (var con = new SqlConnection(conexao))
    {
        var categorias = con.Query<Categorias>("select * from TBCategorias");

        foreach (var item in categorias)
        {
            Console.WriteLine("Id Categoria: " + item.IdCategoria);
            Console.WriteLine("Nome da categoria: " + item.Descricao);
        }
    }
}

ListarCategorias();
*/

/*
void AlterarCategorias()
{
    Console.WriteLine("Por favor, informe o id da categoria que deseja alterar: ");
    int codigo = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe o novo nome");
    string nova = Console.ReadLine(); 

    using (var con = new SqlConnection(conexao))
    {
        var alteracao = con.Execute("update TBCategorias set Descricao = @Descricao where IdCategoria = @IdCategoria", new {IdCategoria = codigo, Descricao = nova});

    }
}

AlterarCategorias();
*/

/*
void DeleteCategorias()
{
    Console.WriteLine("Por favor, informe o id da categoria que deseja remover: ");
    int codigo = int.Parse(Console.ReadLine());

    using (var con = new SqlConnection(conexao))
    {
        var deletar = con.Execute("delete TBCategorias where IdCategoria = @IdCategoria", new { IdCategoria = codigo });

    }
     
}

DeleteCategorias();
*/