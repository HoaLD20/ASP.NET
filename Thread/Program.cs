using System;
using System.Threading;

namespace Thread2
{

    
    class Program
    {
        private static void Sometaskneed()
        {
            Console.WriteLine("waitting for thread");
            Thread.Sleep(5000);
                }

        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(Sometaskneed));
            thread.Start();
            thread.Join();//
            Console.WriteLine("task ok");
            Console.ReadLine();
        }
    }
}
