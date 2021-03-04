using Metro_Asset_System.Handler;
using Metro_Asset_System.Models;
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
            var subject = "[Request Notification]";
            var email = identity[0];
            var message = "<h3>Hello " + identity[1] + ", </h3>";
            message += "<br><p>You have successed creating for loan request. Here is your details request:</p>";
            message += "<br><table style='text-align:left;'>" +
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

            for (int i = 0; i < listData.Length/2; i++)
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

        public void ManageRequest(string[] identity, Request request) 
        {                    
            var subject = "";
            var email = identity[1];
            var message = "";
            var status = "";
            var role = "";

            if (identity[4] == "1") //jika manager level 1
            { 
                role = "Manager Level 1 (Your Manager)";
            }
            else {//manager level 2
                role = "Manager Level 2 (Procurement Manager)";
            }


            if (identity[2] == "1")
            {
                subject = "[Request Accepted]";
                status = "Accepted by "+role;
            }
            else
            {
                subject = "[Request Rejected]";
                status = "Rejected by " +role;
            }
            message = "<h3>Hello " + identity[0] + ", </h3>";

            if (identity[4] == "2" && identity[2]=="1")//manager level 2
            {
                message += "<br><p>Congratulations your request Has been approved by Procurement Manager. Now you can pick the assets in Procurement Office.</p>";
                message += "Tell your Request Code to the Procurement Staff while you picking up the asset. Here is your request detail : ";               
            }
            else //manager level 1
            {
                message += "<br><p>There is an update with your request. Here is the detail: </p>";
            }
            message += "<br><table style='text-align:left;'>" +
                            "<tr>" +
                            "<th>Request Code</th>" +
                            "<td>: #" + request.Id + "</td>" +
                            "</tr>" +
                            "<tr>" +
                            "<th>Start Date</th>" +
                            "<td>: " + request.LoanDate.ToString("dd/MM/yyyy") + "</td>" +
                            "</tr>" +
                            "<tr>" +
                            "<th>End Date</th>" +
                            "<td>: " + request.ReturnDate.ToString("dd/MM/yyyy") + "</td>" +
                            "</tr>" +
                            "<tr>" +
                            "<th>Requested at</th>" +
                            "<td>: " + request.RequestDate.ToString("dd/MM/yyyy") + "</td>" +
                            "</tr>" +
                            "<tr>" +
                            "<th>Status</th>" +
                            "<td>: " + status + "</td>" +
                            "</tr>" +
                            "<tr>" +
                            "<th>Notes</th>" +
                            "<td>: " + identity[3] + "</td>" +
                            "</tr>" +
                        "</table>";
            message += "<br><p>See more details by signing into MetroAssets System.</p>";
            message += "<br><p>Best Regards, <b>MetroAssets Staff</b></p><br>";

            //set email requerement
            var sendData= new[] { email, subject, message };
            sendEmail.Send(sendData);
        }

        public void Invoice(string[] identity, Invoice invoice)
        {
            //firstname, email, procurement staff name           
            var subject = "[Invoice]";
            var email = identity[1];
            var message = "";

            message = "<h3>Hello " + identity[0] + ", </h3>";
            message += "<br><p>Congratulations, your request has been processed and here is your invoice detail: </p>";
            message += "<br><table style='text-align:left;'>" +
                            "<tr>" +
                            "<th>Invoice Number</th>" +
                            "<td>: #" + invoice.Id + "</td>" +
                            "</tr>" +
                            "<tr>" +
                            "<th>Request Code</th>" +
                            "<td>: #" + invoice.RequestId + "</td>" +
                            "</tr>" +
                            "<tr>" +
                            "<th>Start Date</th>" +
                            "<td>: " + invoice.Request.LoanDate.ToString("dd/MM/yyyy") + "</td>" +
                            "</tr>" +
                            "<tr>" +
                            "<th>End Date</th>" +
                            "<td>: " + invoice.Request.ReturnDate.ToString("dd/MM/yyyy") + "</td>" +
                            "</tr>" +
                            "<tr>" +
                            "<th>Requested at</th>" +
                            "<td>: " + invoice.InvoiceDate.ToString("dd/MM/yyyy") + "</td>" +
                            "</tr>" +
                            "<tr>" +
                            "<th>Procurement Staff</th>" +
                            "<td>: " + identity[2] + "</td>" +
                            "</tr>" +
                        "</table>";
            message += "<br><p>Please keep the asset condition same as before and return it according to the agreement</p>";
            message += "<br><p>Best Regards, <b>MetroAssets Staff</b></p><br>";

            //set email requerement
            var sendData = new[] { email, subject, message };
            sendEmail.Send(sendData);
        }

        public void Return(Invoice invoice, string[,] pinalty, string totalPinalty)
        {            
            //list pinalty(Id asset, name, return conditions, pinalty)
            var subject = "[Invoice]";
            var email = invoice.Request.Employee.Email;
            var message = "";

            message = "<h3>Hello " + invoice.Request.Employee.FirstName + ", </h3>";
            message += "<p>You are success returning the assets. Here is your finished invoice detail : </p>";
            message += "<table style='text-align:left;'>" +
                            "<tr>" +
                            "<th>Invoice Number</th>" +
                            "<td>: #" + invoice.Id + "</td>" +
                            "</tr>" +
                            "<tr>" +
                            "<th>Request Code</th>" +
                            "<td>: #" + invoice.RequestId + "</td>" +
                            "</tr>" +
                            "<tr>" +
                            "<th>Start Date</th>" +
                            "<td>: " + invoice.Request.LoanDate.ToString("dd/MM/yyyy") + "</td>" +
                            "</tr>" +
                            "<tr>" +
                            "<th>End Date</th>" +
                            "<td>: " + invoice.Request.ReturnDate.ToString("dd/MM/yyyy") + "</td>" +
                            "</tr>" +
                        "</table>";
            message += "<br><table>" +
                          "<tr>" +
                          "<th colspan='4' style='text-align:center;'>Items</th>" +
                          "</tr>" +
                          "<tr>" +
                          "<th>Asset Id</th>" +
                          "<th>Name</th>" +
                          "<th>Return Conditions</th>" +
                          "<th>Pinalty</th>" +
                          "</tr>";
            for (int i = 0; i < pinalty.Length/4; i++) 
            {
                message += "<tr>" +
                          "<td>" + pinalty[i, 0] + "</td>" +
                          "<td>" + pinalty[i, 1] + "</td>" +
                          "<td>" + pinalty[i, 2] + "</td>" +
                          "<td>Rp " + pinalty[i, 3] + ",-</td>" +
                          "</tr>";
            }
            message += "<tr>" +
                       "<th colspan='3' style='text-align:right;'>Total Pinalty</th>" +
                       "<th>Rp " + totalPinalty + ",-</th>" +
                       "</tr>" +
                       "</table>";
            message += "<p>Thanks for using our service. If you have some pinalties with your invoices, any payment will be takeover with Payment Division.</p>";            
            message += "<p>Best Regards, <b>MetroAssets Staff</b></p><br>";

            //set email requerement
            var sendData = new[] { email, subject, message };
            sendEmail.Send(sendData);
        }
    }
}
