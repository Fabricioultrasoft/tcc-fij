using Common;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Instalador
{
    public class Installer
    {
        public static string TargetPath { get; set; }


        public static int TamanhoLog { get; set; }
        public static int QuantidadeSessoes { get; set; }
        public static string NumeroSerie { get; set; }
        public static string DestinoLog { get; set; }
        public static string EmailDestinatario { get; set; }
        public static int Smtp { get; set; }
        public static bool Ssl { get; set; }
        public static string ServidorEmail { get; set; }
        public static string EmailRemetente { get; set; }
        public static string UsuarioEmail { get; set; }
        public static string SenhaEmail { get; set; }
        public static string AssuntoEmail { get; set; }
        public static string CorpoEmail { get; set; }
        public static string ListaSoftwares { get; set; }

        public static ProgressBar ProgressBarInstalacao {get;set;}


        public static void Install()
        {
            CopyFile();
            ProgressBarInstalacao.PerformStep();
            SetRegistryValues();
        }
        private static void CopyFile()
        {
            var arraySourcePath = System.Reflection.Assembly.GetExecutingAssembly().Location.Split('\\');

            string sourcePath = string.Join("\\", arraySourcePath.Take(arraySourcePath.Count() - 1).ToArray());
            sourcePath = string.Format("{0}\\Agente.exe", sourcePath);

            string targetPath = String.Format("{0}\\{1}", TargetPath, sourcePath.Split('\\').Last());

            try
            {
                if(!Directory.Exists(TargetPath))
                    Directory.CreateDirectory(TargetPath);
                if (File.Exists(targetPath))
                    File.Delete(targetPath);

               System.IO.File.Copy(sourcePath, targetPath, true);
            }

            catch
            {
                // Console.WriteLine("Double copy is not allowed, which was not expected.");
            }
        }

        private static void SetRegistryValues()
        {

            RegistryMemore.CreateSubKey();

            ProgressBarInstalacao.PerformStep();

            RegistryMemore.QuantidadeSessoesMaxima = QuantidadeSessoes;

            ProgressBarInstalacao.PerformStep();

            RegistryMemore.QuantidadeSessoesAtual = 0;

            ProgressBarInstalacao.PerformStep();

            RegistryMemore.NumeroSerie = NumeroSerie;

            ProgressBarInstalacao.PerformStep();

            RegistryMemore.DestinoLog = DestinoLog;

            ProgressBarInstalacao.PerformStep();

            RegistryMemore.EmailDestinatario = EmailDestinatario;

            ProgressBarInstalacao.PerformStep();

            RegistryMemore.Smtp = Smtp;

            ProgressBarInstalacao.PerformStep();

            RegistryMemore.Ssl = Ssl;

            ProgressBarInstalacao.PerformStep();

            RegistryMemore.ServidorEmail = ServidorEmail;

            ProgressBarInstalacao.PerformStep();

            RegistryMemore.EmailRemetente = EmailRemetente;

            ProgressBarInstalacao.PerformStep();

            RegistryMemore.UsuarioEmail = UsuarioEmail;

            ProgressBarInstalacao.PerformStep();

            RegistryMemore.SenhaEmail = SenhaEmail;

            ProgressBarInstalacao.PerformStep();

            RegistryMemore.AssuntoEmail = AssuntoEmail;

            ProgressBarInstalacao.PerformStep();

            RegistryMemore.CorpoEmail = CorpoEmail;

            ProgressBarInstalacao.PerformStep();

            RegistryMemore.ListaSoftwares = ListaSoftwares;

            ProgressBarInstalacao.PerformStep();
        }


      
    }
}
