--indicar o db que ser� utilizado para a cria��o das tables
use Mercadorias;

create table TBCategorias (
IdCategoria int identity(1,1),
Descricao varchar(30) not null,
Primary key(IdCategoria)
) 
go -- determina uma sequencia de execu��o de 

create table  TBProdutos (
IdProduto int identity,
NomeProduto varchar(50),
IdCategoria int not null
Primary key (IdProduto),
foreign key (IdCategoria) references TBCategorias(IdCategoria)
)
go