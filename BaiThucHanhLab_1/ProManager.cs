using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
            int choose = ProManager.checkInt();
            return choose;
        }
        /*
         Nhập thông tin sản phẩm
         */
        public void EnterProduct()
        {
            //Nhập số lượng sp
            Console.Write("+ Enter number of product: ");
            int num = ProManager.checkInt();

            for (int i = 0; i < num; i++)
            {
                
                Product product = new Product();
                Console.WriteLine("-Product 1:");
                //nhập id sp
                Console.Write("\t--Please enter id number: ");
                product.IdPro = ProManager.checkid();
                //nhập tên sp
                Console.Write("\t--Please enter name:");
                product.NamePro = ProManager.checkname();
                //nhập giá sp
                Console.Write("\t--Please enter price: ");
                product.Price = ProManager.checkPrice();
                //nhập số lượng sp
                Console.Write("\t--Please enter quantity: ");
                product.Quantity = ProManager.checkquantity();
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
            Console.WriteLine("\t|ID\t|Name\t|Price\t|Quantity");
            foreach (Product pro in listPro)
            {
                Console.WriteLine("\t{0}\t{1}\t{2}\t{3}", pro.IdPro, pro.IdPro,
                    pro.Price, pro.Quantity);
                
            }

        }
        public static int checkInt()
        {
            string num;

            while (true)
            {
                num = Console.ReadLine();
                if (!string.IsNullOrEmpty(num) && num.All(Char.IsDigit))
                {
                    break;
                }
                else
                {
                    Console.Write("sai dinh dang gui, nhap lai di: ");
                }
            }
            return Convert.ToInt32(num);
        }

        public static string checkid()
        {
            string id;
            while (true)
            {
                id = Console.ReadLine().ToString();
                if (!string.IsNullOrEmpty(id) && id.Length == 5)
                {
                    string subID = id.Substring(0, 2);
                   
                    if (subID == "SP")
                    {
                        string subID_2 = id.Substring(Math.Max(2, 0));
                        
                        if (subID_2.All(Char.IsDigit))
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("Phan con lai la so moi dung!: ");
                        }
                    }
                    else
                    {
                        Console.Write("ki tu dau tien la SP nhap lai di: ");
                    }
                }
                else
                {
                    Console.Write("ko dc nhap null va do dai gom 5 ki tu: ");
                }
            }
            return id;
        }

        public static string checkname()
        {
            string name;

            while (true)
            {
                name = Console.ReadLine();
                if (!string.IsNullOrEmpty(name))
                {
                    break;
                }
                else
                {
                    Console.Write("sai dinh dang gui, nhap lai di: ");
                }
            }
            return name;
        }

        public static double checkPrice()
        {
            string price;
            double price2;
            while (true)
            {
                price = Console.ReadLine();
                if (!string.IsNullOrEmpty(price))
                {
                    try
                    {
                        price2 = Convert.ToDouble(price);
                        if (price2 >= 100)
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("Price more than 100. Enter again: ");
                        }
                    }
                    catch
                    {
                        Console.Write("Sai Dinh dang, nhap lai di: ");
                    }
                    
                }
                else
                {
                    Console.Write("Price can not null, must be number!: ");
                }
            }
            return price2;
        }


        public static double checkquantity()
        {
            string quan;
            double quan2;
            while (true)
            {
                quan = Console.ReadLine();
                if (!string.IsNullOrEmpty(quan) && quan.All(Char.IsDigit))
                {
                    try
                    {
                        quan2 = Convert.ToDouble(quan);
                        if (quan2 > 0 && quan2 < 100)
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("Quantity more than 0 and less than 100. Enter again: ");
                        }
                    }
                    catch
                    {
                        Console.Write("Sai Dinh dang, nhap lai di: ");
                    }
                    
                }
                else
                {
                    Console.Write("Quantity can not null, must be number!: ");
                }
            }
            return quan2;
        }


    }
}
