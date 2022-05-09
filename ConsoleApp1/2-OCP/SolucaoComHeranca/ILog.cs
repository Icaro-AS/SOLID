using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_OCP.SolucaoComHeranca
{
    internal interface ILog    {
        void Info (string info);
        void Debug(string info);
        void Erro(string error, Exception ex);

    }
}
