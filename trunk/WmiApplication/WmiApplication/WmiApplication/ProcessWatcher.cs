using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace WmiApplication
{
    public partial class ProcessWatch 
    {
        ManagementEventWatcher processStartEvent = new ManagementEventWatcher("SELECT * FROM Win32_ProcessStartTrace");
        ManagementEventWatcher processStopEvent = new ManagementEventWatcher("SELECT * FROM Win32_ProcessStopTrace");

        public ProcessWatch()
        {
            processStartEvent.EventArrived += new EventArrivedEventHandler(processStartEvent_EventArrived);
            processStartEvent.Start();
            processStopEvent.EventArrived += new EventArrivedEventHandler(processStopEvent_EventArrived);
            processStopEvent.Start();
        }

        void processStartEvent_EventArrived(object sender, EventArrivedEventArgs e)
        {
            string processName = e.NewEvent.Properties["ProcessName"].Value.ToString();
            string processID = Convert.ToInt32(e.NewEvent.Properties["ProcessID"].Value).ToString();

            Console.WriteLine("Process started. Name: " + processName + " | ID: " + processID);
        }

        void processStopEvent_EventArrived(object sender, EventArrivedEventArgs e)
        {
            string processName = e.NewEvent.Properties["ProcessName"].Value.ToString();
            string processID = Convert.ToInt32(e.NewEvent.Properties["ProcessID"].Value).ToString();

            Console.WriteLine("Process stopped. Name: " + processName + " | ID: " + processID);
        }
    }
}
