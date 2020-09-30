using PhanHe6.Model;
using PhanHe6.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PhanHe6.Management
{
    class GiangVien_Mgt
    {
        private static List<GiangVien> listGiangVien = new List<GiangVien>();

        public GiangVien_Mgt() { }

        public GiangVien_Mgt(List<GiangVien> listGiangVien)
        {
            this.ListGiangVien = listGiangVien;
        }

        internal List<GiangVien> ListGiangVien { get => listGiangVien; set => listGiangVien = value; }

        public static void menuGiangVien()
        {
            try
            {
                listGiangVien = Data.loadGiangVien();
            }
            catch (Exception)
            {

            }

            Console.WriteLine("\n======Menu quản lí giảng viên======");
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
                    input(listGiangVien);
                    menuGiangVien();
                    break;
                case 2:
                    update(listGiangVien);
                    menuGiangVien();
                    break;
                case 3:
                    delete(listGiangVien);
                    menuGiangVien();
                    break;
                case 4:
                    show();
                    menuGiangVien();
                    break;
                default:
                    break;

            }

        }

        public static void show()
        {
            Console.WriteLine();
            if (listGiangVien.Count == 0)
            {
                Console.WriteLine("Chưa có dữ liệu");
            }
            else
            {
                int count = 0;
                foreach (GiangVien obj in listGiangVien)
                {
                    Console.WriteLine("*** Giảng viên thứ {0}", count + 1); ;
                    obj.show();
                    count++;
                    Console.WriteLine();
                }
            }
        }

        public static void input(List<GiangVien> listGiangVien)
        {
            GiangVien obj = new GiangVien();
            obj.input(listGiangVien);
            listGiangVien.Add(obj);
            Data.saveGiangVien(listGiangVien);
        }

        public static void update(List<GiangVien> listGiangVien)
        {
            GiangVien obj = new GiangVien();
            listGiangVien = obj.update(listGiangVien);
            Data.saveGiangVien(listGiangVien);
        }

        public static void delete(List<GiangVien> listGiangVien)
        {
            GiangVien obj = new GiangVien();
            listGiangVien = obj.delete(listGiangVien);
            Data.saveGiangVien(listGiangVien);
        }
    }
}
