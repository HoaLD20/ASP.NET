using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;

namespace BaiThucHanhLab_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ProManager pm = new ProManager();
            
            while (true)
            {
                int exit = pm.Menu();
               
                switch (exit)
                {
                    case 1:
                        {
                            pm.EnterProduct();
                            break;
                        }
                    case 2:
                        {
                            pm.Output();
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
