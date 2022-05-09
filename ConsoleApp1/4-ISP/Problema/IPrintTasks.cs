using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_ISP.Problema
{
    internal interface IPrintTasks
    {
        void Print(string printContent);
        void Scan(string scanContent);
        void Fax(string faxContent);
        void PrintDuplex(string printDuplexContent);
    }
}
