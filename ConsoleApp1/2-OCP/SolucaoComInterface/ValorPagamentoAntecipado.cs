using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_OCP.SolucaoComInterface
{
    internal class ValorPagamentoAntecipado : IValorPagamentoTipo
    {
        public decimal GerarFaturaDescontoOuEncargo(decimal valor)
        { 
            return valor - 100;
        }
    }
}
