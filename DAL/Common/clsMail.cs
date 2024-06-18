using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace DAL
{
    public class clsMail
    {
        public static void SendMail(string subject, string body, string To, string CC, string BCC, string[] file)
        {
            try
            {
                string Email = ConfigurationSettings.AppSettings["Email"];
                string Password = ConfigurationSettings.AppSettings["Password"];
                string Port = ConfigurationSettings.AppSettings["Port"];
                string host = ConfigurationSettings.AppSettings["Host"];
                string SSL = ConfigurationSettings.AppSettings["SSL"];
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(host, int.Parse(Port));

                mail.From = new MailAddress(Email);
                mail.To.Add(To);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;
                if (file != null)
                    if (file.Length > 0)
                    {
                        foreach (var item in file)
                        {
                            if (item != null)
                                if (item != "")
                                    mail.Attachments.Add(new Attachment(item));
                        }

                    }
                if (CC != "")
                    foreach (var item in CC.Split(','))
                    {
                        mail.CC.Add(item);
                    }
                if (BCC != "")
                    foreach (var item in BCC.Split(','))
                    {
                        mail.Bcc.Add(item);
                    }
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential(Email, Password);
                //SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                clsLogger.ErrorLog("Send Mail", ex);
            }
        }



        public static void SendRefundMail(string subject, string body, string To, string CC, string BCC, string[] file)
        {
            try
            {
                string Email = ConfigurationManager.AppSettings["refund_Email"];
                string Password = ConfigurationManager.AppSettings["refund_EmailPassword"];
                string Port = ConfigurationManager.AppSettings["refund_Port"];
                string host = ConfigurationManager.AppSettings["refund_Host"];

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(host, int.Parse(Port));

                mail.From = new MailAddress(Email);
                mail.To.Add(To);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;
                if (file != null)
                    if (file.Length > 0)
                    {
                        foreach (var item in file)
                        {
                            if (item != null)
                                if (item != "")
                                    mail.Attachments.Add(new Attachment(item));
                        }

                    }
                if (CC != "")
                    foreach (var item in CC.Split(','))
                    {
                        mail.CC.Add(item);
                    }
                if (BCC != "")
                    foreach (var item in BCC.Split(','))
                    {
                        mail.Bcc.Add(item);
                    }
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential(Email, Password);
               // SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                clsLogger.ErrorLog("Send Refund Mail", ex);
            }
        }

   


    }
}
