using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1_CE140469_LeDucHoa
{
    class S_Manager
    {
        public static ArrayList listSV = new ArrayList();
        /*
         * Hiển thị menu ra
         * return choicr from user
         */
        public int Menu()
        {
            Console.WriteLine("\n----------MENU----------");
            Console.WriteLine("1.Input Book Information.");
            Console.WriteLine("2.Show list book information.");
            Console.WriteLine("0.Exit and store data to file.");
            Console.Write("Please choose: ");
            int choose = S_Manager.checkInt();
            return choose;
        }
        /*
         Nhập thông tin sản phẩm
         */
        public void EnterBook()
        {
            //Nhập số lượng sp
            Console.Write("+ Enter number of book: ");
            int num = S_Manager.checkInt();

            for (int i = 0; i < num; i++)
            {

                Sach sach = new Sach();
                Console.WriteLine("-Book {0}:", i+1);
                //nhập id sach
                Console.Write("\t--Please enter id of book: ");
                sach.IdSach = S_Manager.checkid();
                //nhập tên sach
                Console.Write("\t--Please enter title of book:");
                sach.TieuDe = S_Manager.checkname();
                //nhập giá sach
                Console.Write("\t--Please enter publishing year: ");
                sach.NamXB = S_Manager.checkDateofBook();
                //nhập số lượng sp
                Console.Write("\t--Please enter price of book: ");
                sach.GiaTien = S_Manager.checkPrice();
                //thêm Sach vào arraylist
                listSV.Add(sach);
                Console.WriteLine("\nBook added success!");
            }
        }

        /**
         * check input menu
         * 
         */
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
                    Console.Write("Sai dinh dang gui, nhap lai di: ");
                }
            }
            return Convert.ToInt32(num);
        }

        /**
         * check id of book
         */
        public static string checkid()
        {
            string id;
            while (true)
            {
                id = Console.ReadLine().ToString();
                if (!string.IsNullOrEmpty(id) && id.Length == 6)
                {
                    string subID = id.Substring(0, 2);

                    if (subID == "TT" || subID == "TK")
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
                        Console.Write("Ki tu dau tien la TK hoac TT nhap lai di: ");
                    }
                }
                else
                {
                    Console.Write("Khong dc nhap null va do dai gom 6 ki tu: ");
                }
            }
            return id;
        }

        /**
         * check name of book
         */
        public static string checkname()
        {
            string name;

            while (true)
            {
                name = Console.ReadLine();
                if (!string.IsNullOrEmpty(name))
                {
                    if (name.Length >= 2 && name.Length <= 20)
                    {
                        break;
                    }
                }
                else
                {
                    Console.Write("Enter something... ");
                }
            }
            return name;
        }

        /**
         *check price of book
         * 
         */
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
                        if (price2 > 10000 && price2 < 100000)
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("Price > 10000 and < 100000: ");
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

        /**
         * check year
         * 
         */
        public static DateTime checkDateofBook()
        {

            int currenyear = 2020;
            string year; //input
            double year2; //processing year
            while (true)
            {
                year = Console.ReadLine();
                if (!string.IsNullOrEmpty(year))
                {
                    try
                    {
                        year2 = Convert.ToDouble(year);
                        if (year2 <= currenyear && year2 >= (currenyear - 5))
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("Books are imported from the past 5 years and not later than the current year: ");
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
            return DateTime.FromOADate(year2);
        }

        /**
         * load data from file
         * 
         */
        public static void loaddata()
        {
            string filePath = @"D:\HoaLD20\ASP.NET\Lab1_CE140469_LeDucHoa\data.txt";

            string[] lines;
            Console.WriteLine("===================List Student Information ===================");
            Console.WriteLine("\t|ID\t|Name   \t|Pubyear\t|Price");
            if (System.IO.File.Exists(filePath))
            {
                int count = 1;
                lines = System.IO.File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    Console.Write("\t" + lines[i]);
                    count += 1;
                    if (count == 5)
                    {
                        Console.WriteLine();
                        count = 0;
                    }
                }
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }

        /**
         * saave data to file
         */
        public static void savedata()
        {
          

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\HoaLD20\ASP.NET\Lab1_CE140469_LeDucHoa\data.txt", true))
            {
                string s = "";
                foreach (Sach sach in listSV)
                {
                    s += sach.IdSach + "\n" + sach.TieuDe.ToString() + "\n" + Convert.ToString(sach.NamXB) + "\n" + Convert.ToString(sach.GiaTien) + "\n";
                }
                file.WriteLine(s);
            }



        }
    }

}
