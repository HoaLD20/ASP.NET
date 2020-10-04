using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Server1
{
    class Program
    {
        private IPAddress myip;
        private int port;
        private bool serverStatus;
        private TcpListener tcpListener;
        private Socket socketforserver;
        private NetworkStream networkStream;
        private StreamWriter streamWriter;

        public IPAddress Myip { get => myip; set => myip = value; }
        public int Port { get => port; set => port = value; }
        public bool ServerStatus { get => serverStatus; set => serverStatus = value; }
        public TcpListener TcpListener { get => tcpListener; set => tcpListener = value; }
        public Socket Socketforserver { get => socketforserver; set => socketforserver = value; }
        public NetworkStream NetworkStream { get => networkStream; set => networkStream = value; }
        public StreamWriter StreamWriter { get => streamWriter; set => streamWriter = value; }

        public Program()
        {
        }
        /*
        public Program(IPAddress myip, int port, bool serverStatus, TcpListener tcpListener, Socket socketClient, NetworkStream networkStream, StreamWriter streamWriter)
        {
            this.Myip = myip;
            this.Port = port;
            this.ServerStatus = serverStatus;
            this.TcpListener = tcpListener;
            this.SocketClient = socketClient;
            this.NetworkStream = networkStream;
            this.StreamWriter = streamWriter;
        }
        */

        public Program(IPAddress myip, int port)
        {
            ServerStatus = true;
            this.myip = myip;
            this.port = port;
        }

        public void startListener()
        {
            try
            {
                socketforserver = new TcpListener(Myip, Port);
                tcpListener.Start();
            }
            catch
            {

            }
        }


    }
}
