using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1_SRP.Solucao
{
    internal interface ILog    {
        void Info (string info);
        void Debug(string info);
        void Erro(string erro, Exception ex);

    }
}
