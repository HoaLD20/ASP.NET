using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "File uploader client";
            Console.Write("Server ip: ");
            var ip = IPAddress.Parse(Console.ReadLine());
            var ep = new IPEndPoint(ip, 1308);

            while (true)
            {
                Console.Write("file > ");
                var path = Console.ReadLine();
                if (File.Exists(path))
                {
                    var fileName = Path.GetFileName(path);
                    var fileNameBytes = Encoding.UTF8.GetBytes(fileName);
                    var fStream = File.OpenRead(path);

                    var client = new TcpClient();
                    client.Connect(ep);
                    var nsStream = client.GetStream();
                    var writer = new BinaryWriter(nsStream);

                    writer.Write(fileNameBytes.Length);
                    writer.Write(fStream.Length);
                    writer.Write(fileNameBytes);
                    var size = 512;
                    var buffer = new byte[size];
                    var count = 0;
                    while (true)
                    {
                        count = fStream.Read(buffer, 0, size);
                        if (count == 0)
                        {
                            fStream.Close();
                            break;
                        }
                        nsStream.Write(buffer, 0, count);
                    }

                    nsStream.Flush();

                    var reader = new StreamReader(nsStream);
                    var response = reader.ReadLine();
                    Console.WriteLine(response);

                    client.Close();
                }
            }
        }
    }
}