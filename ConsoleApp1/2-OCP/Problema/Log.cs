using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_OCP.Problema
{
    internal class Log : ILog
    {
        public Log()
        {
            //Construtor
        }

        public void Info(string info)
        {
            //Código que registra a informação do log
        }

        public void Debug(string info)
        {
            //Código que registra a informação de depuração do código
        }

        public void Erro(string erro, Exception ex)
        {
            //Código que registra a exceção capturada 
        }
    }
}
