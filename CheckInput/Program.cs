using System;
using System.Linq;

namespace CheckInput
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a number: ");
            num = Program.checkInt();
            Console.WriteLine("So m vua nhap: {0}", num);
        }

        public static int checkInt()
        {
            string num;
            
            while (true)
            {
                num = Console.ReadLine();
                if (!string.IsNullOrEmpty(num) && num.All(Char.IsDigit))
                {
                    //Console.WriteLine("so ban vua nhap la: {0}", num);

                    break;
                }
                else
                {
                    Console.Write("sai dinh dang gui, nhap lai di: ");
                }
            }
            return Convert.ToInt32(num);
        }
    }
}
