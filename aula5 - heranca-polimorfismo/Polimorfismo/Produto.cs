using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Produto
    {
        public string? nome { get; set; }
        public double Preco { get; set; }


        public virtual string ExibirInfos()
        {
            return string.Format("Nome: {0}\nPreco: {1}", nome.ToUpper(), Preco.ToString()); 
        }
    }
}
