using System.Net;
using System.Net.Mail;
using SendGrid;

namespace SendGridDemo
{
    public static class WebApiLib
    {
        public static void SendNormalHelloWorldEmail()
        {
            // Create the email object first, then add the properties.
            var myMessage = new SendGridMessage();
            myMessage.AddTo(Config.ToEmail);
            myMessage.From = new MailAddress("john@eassist.me", "John Smith");
            myMessage.Subject = "Testing the SendGrid Library";
            myMessage.Text = "Hello World!";

            // Create credentials, specifying your user name and password.
            var credentials = new NetworkCredential(Config.SendGridName, Config.SendGridPassword);

            // Create an Web transport for sending email.
            var transportWeb = new Web(credentials);

            // Send the email.
            transportWeb.Deliver(myMessage);
        }

        public static void SendEmailWithAttachement()
        {
            // Create the email object first, then add the properties.
            var myMessage = new SendGridMessage();
            myMessage.AddTo(Config.ToEmail);
            myMessage.From = new MailAddress("john@eassist.me", "John Smith");
            myMessage.Subject = "Testing the SendGrid Library";
            myMessage.Text = "Hello World!";
            myMessage.AddAttachment(@"c:\1.txt");

            // Create credentials, specifying your user name and password.
            var credentials = new NetworkCredential(Config.SendGridName, Config.SendGridPassword);

            // Create an Web transport for sending email.
            var transportWeb = new Web(credentials);

            // Send the email.
            transportWeb.Deliver(myMessage);
        }
    }
}
