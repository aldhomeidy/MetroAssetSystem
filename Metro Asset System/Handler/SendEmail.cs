using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Metro_Asset_System.Handler
{
    public class SendEmail
    {

        public void Send(string[] data)
        {
            var time24 = DateTime.Now.ToString("dd/MM/yy");


            MailMessage mm = new MailMessage("system@metroassets.com", data[0])
            {
                Subject = data[1] + " #" + time24,
                From = new MailAddress("system@metroassets.com","MetroAssets"),                
                Body = data[2],

                IsBodyHtml = true
            };
            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                EnableSsl = true
            };
            NetworkCredential NetworkCred = new NetworkCredential("aldhomeidy.bussiness@gmail.com", "ssss");
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = NetworkCred;
            smtp.Port = 587;
            smtp.Send(mm);
        }
    }
}
