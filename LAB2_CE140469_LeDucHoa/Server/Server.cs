using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
/**
 * HoaLD
 */
namespace Server
{
    class Server
    {
        //getter and setter
        public IPAddress myIp { get; private set; }
        public int port { get; private set; }
        public bool serverStatus { get; set; }
        private TcpListener tcpListener { get; set; }
        public Socket sockeForclient { get; private set; }

        public NetworkStream networkStream { get; set; }
        public StreamReader streamReader { get; set; }
        public StreamWriter streamWriter { get; set; }


        //constructor
        public Server(IPAddress myIp, int port)
        {
            serverStatus = true;
            this.myIp = myIp;
            this.port = port;
        }

        /**
         * listening for conenction
         * 
         */
        public void startListening()
        {
            try
            {
                //get ip and port
                tcpListener = new TcpListener(myIp, port);
                tcpListener.Start();
            }
            catch
            {
                Console.Write("Could start listening");
            }
        }

        /**
         * connect to client with ip and port
         * 
         */
        public void acceptClient()
        {
            try
            {
                sockeForclient = tcpListener.AcceptSocket();
            }
            catch
            {
                Console.WriteLine("Client Denied");
            }
        }


        //allows server to exchange data with the client
        public void clientData()
        {
            networkStream = new NetworkStream(sockeForclient);
            streamReader = new StreamReader(networkStream);
            streamWriter = new StreamWriter(networkStream);
        }

        /**
         * Close connection
         * 
         */
        public void disconect()
        {
            networkStream.Close();
            streamReader.Close();
            streamWriter.Close();
            sockeForclient.Close();
        }

    }
}
