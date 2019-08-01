using System;
using System.IO;
using System.Net.Sockets;

namespace dbzdnd
{
    public class Network
    {
        private readonly string ip;
        private readonly int port;

        public Network(string ip, int port)
        {
            this.ip = ip;
            this.port = port;
        }

        public void Save()
        {
            Console.WriteLine("Auto Saving");
            try
            {
                //Create network client
                TcpClient client = new TcpClient(ip, port);
                StreamWriter sr = new StreamWriter(client.GetStream());

                //Write save string here
                sr.WriteLine("It Worked!");
                sr.Flush();

                Console.WriteLine("Saved");
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
        }
    }
}
