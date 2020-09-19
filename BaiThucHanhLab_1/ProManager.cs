using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BaiThucHanhLab_1
{
    class ProManager
    {    
        public ArrayList listPro = new ArrayList();
        /*
         Hiển thị menu ra
         */
        public int Menu()
        {          
            Console.WriteLine("----------MENU----------");
            Console.WriteLine("1.Input product.");
            Console.WriteLine("2.Show list product.");
            Console.WriteLine("0.Exit.");
            Console.Write("Please choose: ");
            int choose = Convert.ToInt32(Console.ReadLine());
            return choose;
        }
        /*
         Nhập thông tin sản phẩm
         */
        public void EnterProduct()
        {
            //Nhập số lượng sp
            Console.Write("+ Enter number of product: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                
                Product product = new Product();
                Console.WriteLine("-Product 1:");
                //nhập id sp
                Console.Write("\t--Please enter id number: ");
                product.IdPro = Convert.ToString(checkID());
                //nhập tên sp
                Console.Write("\t--Please enter name:");
                product.NamePro = Console.ReadLine();
                //nhập giá sp
                Console.Write("\t--Please enter price: ");
                product.Price = Convert.ToDouble(Console.ReadLine());
                //nhập số lượng sp
                Console.Write("\t--Please enter quantity: ");
                product.Quantity = Convert.ToDouble(Console.ReadLine());
                //thêm sp vào arraylist
                listPro.Add(product);
                Console.WriteLine("\n\tProduct added success!");
            }
        }
        /*
         Hiển thị danh sách sản phẩm
         */
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
        /*
         Kiểm tra id sản phẩm
         */
        public string checkID()
        {
            /*
             Include 5 character, the 2 first character is “SP” and 3 digits
             */
            string id;
            while (true)
            {
                try
                {
                    id = Console.ReadLine();
                    if(id.Length == 5)
                    {

                    }
                }
                catch
                {
                    Console.Write("id can not be null! Enter again: ");
                    id = Console.ReadLine();

                }

            }
            return id;
        }
        /*
        public string checkName()
        {

        }
        public int checkPrice()
        {

        }
        public int checkQuan()
        {

        }
        */
    }
}
