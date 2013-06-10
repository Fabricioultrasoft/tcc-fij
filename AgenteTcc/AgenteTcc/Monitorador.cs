using Common;
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
        static ManagementEventWatcher processStartEvent = new ManagementEventWatcher(GetQueryForStartEvents());
        static ManagementEventWatcher processStopEvent = new ManagementEventWatcher(GetQueryForStopEvents());

        public Monitorador()
        {
            #region LOG

            Log log = new Log()
            {
                IsInitialize = true,
                DataHoraInicializacao = DateTime.Now
            };
            log.Append();

            #endregion

            processStartEvent.EventArrived += new EventArrivedEventHandler(processStartEvent_EventArrived);
            processStartEvent.Start();
            processStopEvent.EventArrived += new EventArrivedEventHandler(processStopEvent_EventArrived);
            processStopEvent.Start();
        }
        static void processStartEvent_EventArrived(object sender, EventArrivedEventArgs e)
        {
            var values = (ManagementBaseObject)e.NewEvent.Properties["Representative"].Value;

            string processName = values.Properties["ProcessName"].Value.ToString();
            string processID = Convert.ToInt32(values.Properties["ProcessID"].Value).ToString();

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
            var values = (ManagementBaseObject)e.NewEvent.Properties["Representative"].Value;

            string processName = values.Properties["ProcessName"].Value.ToString();
            string processID = Convert.ToInt32(values.Properties["ProcessID"].Value).ToString();

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

        private static string GetQueryForStartEvents()
        {
            StringBuilder query = new StringBuilder();
            query.Append("SELECT * FROM Win32_ProcessStartTrace");

            List<string> process = RegistryMemore.ListaSoftwares.Split(';').ToList();

            if (process.Count > 0)
                query.Append(" WHERE ");

            foreach (string processName in process)
            {
                query.AppendFormat("ProcessName = '{0}' or ", processName);
            }
            query = query.Remove(query.Length - 4, 4);

            query.Append(" GROUP WITHIN 10 BY ProcessName");

            return query.ToString();
        }

        private static string GetQueryForStopEvents()
        {
            StringBuilder query = new StringBuilder();
            query.Append("SELECT * FROM Win32_ProcessStopTrace");

            List<string> process = RegistryMemore.ListaSoftwares.Split(';').ToList();

            if (process.Count > 0)
                query.Append(" WHERE ");

            foreach (string processName in process)
            {
                query.AppendFormat("ProcessName = '{0}' or ", processName);
            }
            query = query.Remove(query.Length - 4, 4);

            query.Append(" GROUP WITHIN 10 BY ProcessName");

            return query.ToString();
        }

    }
}
