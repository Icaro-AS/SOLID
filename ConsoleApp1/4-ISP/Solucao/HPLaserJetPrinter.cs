using SOLID._4_ISP.Interfaces.Solucao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_ISP.Solucao
{
    internal class HPLaserJetPrinter : IFaxTasks, IPrinter, 
                                       IPrinterDuplexTasks, IScanner
    {
        public void Print(string printContent)
        {
            Console.WriteLine("Print Done");
        }
        public void Scan(string scanContent)
        {
            Console.WriteLine("Scan content");
        }
        public void Fax(string faxContent)
        {
            Console.WriteLine("Fax content");
        }
        public void PrintDuplex(string printDuplexContent)
        {
            Console.WriteLine("Print Duplex content");
        }
    }
}
