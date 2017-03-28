using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace HttpsServer
{
    static class Server
    {
        static void StartListener()
        {
            var web = new HttpListener();
            web.Prefixes.Add("http://localhost:8080/");
            web.Prefixes.Add("https://*:8443/");
            // Console.WriteLine("Listening..");
            web.Start();
            // Console.WriteLine(web.GetContext());
            var context = web.GetContext();
            var response = context.Response;
            const string responseString = "<html><body>Hello world</body></html>";
            var buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
            response.ContentLength64 = buffer.Length;
            var output = response.OutputStream;
            output.Write(buffer, 0, buffer.Length);
           //  Console.WriteLine(output);
            output.Close();
            web.Stop();
            Console.ReadKey();
        }
    }
}
