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
            var time24 = DateTime.Now.ToString("ddMMyy");

            var message = "";
            message += "<img src='./ images / logo.jpg' alt='#' style='display: inline-block; max-width: 7%; margin-right: 10px;'>" +
                        "<div style =' display: inline-block;'>"+
                        "< h3 style ='margin: 0;' > METROASSETS </ h3 >"+
                              "< p style ='padding: 0;' > APL Tower, Podomoro City Jl.Let.Jend.S.Parman Kav. 28.Jakarta 11470 </ p >"+
                        "</div >"+
                        "< hr > ";
            message += data[2];

            MailMessage mm = new MailMessage("1997HelloWorld1997@gmail.com", data[0])
            {
                Subject = data[1] + " #" + time24,
                From = new MailAddress("system@metroassets.com","MetroAssets"),                
                Body = message,

                IsBodyHtml = true
            };
            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                EnableSsl = true
            };

            NetworkCredential NetworkCred = new NetworkCredential("aldhomeidy.bussiness@gmail.com", "almed276");
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = NetworkCred;
            smtp.Port = 587;
            smtp.Send(mm);
        }
    }
}
