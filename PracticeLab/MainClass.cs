using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLab
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            SV_Manager sV_Manager = new SV_Manager();

            while (true)
            {
                int exit = sV_Manager.Menu();

                switch (exit)
                {
                    case 1:
                        {
                            sV_Manager.EnterStudent();
                            break;
                        }
                    case 2:
                        {
                            sV_Manager.Output();
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("See you again <3.");
                            Console.WriteLine("\n\n\n-------------------------------END---------------------------------");
                            return;
                        }
                }

            }
        }
    }
}     
    

