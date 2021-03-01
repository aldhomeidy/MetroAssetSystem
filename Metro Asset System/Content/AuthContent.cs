using Metro_Asset_System.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.Content
{
    public class AuthContent
    {
        private readonly SendEmail sendEmail = new SendEmail();

        public void Register(string[] data)
        {

            var verifyUrl = "https://localhost:44342/Auth/Verify/" + data[0];
            var subject = "[Verification]";
            var email = data[1];
            var message = "<h3>Hello " + data[2] + ", </h3>";
            message += "<br><p>Your MetroAssets Account has been created. Please verificate your email first before using the system.</p>";
            message += "<br><p>Just click link down bellow : </p>";
            message += "<br><a href=" + verifyUrl + ">" + verifyUrl + "<a/>";
            message += "<br><br>";
            message += "<p>Best Regards, <b>Metro Asset Staff</b></p>";

            var sendData = new[] { email, subject, message };
            sendEmail.Send(sendData);
        }

        public void ForgetPassword(string[] data)
        {
            var subject = "[Reset Password]";
            var email = data[0];
            var message = "<h3>Hello " + data[1] + ", </h3>";
            message += "<p>Your password has been successfully reseted.</p>";
            message += "<p>Here is your new password : <b>" + data[2] + "</b></p>";
            message += "<p>Please don't tell anyone about your new password, including all Metro Assets Staff</p>";
            message += "<br><p>Best Regards, <b>Metro Asset Staff</b></p>";

            var sendData = new[] { email, subject, message };
            sendEmail.Send(sendData);
        }
    }
}
