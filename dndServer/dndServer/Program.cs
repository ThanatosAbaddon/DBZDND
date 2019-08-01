using System;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading.Tasks;

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
                

                //Listen loop
                while (true)
                {

                        TcpClient client = server.AcceptTcpClient();

                        StreamReader sr = new StreamReader(client.GetStream());

                        //Get file string

                        string fileString = null;

                        string data = "";
                        while (data != null)
                        {
                            //Console.WriteLine(data);
                            
                            var task = Task.Run(() => sr.ReadLine());
                                if (task.Wait(TimeSpan.FromMilliseconds(1000)))
                                {
                                    fileString += task.Result + "\n";

                                }
                                else
                                {
                                    data = null;
                                }
                        }

                        //client.Close();



                        if (fileString.StartsWith("GET"))
                        {
                            //Get save file
                        }
                        else
                        {
                            //Save, save file
                            System.IO.File.WriteAllText("test.txt", fileString);
                            Console.WriteLine("File saved from: " + client.Client.RemoteEndPoint.ToString());
                        }

                        Console.WriteLine(fileString);
                    
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
