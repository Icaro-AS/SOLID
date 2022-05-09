using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_OCP.SolucaoComInterface
{
    internal class Email
    {
        public string EmailDe { get; set; }
        public string EmailPara { get; set; }
        public string EmailAssunto { get; set; }
        public string EmailCorpo { get; set; }

        public void EnviarEmail()
        {
            //Codigo para enviar email
        }
    }
}
