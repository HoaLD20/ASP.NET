using System;
using System.Threading;
/**
 * HoaLD
 */
namespace Client
{

    /**
     * 
     * Client
     */
    class Program
    {
        static void Main(string[] args)
        {
            //title of client
            Console.Title = "Client ...";
            //ip
            string myIp = "192.168.254.1";
            //port
            int port = 5000;
            //create new client
            Client client = new Client(myIp, port);
            //conenct to server
            client.ConnectToServer();
            Console.Write("Connected to server");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Clear();
            //creat server thread
            client.serverData();
            try
            {
                string messageToServer = "";
                string messageFromServer = "";
                //while client online
                while (client.clientStatus)
                {
                    Console.Write("Client: ");
                    messageToServer = Console.ReadLine();

                    //client send 0 character
                    if (messageToServer == "0")
                    {
                        client.clientStatus = false;
                        client.streamWriter.WriteLine("Bye");
                        client.streamWriter.Flush();
                    }
                    else//text != 0
                    {
                        client.streamWriter.WriteLine(messageToServer);
                        client.streamWriter.Flush();
                        messageFromServer = client.streamReader.ReadLine();
                        Console.WriteLine("Server : " + messageFromServer);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error from Server");
            }

            client.disconect();
        }
    }
}
