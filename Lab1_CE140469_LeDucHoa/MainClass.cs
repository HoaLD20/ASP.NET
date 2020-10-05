using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_CE140469_LeDucHoa
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //tao moi doi duong quan li sach
            S_Manager sV_Manager = new S_Manager();

            while (true)
            {
                //choice from user
                int exit = sV_Manager.Menu();

                switch (exit)
                {
                    case 1:
                        {
                            //enter book
                            sV_Manager.EnterBook();
                            break;
                        }
                    case 2:
                        {
                            //load data from filr
                            S_Manager.loaddata();
                            break;
                        }
                    case 0:
                        {
                            //save file to data
                            S_Manager.savedata();
                            Console.WriteLine("All data stored.");
                            return;
                        }
                }
            }
        }
    }
}
