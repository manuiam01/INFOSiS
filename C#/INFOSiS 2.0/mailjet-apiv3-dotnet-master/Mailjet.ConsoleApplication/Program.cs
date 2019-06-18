using Mailjet.Client;
using Mailjet.Client.Resources;
using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;

namespace Mailjet.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().Wait();
        }

        static async Task RunAsync()
        {
            //MailjetClientHandler clientHandler = new MailjetClientHandler()
            //{
            //    Proxy = new DefaultProxy("http://127.0.0.1:8888"),
            //    UseProxy = true,
            //};

            //MailjetClient client = new MailjetClient(Environment.GetEnvironmentVariable("MJ_APIKEY_PUBLIC"), Environment.GetEnvironmentVariable("MJ_APIKEY_PRIVATE"), clientHandler)
            //{
            //    BaseAdress = "https://api.mailjet.com",
            //    Version = ApiVersion.V3,
            //};

            //IMailjetClient client = new MailjetClient(Environment.GetEnvironmentVariable("8ffda79638ed9ac9a06cac220695616a"), Environment.GetEnvironmentVariable("5755164c54ba040563629d68c62d2005"));

            //MailjetRequest request = new MailjetRequest
            //{
            //    Resource = Apikey.Resource,
            //};
            MailjetClient client = new MailjetClient(Environment.GetEnvironmentVariable("MJ_APIKEY_PUBLIC"), Environment.GetEnvironmentVariable("MJ_APIKEY_PRIVATE"))
            {
                Version = ApiVersion.V3_1,
            };
            MailjetRequest request = new MailjetRequest
            {
                Resource = Send.Resource,
            }
               .Property(Send.Messages, new JArray {
                new JObject {
                 {"From", new JObject {
                  {"Email", "jeremi.cardenas@pucp.pe"},
                  {"Name", "Mailjet Pilot"}
                  }},
                 {"To", new JArray {
                  new JObject {
                   {"Email", "jeremi.cardenas@pucp.pe"},
                   {"Name", "passenger 1"}
                   }
                  }},
                 {"Subject", "Your email flight plan!"},
                 {"TextPart", "Dear passenger 1, welcome to Mailjet! May the delivery force be with you!"},
                 {"HTMLPart", "<h3>Dear passenger 1, welcome to Mailjet!</h3><br />May the delivery force be with you!"}
                 }
                   });

            MailjetResponse response = await client.GetAsync(request);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(string.Format("Total: {0}, Count: {1}\n", response.GetTotal(), response.GetCount()));
                Console.WriteLine(response.GetData());
            }
            else
            {
                Console.WriteLine(string.Format("StatusCode: {0}\n", response.StatusCode));
                Console.WriteLine(string.Format("ErrorInfo: {0}\n", response.GetErrorInfo()));
                Console.WriteLine(string.Format("ErrorMessage: {0}\n", response.GetErrorMessage()));
            }

            Console.ReadLine();
        }
    }
}
