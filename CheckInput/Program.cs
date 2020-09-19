using System;
using System.Linq;

namespace CheckInput
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string id;
            string name;
            int price;
            int quan;

            Console.Write("Enter a number: ");
            num = Program.checkInt();
            Console.WriteLine("So m vua nhap: {0}", num);

            Console.Write("Enter id: ");
            id = Program.checkid();
            Console.WriteLine("id vua nhap la: {0}", id);

            Console.Write("Enter your name: ");
            name = Program.checkname();
            Console.Write("ten cua ban la: {0}", name);

            Console.Write("Enter price: ");
            price = Program.checkPrice();
            Console.Write("gia ban nhap la: {0}", price);

            Console.Write("Enter quantity: ");
            quan = Program.checkquantity();
            Console.Write("So luong ban nhap la: {0}", quan);

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
                    Console.WriteLine(subID);
                    if (subID == "SP")
                    {
                        string subID_2 = id.Substring(Math.Max(2, 0));
                        Console.WriteLine(subID_2);
                        if(subID_2.All(Char.IsDigit))
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

        public static int checkPrice()
        {
            string price;
            int price2;
            while (true)
            {
                price = Console.ReadLine();
                if(!string.IsNullOrEmpty(price) && price.All(Char.IsDigit))
                {
                    price2= Convert.ToInt32(price);
                    if(price2 <= 100)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Price more than 0 and less than 100. Enter again: ");
                    }
                }
                else
                {
                    Console.Write("Price can not null, must be number!: ");
                }
            }
            return price2;
        }


        public static int checkquantity()
        {
            string quan;
            int quan2;
            while (true)
            {
                quan = Console.ReadLine();
                if (!string.IsNullOrEmpty(quan) && quan.All(Char.IsDigit))
                {
                    quan2 = Convert.ToInt32(quan);
                    if (quan2 > 0 && quan2 < 100)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Price more than 0 and less than 100. Enter again: ");
                    }
                }
                else
                {
                    Console.Write("Price can not null, must be number!: ");
                }
            }
            return quan2;
        }

    }
}
