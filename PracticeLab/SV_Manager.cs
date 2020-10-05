using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticeLab
{
    class SV_Manager
    {
        public ArrayList listPro = new ArrayList();
        /*
         * Hiển thị menu ra
         * return choicr from user
         */
        public int Menu()
        {
            Console.WriteLine("----------MENU----------");
            Console.WriteLine("1.Input Student Information.");
            Console.WriteLine("2.Show list student information.");
            Console.WriteLine("0.Exit and store data to file.");
            Console.Write("Please choose: ");
            int choose = SV_Manager.checkInt();
            return choose;
        }
        /*
         Nhập thông tin sản phẩm
         */
        public void EnterStudent()
        {
            //Nhập số lượng sp
            Console.Write("+ Enter number of student: ");
            int num = SV_Manager.checkInt();

            for (int i = 0; i < num; i++)
            {

                SinhVien sinhvien = new SinhVien();
                Console.WriteLine("-Student 1:");
                //nhập id sp
                Console.Write("\t--Please enter id number: ");
                sinhvien.Id1 = SV_Manager.checkid();
                //nhập tên sp
                Console.Write("\t--Please enter name:");
                sinhvien.Name1 = SV_Manager.checkname();
                //nhập giá sp
                Console.Write("\t--Please enter date of birth(mm/dd/yyy): ");
                sinhvien.NamSinh1 = SV_Manager.checkDateofBirth();
                //nhập số lượng sp
                Console.Write("\t--Please enter mark: ");
                sinhvien.Diem1 = SV_Manager.checkMark();
                //thêm SV vào arraylist
                listPro.Add(sinhvien);
                Console.WriteLine("\nStudent added success!");
            }
        }
        /*
         Hiển thị danh sách sinh viên
         */
        public void Output()
        {
            Console.WriteLine("===================List Student Information ===================");
            Console.WriteLine("\t|ID\t|Name\t|Date of birth\t|Mark");
            foreach (SinhVien sv in listPro)
            {
                Console.WriteLine("\t{0}\t{1}\t{2}\t{3}", sv.Id1, sv.Name1,
                    sv.NamSinh1, sv.Diem1);

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
                    Console.Write("Sai dinh dang gui, nhap lai di: ");
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
                if (!string.IsNullOrEmpty(id) && id.Length == 8)
                {
                    string subID = id.Substring(0, 2);

                    if (subID == "CE")
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
                        Console.Write("Ki tu dau tien la CE nhap lai di: ");
                    }
                }
                else
                {
                    Console.Write("Khong dc nhap null va do dai gom 8 ki tu: ");
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
                    Console.Write("Enter something... ");
                }
            }
            return name;
        }

        public static double checkMark()
        {
            string diem;
            double diem2;
            while (true)
            {
                diem = Console.ReadLine();
                if (!string.IsNullOrEmpty(diem))
                {
                    try
                    {
                        diem2 = Convert.ToDouble(diem);
                        if (diem2 >= 0 && diem2 <= 10)
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("Mark from 0 to 10: ");
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
            return diem2;
        }

        public static DateTime checkDateofBirth()
        {
            while (true)
            {
                string inputdate;
                DateTime dDate;
                inputdate = SV_Manager.checkname();
                
                if (DateTime.TryParse(inputdate, out dDate))
                {
                    String.Format("{0:dd/MM/yyyy}", dDate);
                    return dDate;
                }
                else
                {
                    Console.Write("Enter again (mm/dd/YYYY): ");
                }
                
            }

           
        }

    }
}
