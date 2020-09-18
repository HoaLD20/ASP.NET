using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BaiThucHanhLab_1
{
    class ProManager
    {    
        public ArrayList listPro = new ArrayList();
        public int Menu()
        {          
            Console.WriteLine("----------MENU----------");
            Console.WriteLine("1.Input product.");
            Console.WriteLine("2.Show list product.");
            Console.WriteLine("0.Exit.");
            Console.Write("Please choose: ");
            int choose = checkIntMenu();
            return choose;
        }
        public void EnterProduct()
        {
            Console.Write("+ Enter number of product: ");
            int num = checkInt();

            for (int i = 0; i < num; i++)
            {
                Product product = new Product();
                Console.WriteLine("-Product 1:");

                Console.Write("\t--Please enter id number: ");
                product.IdPro = Convert.ToString(checkID());


                Console.Write("\t--Please enter name:");
                product.NamePro = Console.ReadLine();
                Console.Write("\t--Please enter price: ");
                product.Price = Convert.ToDouble(Console.ReadLine());
                Console.Write("\t--Please enter quantity: ");
                product.Quantity = Convert.ToDouble(Console.ReadLine());


                listPro.Add(product);
                Console.WriteLine("\n\tProduct added success!");
            }
        }
        public void Output()
        {
            Console.WriteLine("===================List Product ===================");
            Console.WriteLine("|ID\t|Name|\tPrice\t|Quantity");
            foreach (Product pro in listPro)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", pro.IdPro, pro.IdPro,
                    pro.Price, pro.Quantity);
                
            }

        }
       
        public static int checkIntMenu()
        {
            int num;
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 0 || num > 2)
                {
                    Console.WriteLine("Invalid Input!");
                }
                else
                {
                    return num;
                } 
            }catch
            {
                Console.WriteLine("Invalid Input! ex");
            }
            return 5;
        }

        public static int checkInt()
        {
            int num;
            try
            {
                while (true)
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num <= 0)
                    {
                        Console.Write("Invalid Input! Enter again: ");
                    }
                    else
                    {
                        break;
                    }
                }
                return num;
            }
            catch 
            {
                Console.Write("Invalid Input ex! Enter again: ");
            }
            return 5;
            
        }

        public string checkID()
        {
            string id;
            Boolean check = true;
            
            while (check)
            {
                try
                {
                    id = Convert.ToString(Console.ReadLine());


                    if (id != null)
                    {
                        if (!id[0].Equals("S") && !id[1].Equals("P"))
                        {
                            Console.Write("Erorr! Please id number again (SPxxx): ");

                        }
                        else
                        {
                            check = false;
                            return id;

                        }
                    }
                    

                }
                catch
                {
                    Console.Write("Erorr! Please id number again (SPxxx): ");

                }

            }
            return id;
        }


    }
}
