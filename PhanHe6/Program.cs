using PhanHe6.Management;
using PhanHe6.Utilities;
using System;
using System.Text;

namespace PhanHe6
{
    class Program
    {
        public static void menu()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("-------------Menu quản lí-------------");
            Console.WriteLine("1. Quản lí điểm sinh viên");
            Console.WriteLine("2. Quản lí giảng viên");
            Console.WriteLine("3. Quản lí môn học");
            Console.WriteLine("4. Thoát");
            Console.Write("Vui lòng chọn chức năng: ");
            int choice = Validation.checkChoice(1, 4);
            performFunction(choice);
        }

        public static void performFunction(int choice)
        {   
            switch (choice)
            {
                case 1:
                    DiemSV_Mgt.menuDiemSV();
                    Console.WriteLine();
                    menu();
                    break;
                case 2:
                    GiangVien_Mgt.menuGiangVien();
                    Console.WriteLine();
                    menu();
                    break;
                case 3:
                    MonHoc_Mgt.menuMonHoc();
                    Console.WriteLine();
                    menu();
                    break;
                default:
                    break;
            }
            
        }
        static void Main(string[] args)
        {
            menu();
            
        }
    }
}
