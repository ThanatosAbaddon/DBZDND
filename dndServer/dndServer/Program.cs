using System;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace dndServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting D&D save server");
            
            TcpListener server = null;

            try
            {
                //Start server
                server = new TcpListener(IPAddress.Parse("0.0.0.0"), 25000);
                server.Start();

                Byte[] bytes = new Byte[256];
                String data = null;

                //Listen loop
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();

                    StreamReader sr = new StreamReader(client.GetStream());

                    //Get file string
                    data = sr.ReadLine();


                    if (data.StartsWith("GET"))
                    {
                        //Get save file
                    } else
                    {
                        //Save, save file
                        System.IO.File.WriteAllText("test.txt", data);
                        Console.WriteLine("File saved from: " + client.Client.RemoteEndPoint.ToString());
                    }
                    
                    //Console.WriteLine(data);
                    
                    client.Close();
                }

            } catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            } finally
            {
                server.Stop();
            }
            
        }
    }
}
