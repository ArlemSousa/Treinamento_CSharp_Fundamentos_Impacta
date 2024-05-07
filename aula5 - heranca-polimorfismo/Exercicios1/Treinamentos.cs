using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static Exercicios1.TreinamentoAbstract;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercicios1
{
    public class Treinamentos : TreinamentoAbstract
    {
        //A classe tem as seguintes propriedades: IdTreinamento e NomeTreinamento
        private int _idTreinamento;
        private string _nomeTreinamento;

        public int IdTreinamento
        {
            get { return _idTreinamento; }
            set { _idTreinamento = value; }
        }
        public string NomeTreinamento
        {
            get { return _nomeTreinamento; }
            set { _nomeTreinamento = value; }
        }

        // Construtor com valores padrão
        public Treinamentos()
        {
            
        }

        //encapsulamento implicito
        public Treinamentos(int idTreinamento, string nomeTreinamento)
        {
            IdTreinamento = idTreinamento;
            NomeTreinamento = nomeTreinamento;
        }

        public string GetTreinamento()
        {
            return $"ID do treinamento: {IdTreinamento} \nNome do treinamento: {NomeTreinamento}";
        }

        //sem retorno
        public void SetTreinamento(int idTreinamento, string nomeTreinamento)
        {
            IdTreinamento = idTreinamento;
            NomeTreinamento = nomeTreinamento;
        }

        public override string ObterNome()
        {
            return NomeTreinamento;
        }
    }

}
