using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public static class RegistryMemore
    {
        static RegistryKey rkApp = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Memore", true);


        public static void CreateSubKey()
        {
            if (!Registry.LocalMachine.GetSubKeyNames().Contains("Memore"))
            {
                Registry.LocalMachine.CreateSubKey("SOFTWARE\\Memore");
            }
        }

      
        public static int TamanhoLog
        {
            get
            {

                return Convert.ToInt32(rkApp.GetValue("TamanhoLog"));
            }
            set
            {
                rkApp.SetValue("TamanhoLog", value);
            }
        }
        public static int IntervaloEnvio
        {
            get
            {

                return Convert.ToInt32(rkApp.GetValue("IntervaloEnvio"));
            }
            set
            {
                rkApp.SetValue("IntervaloEnvio", value);
            }
        }
        public static string NumeroSerie
        {
            get
            {

                return rkApp.GetValue("NumeroSerie").ToString();
            }
            set
            {
                rkApp.SetValue("NumeroSerie", value);
            }
        }
        public static string DestinoLog
        {
            get
            {

                return rkApp.GetValue("DestinoLog").ToString();
            }
            set
            {
                rkApp.SetValue("DestinoLog", value);
            }
        }
        public static string EmailDestinatario
        {
            get
            {

                return rkApp.GetValue("EmailDestinatario").ToString();
            }
            set
            {
                rkApp.SetValue("EmailDestinatario", value);
            }
        }
        public static int Smtp
        {
            get
            {

                return Convert.ToInt32(rkApp.GetValue("Smtp"));
            }
            set
            {
                rkApp.SetValue("Smtp", value);
            }
        }
        public static bool Ssl
        {
            get
            {

                return Convert.ToBoolean(rkApp.GetValue("Ssl"));
            }
            set
            {
                rkApp.SetValue("Ssl", value);
            }
        }
        public static string ServidorEmail
        {
            get
            {

                return rkApp.GetValue("ServidorEmail").ToString();
            }
            set
            {
                rkApp.SetValue("ServidorEmail", value);
            }
        }
        public static string EmailRemetente
        {
            get
            {

                return rkApp.GetValue("EmailRemetente").ToString();
            }
            set
            {
                rkApp.SetValue("EmailRemetente", value);
            }
        }
        public static string UsuarioEmail
        {
            get
            {

                return rkApp.GetValue("UsuarioEmail").ToString();
            }
            set
            {
                rkApp.SetValue("UsuarioEmail", value);
            }
        }
        public static string SenhaEmail
        {
            get
            {

                return rkApp.GetValue("SenhaEmail").ToString();
            }
            set
            {
                rkApp.SetValue("SenhaEmail", value);
            }
        }
        public static string AssuntoEmail
        {
            get
            {

                return rkApp.GetValue("AssuntoEmail").ToString();
            }
            set
            {
                rkApp.SetValue("AssuntoEmail", value);
            }
        }
        public static string CorpoEmail
        {
            get
            {

                return rkApp.GetValue("CorpoEmail").ToString();
            }
            set
            {
                rkApp.SetValue("CorpoEmail", value);
            }
        }

        public static string ListaSoftwares
        {
            get
            {

                return rkApp.GetValue("ListaSoftwares").ToString();
            }
            set
            {
                rkApp.SetValue("ListaSoftwares", value);
            }
        }

    }
}
