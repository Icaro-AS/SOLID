using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1_SRP.Solucao
{
    internal class Fatura
    {

        public int IdFatura { get; set; }   
        public decimal FaturaValor { get; set; }
        public DateTime FaturaDate { get; set; }



        private ILog arquivoLog;
        private Email email;
        
        public Fatura()
        {
            arquivoLog = new Log();
            email = new Email();
        }

        public void EnviarFatura()
        {
            try
            {
                arquivoLog.Info("Início da operação");
              
                email.EmailDe = "um_email@provedor.com";
                email.EmailPara = "outro_email@provedor.com";
                email.EmailAssunto = "Assunto do email";
                email.EmailCorpo = "Corpo do Email";
                email.EnviarEmail();
            }
            catch (Exception ex)
            {
                arquivoLog.Erro("Erro ao gerar fatura", ex);
            }
        }

        public void ExcluiFatura()
        {
            try
            {
                // Código para exclusão da fatura
                arquivoLog.Info("Excluindo fatura em " + DateTime.Now);
            }
            catch(Exception ex)
            {
                arquivoLog.Erro("Erro ocorrido ao excluir fatura", ex);
            }
        }

    }
}
