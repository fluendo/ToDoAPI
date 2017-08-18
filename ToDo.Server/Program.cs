using System;
using Microsoft.Owin.Hosting;
using System.Net.NetworkInformation;
using System.Net;

namespace TodoApi
{
    public class Program
    {
        protected static void Main(string[] args)
        {
            var port = 8080;
            var url = $"http://localhost:{port}";

            if (IsPortAvailable(port))
            {
                using (WebApp.Start<Startup>(url))
                {
                    Console.WriteLine($"Web Server is running at {url}.");
                    Console.WriteLine("Press any key to quit.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine($"The port {port} is being used by your system. Try with another port");
                Console.WriteLine("Press any key to quit.");
                Console.ReadLine();
            }


        }

        /// <summary>
        /// Check if the port is being used by the system
        /// </summary>
        /// <param name="port">TCP port</param>
        /// <returns></returns>
        private static bool IsPortAvailable(int port)
        {
            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] tcpListenersEndPoints = ipGlobalProperties.GetActiveTcpListeners();

            foreach (var tcpEp in tcpListenersEndPoints)
            {
                if (tcpEp.Port == port)
                    return false;
            }

            return true;
        }
    }
}

