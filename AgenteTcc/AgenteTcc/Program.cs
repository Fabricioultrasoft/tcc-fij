using Agente;
using Common;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
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

            //new Questionario().ShowDialog();

            SystemEvents.SessionEnding += SessionEndingEvtHandler;


            Transferencia.IniciarTransferencia();

            RegistryMemore.QuantidadeSessoesAtual += 1;

            if (Internet.IsConnected())
            {
                try
                {
                    Horario.UpdateWindowsClockFromInternet();
                }
                catch
                {
                    new AjusteHorario().ShowDialog();
                }
            }
            else
                new AjusteHorario().ShowDialog();


            new Monitorador();
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
