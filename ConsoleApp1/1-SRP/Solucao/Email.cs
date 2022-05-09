using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1_SRP.Solucao
{
    internal class Email
    {
        public string EmailDe { get; set; }
        public string EmailPara { get; set; }
        public string EmailAssunto{ get; set; }
        public string EmailCorpo { get; set; }

        public void EnviarEmail()
        {
            //Codigo para enviar email
        }

        public void DeletarEmail(int EmailId)
        {
            //Codigo para deletar email
        }
    }
}
