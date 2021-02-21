using Metro_Asset_System.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.Content
{
    public class TransactionContent
    {
        private readonly SendEmail sendEmail = new SendEmail();

        public void Request(string[] identity, string[] requestData, string[,] listData)
        {
            var subject = "Request Notification";
            var email = identity[0];
            var message = "<h3>Hello " + identity[1] + ", </h3>";
            message += "<br><p>You have successed creating for loan request. Here is your details request:</p>";
            message += "<br><table>" +
                            "<tr>" +
                            "<th>Request Code</th>" +
                            "<td>#" + requestData[0] + "</td>" +
                            "</tr>" +
                            "<tr>" +
                            "<th>Request Date</th>" +
                            "<td>" + DateTime.Now.ToString("dd/MM/yyyy") + "</td>" +
                            "</tr>" +
                            "<tr>" +
                            "<th>From</th>" +
                            "<td>" + requestData[1] + "</td>" +
                            "</tr>" +
                            "<tr>" +
                            "<th>Until</th>" +
                            "<td>" + requestData[2] + "</td>" +
                            "</tr>";

            for (int i = 0; i < listData.Length - 2; i++)
            {
                if (i == 0)
                {
                    message += "<tr>" +
                      "<th>Items</th>" +
                      "<td>" + listData[i, 1] + " - #" + listData[i, 0] + "</td>" +
                      "</tr>";
                }
                else
                {
                    message += "<tr>" +
                           "<td></td>" +
                          "<td>" + listData[i, 1] + " - #" + listData[i, 0] + "</td>" +
                           "</tr>";
                }
            }

            message += "</table>";
            message += "<br><br><p>For your information, your request will be processed if you reach approval from Procurement Manager. So please wait until the Procurement Manager has approved your request.</p>";
            message += "<br><br>";
            message += "<p>Best Regards, <b>Metro Asset Staff</b></p>";


            var sendData = new[] { email, subject, message };
            sendEmail.Send(sendData);
        }
    }
}
