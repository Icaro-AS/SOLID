using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_LSP.Problema
{
    internal class ValorPagamentoParcelado : Fatura
    {
        public override decimal GerarFaturaDescontoOuEncargo(decimal valor)
        {
            int parcelas = 0;
            return valor / parcelas;
        }
    }
}
