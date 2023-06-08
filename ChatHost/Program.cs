using ChatClient.ServiceChat;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ChatHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(ServiceChat)))
            {
                host.Open();
                Console.WriteLine("Сервер запущен и работает.");
                Console.ReadLine();
            }
        }
    }

    class ServerResponse : IServerChatCallback
    {
        public void MsgCallback(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
