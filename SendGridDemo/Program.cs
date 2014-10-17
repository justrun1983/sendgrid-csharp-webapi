using System.Net;
using System.Net.Mail;
using SendGrid;


namespace SendGridDemo
{
    class Program
    {
        private static void Main(string[] args)
        {
            WebApiLib.SendNormalHelloWorldEmail();
            WebApiLib.SendEmailWithAttachement();
            WebApiRestSharp.SendNormalHelloWorldEmail();
        }
    }
}
