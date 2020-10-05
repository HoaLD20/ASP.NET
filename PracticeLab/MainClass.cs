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
                            SV_Manager.loaddata();
                            break;
                        }
                    case 0:
                        {
                            SV_Manager.savedata();
                            Console.WriteLine("All data stored.");
                            return;
                        }
                }
            }
        }
    }
}     
    

