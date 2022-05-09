using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_LSP.Solucao
{
    internal class ParcelamentoFatura : Fatura
    {
        public decimal ParcelarFatura(decimal valor, int numeroParcelas)
        {
            decimal valorParcelaComJuros = (valor / numeroParcelas) * 1.1m;
            return valorParcelaComJuros;
        }
    }
}
