using System;
using System.Net;
using System.Threading;
/**
 * HoaLD
 */
namespace Server
{

    /**
     * Server
     */
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Server of Hoa";

            IPAddress myIp = IPAddress.Parse("192.168.254.1");
            Int32 port = 5000;
            Server server = new Server(myIp, port);


            server.startListening();
            Console.Write("Server Started ");

            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Waiting for connection");

            server.acceptClient();
            //Console.Clear();
            Console.WriteLine("Client Connected !!!");


            string messageFromClient = "";
    


            try
            {
                server.clientData();

                //Server online
                while (server.serverStatus)
                {
                    //Client connected
                    if (server.sockeForclient.Connected)
                    {
                        //expecting a message from the client
                        messageFromClient = server.streamReader.ReadLine();
                        Console.WriteLine("Client : " + messageFromClient);

                        if (messageFromClient == "0")
                        {
                            //when client wanna close connection
                            server.serverStatus = false;
                            server.streamReader.Close();
                            server.streamWriter.Close();
                            server.networkStream.Close();
                            return;
                        }
                        else
                        {
                            // Convert lower to upper text and sent to client automatic                         
                            String upperText = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(messageFromClient.ToUpper());
                            //messageToClient = Console.ReadLine();
                            server.streamWriter.WriteLine(upperText);
                            server.streamWriter.Flush();
                        }
                        
                    }
                }
                server.disconect();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }
    }
    
}
