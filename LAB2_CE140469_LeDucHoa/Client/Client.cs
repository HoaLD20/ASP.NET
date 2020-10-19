using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
/**
 * HoaLD
 */
namespace Client
{
    class Client
    {
        //getter and setter
        public string myIp { get; private set; }
        public int port { get; private set; }
        private TcpClient socketForServer;
        public bool clientStatus = true;

        public NetworkStream networkStream { get; set; }
        public StreamReader streamReader { get; set; }
        public StreamWriter streamWriter { get; set; }
        //contruster
        public Client(string myIp, int port)
        {
            this.myIp = myIp;
            this.port = port;
        }

        /**
         * Connect to Server with ip and port
         * return null
         */
        public void ConnectToServer()
        {
            try
            {
                //create connection with ip and port
                socketForServer = new TcpClient(myIp.ToString(), port);
            }
            catch
            {
                Console.WriteLine("Connect to server failure!!!");
                return;
            }
        }

        /**
         * Accept stream from server
         * 
         */
        public void serverData()
        {
            try
            {
                networkStream = socketForServer.GetStream();
                streamReader = new StreamReader(networkStream);
                streamWriter = new StreamWriter(networkStream);
            }
            catch
            {
                Console.WriteLine("Server error");
            }
            
        }

        /**
         * Disconenct from server
         */
        public void disconect()
        {
            streamWriter.Close();
            networkStream.Close();
            streamWriter.Close();
            socketForServer.Close();
        }
    }
}
