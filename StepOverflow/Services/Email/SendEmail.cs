using System;
using System.Net.Mail;

namespace StepOverflow.Services.Email
{
    public static class SendEmail
    {
        public static void Send(string address, string mailSubject, string mailBody)
        {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(SOEmailAdresses.Management);
                    mail.To.Add(address);
                    mail.Subject = mailSubject;
                    mail.Body = $"<h1>{mailBody}</h1>";
                    mail.IsBodyHtml = true;
                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new System.Net.NetworkCredential(SOEmailAdresses.Management, "Arif123!");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }
            }
            
        }
    }
