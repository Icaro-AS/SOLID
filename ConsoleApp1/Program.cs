using SOLID._3_LSP.Solucao;
using System;

namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Violação Lsp 
            Fatura faturaParcelada = new ParcelarEmSeisVezes();
            faturaParcelada.FaturaValor = 500.00m;
            Console.WriteLine(faturaParcelada.ParcelarFatura(faturaParcelada.FaturaValor)); 
        }
    }
}
