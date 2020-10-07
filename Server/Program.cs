using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class Program
    {
        static readonly string _home = @"D:\";
        static void Serve(TcpClient client)
        {

            var nsStream = client.GetStream();
            var reader = new BinaryReader(nsStream);

            var fileNameLength = reader.ReadInt32();
            var fileDataLength = reader.ReadInt64();
            var fileNameBytes = reader.ReadBytes(fileNameLength);
            var fileName = Encoding.UTF8.GetString(fileNameBytes);

            Console.WriteLine($"File to receive: {fileName}");
            Console.WriteLine($"Bytes to receive: {fileDataLength}");

            var path = Path.Combine(_home, fileName);
            var fStream = File.OpenWrite(path);

            var length = 0L;
            var size = 512;
            var buffer = new byte[size];
            while (length < fileDataLength)
            {
                var count = nsStream.Read(buffer, 0, size);
                fStream.Write(buffer, 0, count);
                length += count;
            }

            Console.WriteLine($"File saved as: {path}");
            Console.WriteLine($"Bytes received: {fStream.Length}");
            Console.WriteLine("-----------");

            fStream.Close();

            var writer = new StreamWriter(nsStream) { AutoFlush = true };
            writer.WriteLine("200 OK, Thank you!");

            client.Close();
        }

        static void Main(string[] args)
        {
            Console.Title = "File uploader server";
            var listener = new TcpListener(IPAddress.Any, 1308);
            listener.Start(10);

            while (true)
            {
                var client = listener.AcceptTcpClient();
                Serve(client);
            }
        }
    }
}