using Agente;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AgenteTcc
{
    class Program
    {

        [DllImport("user32.dll", SetLastError = true)]
        static extern int CancelShutdown();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            SystemEvents.SessionEnding += SessionEndingEvtHandler;


            if (Internet.IsConnected())
                Horario.UpdateWindowsClockFromInternet();
            else
                new AjusteHorario().ShowDialog();

            new Monitorador();

            new Questionario().ShowDialog();
            Application.Run();
        }
        protected static void SessionEndingEvtHandler(object sender, SessionEndingEventArgs e)
        {

            if (e.Reason != SessionEndReasons.Logoff)
            {
                CancelShutdown();
                new Questionario().ShowDialog();
            }
        }

    }

}
