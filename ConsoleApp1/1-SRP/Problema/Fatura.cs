using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1_SRP.Problema
{
    internal class Fatura
    {
        public decimal FaturaValor { get; set; }
        public DateTime FaturaDate { get; set; }

        public void AddFatura()
        {
            try
            {
                MailMessage mailMessage = new MailMessage("De", "Para", "Assunto", "CorpoDoEmail");
                this.EnviarFaturaPorEmail(mailMessage);
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"c:\Log.txt", ex.Message);
            }
        }

        public void ExcluirFatura()
        {
            try
            {
                // Código para deletarmos uma fatura já gerada.
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"c:\Log.txt", ex.Message);
            }
        }

        public void EnviarFaturaPorEmail(MailMessage mailMessage)
        {
            try
            {
                //Código para enviarmos o email.
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"c:\Log.txt", ex.Message);
            }

        }
    }
}