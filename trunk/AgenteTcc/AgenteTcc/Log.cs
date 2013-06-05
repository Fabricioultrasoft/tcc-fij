using Agente;
using Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AgenteTcc
{
    class Log
    {

        #region Propriedades
        private string numeroSerie;
        private DateTime dataHoraInicializacao;
        private string nomeSoftware;
        private DateTime dataHoraInicializacaoSoftware;
        private DateTime dataHoraFinalizacaoSoftware;
        private DateTime dataHoraEncerramento;
        private string respostaPergunta1;
        private string respostaPergunta2;
        private string respostaPergunta3;
        private string respostaPergunta4;
        private string respostaPergunta5;
        private string respostaPergunta6;
        private string respostaPergunta7;
        private string respostaPergunta8;

        private bool isNewFile;
        private bool isInitialize;
        private bool isShutdown;
        private bool isSoftwareInitialize;
        private bool isSoftwareClose;

        public bool IsSoftwareClose
        {
            get { return isSoftwareClose; }
            set { isSoftwareClose = value; }
        }

        public bool IsSoftwareInitialize
        {
            get { return isSoftwareInitialize; }
            set { isSoftwareInitialize = value; }
        }

        public bool IsShutdown
        {
            get { return isShutdown; }
            set { isShutdown = value; }
        }

        public bool IsInitialize
        {
            get { return isInitialize; }
            set { isInitialize = value; }
        }

        public bool IsNewFile
        {
            get { return isNewFile; }
            set { isNewFile = value; }
        }

        public string RespostaPergunta8
        {
            get { return respostaPergunta8; }
            set { respostaPergunta8 = value; }
        }
        public string RespostaPergunta7
        {
            get { return respostaPergunta7; }
            set { respostaPergunta7 = value; }
        }

        public string RespostaPergunta6
        {
            get { return respostaPergunta6; }
            set { respostaPergunta6 = value; }
        }


        public string RespostaPergunta5
        {
            get { return respostaPergunta5; }
            set { respostaPergunta5 = value; }
        }

        public string RespostaPergunta4
        {
            get { return respostaPergunta4; }
            set { respostaPergunta4 = value; }
        }

        public string RespostaPergunta3
        {
            get { return respostaPergunta3; }
            set { respostaPergunta3 = value; }
        }

        public string RespostaPergunta2
        {
            get { return respostaPergunta2; }
            set { respostaPergunta2 = value; }
        }

        public string RespostaPergunta1
        {
            get { return respostaPergunta1; }
            set { respostaPergunta1 = value; }
        }

        public DateTime DataHoraEncerramento
        {
            get { return dataHoraEncerramento; }
            set { dataHoraEncerramento = value; }
        }

        public DateTime DataHoraFinalizacaoSoftware
        {
            get { return dataHoraFinalizacaoSoftware; }
            set { dataHoraFinalizacaoSoftware = value; }
        }

        public DateTime DataHoraInicializacaoSoftware
        {
            get { return dataHoraInicializacaoSoftware; }
            set { dataHoraInicializacaoSoftware = value; }
        }

        public string NomeSoftware
        {
            get { return nomeSoftware; }
            set { nomeSoftware = value; }
        }

        public DateTime DataHoraInicializacao
        {
            get { return dataHoraInicializacao; }
            set { dataHoraInicializacao = value; }
        }

        public string NumeroSerie
        {
            get { return RegistryMemore.NumeroSerie; }

        }
        #endregion

        private void CriarPastaDestino()
        {
            string caminho = string.Join("\\",RegistryMemore.DestinoLog.Split('\\').Take(RegistryMemore.DestinoLog.Split('\\').Count() - 1));
            if (!Directory.Exists(caminho))
                Directory.CreateDirectory(caminho);
          
        }
        private void CriarArquivoDestino()
        {
            string caminho = RegistryMemore.DestinoLog;
            if (!File.Exists(caminho))
            {
                File.Create(caminho);
                isNewFile = true;
            }

        }

        public void Append()
        {
            CriarPastaDestino();
            CriarArquivoDestino();

            while (true)
            {
                try
                {
                    System.IO.TextWriter arquivo = System.IO.File.AppendText(RegistryMemore.DestinoLog);
                    arquivo.Write(GetModeloArquivo());
                    arquivo.Close();
                    break;
                }
                catch
                {

                }
            }
        }
       
        private string GetModeloArquivo()
        {
            StringBuilder sb = new StringBuilder();
            if (isNewFile)
            {
                sb.AppendLine(NumeroSerie);
                isNewFile = false;
            }
            if (IsInitialize)
            {
                sb.AppendLine(string.Format("I # {0}#{1}", dataHoraInicializacao.ToShortDateString(), dataHoraInicializacao.ToShortTimeString()));
                IsInitialize = false;
            }
            if (isSoftwareInitialize)
            {
                sb.AppendLine(string.Format("{0} # A # {1}#{2}", nomeSoftware, 
                                                                 dataHoraInicializacaoSoftware.ToShortDateString(), 
                                                                 dataHoraInicializacaoSoftware.ToLongTimeString())
                                                                 );
            }
            if (isSoftwareClose)
            {
                sb.AppendLine(string.Format("{0} # F # {1}#{2}", nomeSoftware, 
                                                                 dataHoraFinalizacaoSoftware.ToShortDateString(),
                                                                 dataHoraFinalizacaoSoftware.ToLongTimeString())
                                                                 );
            }
            if (isShutdown)
            {
                sb.AppendFormat("E # {0}#{1}", dataHoraEncerramento.ToShortDateString(), dataHoraEncerramento.ToShortTimeString());
                //Questionario
                sb.AppendFormat("#{0}#{1}#{2}#{3}#{4}#{5}#{6}#{7}",respostaPergunta1,
                                                               respostaPergunta2,
                                                               respostaPergunta3,
                                                               respostaPergunta4,
                                                               respostaPergunta5,
                                                               respostaPergunta6,
                                                               respostaPergunta7,
                                                               respostaPergunta8
                                                               );
            }

            return sb.ToString();
        }
    }
}
