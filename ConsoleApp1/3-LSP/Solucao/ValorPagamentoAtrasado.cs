using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_LSP.Solucao
{
    internal class ValorPagamentoAtrasado : Fatura
    {
        public override decimal GerarFaturaDescontoOuEncargo(decimal valor)
        {
            return valor + 100;
        }
    }
}