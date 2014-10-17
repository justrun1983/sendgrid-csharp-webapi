using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace SendGridDemo
{
    public class WebApiRestSharp
    {
        private const string ApiWebSite = "https://sendgrid.com";
        private const string ApiUrlAddress = "api/mail.send.json";

        public static void SendNormalHelloWorldEmail()
        {
            var client = new RestClient(ApiWebSite);
            var request = new RestRequest(ApiUrlAddress, Method.POST);
            request.AddParameter("api_user", Config.SendGridName);
            request.AddParameter("api_key", Config.SendGridPassword);
            request.AddParameter("to[]", Config.ToEmail);
            request.AddParameter("cc[]", Config.ToEmail);
            request.AddParameter("bcc[]", Config.ToEmail);
            request.AddParameter("subject", "Test");
            request.AddParameter("from", "test@test.me");
            request.AddParameter("text", "HelloWorld1");
            request.AddFile("files[2.txt]", @"C:\1.txt");

            // execute the request
            var response = client.Execute(request);
            var content = response.Content; // raw content as string
        }
    }
}
