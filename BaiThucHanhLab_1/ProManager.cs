using System;
using System.Collections.Generic;
using System.Text;

namespace BaiThucHanhLab_1
{
    class ProManager
    {
        public static int Input()
        {
            int choose;
            Console.WriteLine("----------MENU----------");
            Console.WriteLine("1.Input product.");
            Console.WriteLine("2.Show list product.");
            Console.WriteLine("0.Exit.");
            Console.Write("Please choose: ");
            choose = Console.Read();
            return choose;
        }
        public void enterProduct()
        {
            Console.Write("+ Enter number of product: ");
            int num = Console.Read();
            for (int i = 0; i < num; i++)
            {
                Product product = new Product();
                Console.WriteLine("-Product 1:");
                Console.Write("--Please enter id number: ");
                 product.IdPro = Console.ReadLine();
                Console.Write("--Please enter name:");
                product.NamePro = Console.ReadLine();
                Console.Write("--Please enter price: ");
                product.Price = Convert.ToDouble(Console.ReadLine());
                Console.Write("--Please enter quantity: ");
                product.Quantity = Convert.ToDouble(Console.ReadLine());

            }
        }
        public void Output()
        {
           

        }

       
    }
}
