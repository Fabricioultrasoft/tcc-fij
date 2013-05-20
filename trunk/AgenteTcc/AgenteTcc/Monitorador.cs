using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace AgenteTcc
{
    public class Monitorador
    {
        static ManagementEventWatcher processStartEvent = new ManagementEventWatcher("SELECT * FROM Win32_ProcessStartTrace WHERE ProcessName = 'notepad.exe' or ProcessName = 'chrome.exe' or ProcessName= 'iexplore.exe'");
        static ManagementEventWatcher processStopEvent = new ManagementEventWatcher("SELECT * FROM Win32_ProcessStopTrace WHERE ProcessName = 'notepad.exe'  or ProcessName = 'chrome.exe' or ProcessName= 'iexplore.exe'");

        public Monitorador()
        {
            processStartEvent.EventArrived += new EventArrivedEventHandler(processStartEvent_EventArrived);
            processStartEvent.Start();
            processStopEvent.EventArrived += new EventArrivedEventHandler(processStopEvent_EventArrived);
            processStopEvent.Start();
        }
        static void processStartEvent_EventArrived(object sender, EventArrivedEventArgs e)
        {
            string processName = e.NewEvent.Properties["ProcessName"].Value.ToString();
            string processID = Convert.ToInt32(e.NewEvent.Properties["ProcessID"].Value).ToString();

            #region LOG

            Log log = new Log()
            {
                NomeSoftware = processName,
                IsSoftwareInitialize = true,
                DataHoraInicializacaoSoftware = DateTime.Now
            };
            log.Append();

            #endregion

        }

        static void processStopEvent_EventArrived(object sender, EventArrivedEventArgs e)
        {
            string processName = e.NewEvent.Properties["ProcessName"].Value.ToString();
            string processID = Convert.ToInt32(e.NewEvent.Properties["ProcessID"].Value).ToString();

            #region LOG

            Log log = new Log()
            {
                NomeSoftware = processName,
                IsSoftwareClose = true,
                DataHoraFinalizacaoSoftware = DateTime.Now
            };
            log.Append();

            #endregion
        }

    }
}
