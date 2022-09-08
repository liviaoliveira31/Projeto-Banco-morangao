using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjBancoMorangao
{
    internal class Pagamento
    {
        public DateTime DataTransacoes { get; set; }
        public string TipoDaOperacao { get; set; }

        public double Valor { get; set; }

        public Pagamento()
        {

        }

        public Pagamento(DateTime dataTransacoes, string tipoDaOperacao, double valor)
        {
            DataTransacoes = dataTransacoes;
            TipoDaOperacao = tipoDaOperacao;
            Valor = valor;
        }
    }
}
