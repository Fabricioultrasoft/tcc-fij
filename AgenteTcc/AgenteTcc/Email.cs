using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace Agente
{
    public class Email
    {
        private MailMessage m;

        public Email()
        {
            m = new MailMessage();

            m.Sender = m.From = new MailAddress(
                      RegistryMemore.EmailRemetente
                );

            m.To.Add(RegistryMemore.EmailDestinatario);
            m.Subject = RegistryMemore.AssuntoEmail;
            m.Body = RegistryMemore.CorpoEmail;
            AnexarLog();
            m.IsBodyHtml = true;
        }

        Attachment a;
        private void AnexarLog()
        {
            a = new Attachment(RegistryMemore.DestinoLog);
         
            m.Attachments.Add(a);
           
        }

     
        public void Send()
        {
            try
            {
                SmtpClient sc = new SmtpClient();
                sc.Host = RegistryMemore.ServidorEmail;
                sc.DeliveryMethod = SmtpDeliveryMethod.Network;
                sc.UseDefaultCredentials = RegistryMemore.Ssl;
                sc.EnableSsl = RegistryMemore.Ssl;
                sc.Port = RegistryMemore.Smtp;
                sc.Credentials = new System.Net.NetworkCredential(
                       RegistryMemore.UsuarioEmail,
                       RegistryMemore.SenhaEmail
                );

                sc.Send(m);
                a.Dispose();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
