using SOLID._4_ISP.Interfaces.Solucao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_ISP.Solucao
{
    internal class EpsonInkjetPrinter : IPrinter, IScanner
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }
        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
    }
}
