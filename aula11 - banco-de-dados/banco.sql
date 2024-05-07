--indicar o db que será utilizado para a criação das tables
use Mercadorias;

create table TBCategorias (
IdCategoria int identity(1,1),
Descricao varchar(30) not null,
Primary key(IdCategoria)
) 
go -- determina uma sequencia de execução de 

create table  TBProdutos (
IdProduto int identity,
NomeProduto varchar(50),
IdCategoria int not null
Primary key (IdProduto),
foreign key (IdCategoria) references TBCategorias(IdCategoria)
)
go