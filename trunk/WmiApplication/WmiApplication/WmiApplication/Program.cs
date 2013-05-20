using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using Microsoft.Win32;
using System.Net;
using System.IO;

namespace WmiApplication
{
    class Program
    {
        static ManagementEventWatcher processStartEvent = new ManagementEventWatcher("SELECT * FROM Win32_ProcessStartTrace WHERE ProcessName = 'notepad.exe' or ProcessName = 'chrome.exe' or ProcessName= 'iexplore.exe'");
        static ManagementEventWatcher processStopEvent = new ManagementEventWatcher("SELECT * FROM Win32_ProcessStopTrace WHERE ProcessName = 'notepad.exe'  or ProcessName = 'chrome.exe' or ProcessName= 'iexplore.exe'");

        public static int Main(string[] args)
        {
            HttpWebRequest httpWReq =
        (HttpWebRequest)WebRequest.Create(@"http://www.nossatv.tv.br/portal/validarLogin.do");

            ASCIIEncoding encoding = new ASCIIEncoding();
            string postData = "login=lvlsat";
            postData += "&senha=lvl99";
            byte[] data = encoding.GetBytes(postData);

            httpWReq.Method = "POST";
            httpWReq.ContentType = "application/x-www-form-urlencoded";
            httpWReq.ContentLength = data.Length;

            using (Stream stream = httpWReq.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            HttpWebResponse response = (HttpWebResponse)httpWReq.GetResponse();

            string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            if(responseString.Contains(@"<A href=""/portal/sair.do""> Sair </A>"))
            return 0;

            // -------------------------------------------------------------------------------------//

            processStartEvent.EventArrived += new EventArrivedEventHandler(processStartEvent_EventArrived);
            processStartEvent.Start();
            processStopEvent.EventArrived += new EventArrivedEventHandler(processStopEvent_EventArrived);
            processStopEvent.Start();
            Console.ReadKey();
            return 0;
        }
        static void processStartEvent_EventArrived(object sender, EventArrivedEventArgs e)
        {
            string processName = e.NewEvent.Properties["ProcessName"].Value.ToString();
            string processID = Convert.ToInt32(e.NewEvent.Properties["ProcessID"].Value).ToString();

            Log(string.Format("Aberto: {0} as {1} {2}; Process ID:{3}", processName, DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), processID));

            //  Console.WriteLine("Process started. Name: " + processName + " | ID: " + processID);
        }

        static void processStopEvent_EventArrived(object sender, EventArrivedEventArgs e)
        {
            string processName = e.NewEvent.Properties["ProcessName"].Value.ToString();
            string processID = Convert.ToInt32(e.NewEvent.Properties["ProcessID"].Value).ToString();


            Log(string.Format("Fechado: {0} as {1} {2}; Process ID:{3}", processName, DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), processID));

            //      Console.WriteLine("Process stopped. Name: " + processName + " | ID: " + processID);
        }

        static void Log(string log)
        {
            //   RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\AgenteColetor\\Configs", true);
            string nome_arquivo = //rkApp.GetValue("Caminho").ToString();
             "C:\\Teste\\arquivo.txt";
            if (!System.IO.File.Exists(nome_arquivo))
                System.IO.File.Create(nome_arquivo).Close();
            while (true)
            {
                try
                {
                    System.IO.TextWriter arquivo = System.IO.File.AppendText(nome_arquivo);
                    arquivo.WriteLine(log);
                    arquivo.Close();
                    break;
                }
                catch
                {

                }
            }

        }

    }
}
