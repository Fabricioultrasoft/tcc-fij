using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace FormInvisivel
{
    class MainApplication
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern int CancelShutdown();

        public static void Main()
        {
         //   var t = FileSend.InternetConnection.IsConnectedToInternet();

            //if (!InstallOrDeinstall())
            //    return;
            SystemEvents.TimeChanged += new EventHandler(SystemEvents_TimeChanged);
            
            SystemEvents.SessionEnding += SessionEndingEvtHandler;
            Application.Run();
        }
        protected static void SessionEndingEvtHandler(object sender, SessionEndingEventArgs e)
        {

            if (e.Reason == SessionEndReasons.Logoff)
            {
                //Process.Start("shutdown", "-a");
            }
         
            CancelShutdown();
            new Formulario().Show();

        }

     
        protected static void SystemEvents_TimeChanged(object sender, EventArgs e)
        {
            new Formulario().Show();
        }

        private static bool InstallOrDeinstall()
        {
            if (!Installer.IsInstalled())
            {
                if (MessageBox.Show("Deseja instalar a aplicação?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        Installer.Install();
                        MessageBox.Show("Aplicação instalada com sucesso");
                        return true;
                    }
                    catch
                    {
                        MessageBox.Show("Ocorreu um erro ao instalar a aplicação");
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (MessageBox.Show("Deseja desinstalar a aplicação?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        Installer.Uninstall();
                        MessageBox.Show("Aplicação desinstalada com sucesso");
                        return true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocorreu um erro ao instalar a aplicação");
                        return false;
                    }

                }
                else
                {
                    return false;
                }
            }
        }


    }
}
