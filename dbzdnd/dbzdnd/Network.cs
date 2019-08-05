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
                StreamWriter sw = new StreamWriter(client.GetStream());

                //Write save string here
                string fileString = "testFile\nIt Worked!\n3rd Line";

                //Send file
                sw.WriteLine(fileString + "\nEND");
                sw.Flush();

                Console.WriteLine("Saved");
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
        }

        public String Get(String name)
        {

            Console.WriteLine("Loading");
            try
            {
                //Create network client
                TcpClient client = new TcpClient(ip, port);
                StreamWriter sw = new StreamWriter(client.GetStream());
                StreamReader sr = new StreamReader(client.GetStream());

                //Send file
                sw.WriteLine("GET\n" + name + "\nEND");
                sw.Flush();


                string file = "";

                string line = sr.ReadLine();
                while (line != "END" && line != null)
                {
                    file += line;
                    line = sr.ReadLine();

                    if (line != "END" && line != null)
                    {
                        file += "\n";
                    }
                }

                Console.WriteLine(file);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }

            String fileString = null;
            return fileString;
        }
    }
}
