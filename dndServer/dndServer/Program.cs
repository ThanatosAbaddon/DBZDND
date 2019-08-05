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
            TcpListener server = null;

            try
            {
                //Start server
                server = new TcpListener(IPAddress.Parse("0.0.0.0"), 25000);
                server.Start();
                
                Console.WriteLine("[" + DateTime.Now.ToString() + "] Started D&D save server");

                TcpClient client = null;

                //Listen loop
                while (true)
                {
                    try
                    {
                        //Create network client
                        client = server.AcceptTcpClient();

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
                            //Get file name
                            string fileName = fileString.Substring(4) + ".xml";

                            StreamWriter sw = new StreamWriter(client.GetStream());

                            //Send file
                            sw.WriteLine(System.IO.File.ReadAllText(fileName) + "\nEND");
                            sw.Flush();
                            Console.WriteLine("[" + DateTime.Now.ToString() + "] File, " + fileName + " sent to: " + client.Client.RemoteEndPoint.ToString());
                        }
                        else
                        {
                            //Get file name
                            string fileName = fileString.Substring(0, fileString.IndexOf("\n")) + ".xml";

                            //Save file
                            System.IO.File.WriteAllText(fileName, fileString);
                            Console.WriteLine("[" + DateTime.Now.ToString() + "] File, " + fileName + " saved from: " + client.Client.RemoteEndPoint.ToString());
                        }

                    }
                    catch (FileNotFoundException e)
                    {
                        Console.WriteLine("[" + DateTime.Now.ToString() + "] File not found: " + client.Client.RemoteEndPoint.ToString());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("[" + DateTime.Now.ToString() + "] " + e);
                    }
                    finally
                    {
                        client.Close();
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("[" + DateTime.Now.ToString() + "] " + e);
            }
            finally
            {
                server.Stop();
            }
        }
    }
}