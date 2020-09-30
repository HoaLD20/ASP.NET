using PhanHe6.Model;
using System;
using System.Collections.Generic;
using System.Text;
using PhanHe6.Utilities;

namespace PhanHe6.Management
{
    class MonHoc_Mgt
    {
        private static List<MonHoc> listMonHoc = new List<MonHoc>();

        public MonHoc_Mgt() { }

        public MonHoc_Mgt(List<MonHoc> listMonHoc)
        {
            this.ListMonHoc = listMonHoc;
        }

        internal List<MonHoc> ListMonHoc { get => listMonHoc; set => listMonHoc = value; }

        public static void menuMonHoc()
        {
            try
            {
                listMonHoc = Data.loadMonHoc();
            }
            catch (Exception)
            {

            }

            Console.WriteLine("\n======Menu quản lí môn học======");
            Console.WriteLine("1. Thêm đối tượng");
            Console.WriteLine("2. Sửa đối tượng");
            Console.WriteLine("3. Xoá đối tượng");
            Console.WriteLine("4. Xem danh sách");
            Console.WriteLine("5. Thoát");
            Console.Write("Vui lòng chọn chức năng: ");
            int choice = Validation.checkChoice(1, 5);
            performFunction(choice);
        }

        public static void performFunction(int choice)
        {
            switch (choice)
            {
                case 1:
                    input(listMonHoc);
                    menuMonHoc();
                    break;
                case 2:
                    update(listMonHoc);
                    menuMonHoc();
                    break;
                case 3:
                    delete(listMonHoc);
                    menuMonHoc();
                    break;
                case 4:
                    show();
                    menuMonHoc();
                    break;
                default:
                    break;

            }
        }

        public static void input(List<MonHoc> listMonHoc)
        {
            MonHoc obj = new MonHoc();
            obj.input(listMonHoc);
            listMonHoc.Add(obj);
            Data.saveMonHoc(listMonHoc);
        }

        public static void update(List<MonHoc> listMonHoc)
        {
            MonHoc obj = new MonHoc();
            listMonHoc = obj.update(listMonHoc);
            Data.saveMonHoc(listMonHoc);
        }

        public static void delete(List<MonHoc> listMonHoc)
        {
            MonHoc obj = new MonHoc();
            listMonHoc = obj.delete(listMonHoc);
            Data.saveMonHoc(listMonHoc);
        }

        public static void show()
        {
            Console.WriteLine();
            if (listMonHoc.Count == 0)
            {
                Console.WriteLine("Chưa có dữ liệu");
            }
            else
            {
                int count = 0;
                foreach (MonHoc obj in listMonHoc)
                {
                    Console.WriteLine("*** Môn học thứ {0}", count + 1); ;
                    obj.show();
                    count++;
                    Console.WriteLine();
                }
            }
           
        }
    }
}
