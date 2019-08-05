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
                    //Create network client
                    TcpClient client = server.AcceptTcpClient();

                    StreamReader sr = new StreamReader(client.GetStream());
                    

                    string fileString = "";
                    //Recieve file
                    string line = sr.ReadLine();
                    while (line != "END")
                    {
                        fileString += line;
                        line = sr.ReadLine();

                        if (line != "END")
                        {
                            fileString += "\n";
                        }
                    }


                    if (fileString.StartsWith("GET"))
                    {
                        //Send file
                        fileString = fileString.Substring(4);


                        StreamWriter sw = new StreamWriter(client.GetStream());

                        sw.WriteLine(System.IO.File.ReadAllText(fileString + ".txt") + "\nEND");
                        sw.Flush();
                        Console.WriteLine("File, " + fileString + ".txt sent to: " + client.Client.RemoteEndPoint.ToString());
                    }
                    else
                    {
                        //Save file
                        System.IO.File.WriteAllText("test.txt", fileString);
                        Console.WriteLine("File saved from: " + client.Client.RemoteEndPoint.ToString());
                    }

                    client.Close();

                    Console.WriteLine(fileString);
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            catch
            {
                Console.WriteLine("Unknown Error");
            }
            finally
            {
                server.Stop();
            }
        }
    }
}
