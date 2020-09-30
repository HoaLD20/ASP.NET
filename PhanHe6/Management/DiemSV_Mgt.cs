using PhanHe6.Model;
using PhanHe6.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhanHe6.Management
{
    class DiemSV_Mgt
    {
        //list diem sv
        private static List<DiemSV> listDiemSV = new List<DiemSV>();

        public DiemSV_Mgt() { }

        public DiemSV_Mgt(List<DiemSV> listDiemSV)
        {
            this.ListDiemSV = listDiemSV;
        }

        internal List<DiemSV> ListDiemSV { get => listDiemSV; set => listDiemSV = value; }

        static List<GiangVien> listGiangVien = new List<GiangVien>();
        static List<MonHoc> listMonHoc = new List<MonHoc>();

        public static void menuDiemSV()
        {
            try
            {
                listDiemSV.Clear();
                listDiemSV = Data.loadDiemSV();
            }
            catch (Exception)
            {
                Console.WriteLine("error try catch cua menudiem");
            }

            try
            {
                listGiangVien.Clear();
                listGiangVien = Data.loadGiangVien();
            }
            catch (Exception)
            {

                
            }

            try
            {
                listMonHoc.Clear();
                listMonHoc = Data.loadMonHoc();
            }
            catch (Exception)
            {


            }

            Console.WriteLine("\n======Menu quản lí điểm sinh viên======");
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
                    input(listDiemSV, listGiangVien, listMonHoc);
                    menuDiemSV();
                    break;
                case 2:
                    update(listDiemSV, listGiangVien, listMonHoc); ;
                    menuDiemSV();
                    break;
                case 3:
                    delete(listDiemSV);
                    menuDiemSV();
                    break;
                case 4:
                    show();
                    menuDiemSV();
                    break;
                default:
                    break;

            }

        }

        public static void show()
        {
            if (listDiemSV.Count == 0)
            {
                Console.WriteLine("Chưa có dữ liệu");
            }
            int count = 0;
            foreach (DiemSV obj in listDiemSV)
            {
                Console.WriteLine("*** Sinh viên thứ {0}", count + 1); ;
                obj.show();
                count++;
                Console.WriteLine();
            }
        }

        public static void input(List<DiemSV> listDiemSV, List<GiangVien> listGiangVien, List<MonHoc> listMonHoc)
        {
            DiemSV obj = new DiemSV();
            obj.input(listDiemSV, listGiangVien, listMonHoc);
            listDiemSV.Add(obj);
            Data.saveDiemSV(listDiemSV);
        }

        public static void update(List<DiemSV> listDiemSV, List<GiangVien> listGiangVien, List<MonHoc> listMonHoc)
        {
            DiemSV obj = new DiemSV();
            listDiemSV = obj.update(listDiemSV, listGiangVien, listMonHoc);
            Data.saveDiemSV(listDiemSV);

        }

        public static void delete(List<DiemSV> listDiemSV)
        {
            DiemSV obj = new DiemSV();
            listDiemSV = obj.delete(listDiemSV);
            Data.saveDiemSV(listDiemSV);
        }
    }
}
