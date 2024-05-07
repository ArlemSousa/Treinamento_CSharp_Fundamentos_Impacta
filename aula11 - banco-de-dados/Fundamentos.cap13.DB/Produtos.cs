
using Dapper.Contrib.Extensions;

namespace Fundamentos.cap13.DB
{
    [Table("TBProduto")]
    internal class Produtos
    {
        
        public Produtos()
        {
        }
        public int IdProduto { get; set; }
        public int IdCategoria { get; set; }
        public string NomeProduto { get; set; }


    }
}
