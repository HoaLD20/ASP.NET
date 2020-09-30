using PhanHe6.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PhanHe6.Utilities
{
    class Validation
    {
        public static int checkChoice(int min, int max)
        {
            int choice; 
            string errorMessage = "Số phải nhập phải nằm trong khoảng từ " + min + " - " + max;
            while (true)
            {
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice < min || choice > max)
                    {
                        Console.WriteLine(errorMessage);
                        Console.Write("Vui lòng chọn lại chức năng: ");
                    }
                    else
                        return choice;
                }
                catch (Exception)
                {
                    Console.WriteLine(errorMessage);
                    Console.Write("Vui lòng chọn lại chức năng: ");
                }
            }
        }

        public static int checkPositiveNumber()
        {
            string errorMessage = "Số đã nhập phải lớn hơn 0.";
            int number;
            while (true)
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number < 0)
                    {
                        Console.WriteLine(errorMessage);
                        Console.Write("Vui lòng nhập lại: ");
                    }
                    else
                        return number;
                }
                catch (Exception)
                {
                    Console.WriteLine(errorMessage);
                    Console.Write("Vui lòng nhập lại: ");
                }
            }
            
        }

        public static string checkEmptyString()
        {
            string errorMessage = "Vui lòng không nhập chuỗi rỗng.";
            string s;
            while (true)
            {
                s = Console.ReadLine().Trim();
                if (String.IsNullOrEmpty(s))
                {
                    Console.WriteLine(errorMessage);
                    Console.Write("Vui lòng nhập lại: ");
                }
                else
                {
                    return s;
                }
            }
        }

        public static string checkIDMonHoc(List<MonHoc> listMonHoc)
        {
            string errorMessage = "ID môn học phải đúng format (PRF192)";
            while (true)
            {
                String s = Console.ReadLine().ToUpper();
                Regex regex = new Regex(@"^[A-Z]{3}[0-9]{3}$");
                if (regex.IsMatch(s))
                    if (!listMonHoc.Exists(x => x.Idmh == s))
                        return s;
                    else
                    {
                        Console.WriteLine("ID môn học đã tồn tại.");
                        Console.Write("Vui lòng nhập lại: ");
                    }
                        
                else
                {
                    Console.WriteLine(errorMessage);
                    Console.Write("Vui lòng nhập lại: ");
                }
            }
           
        }

        public static string checkIDMonHocUpdateAndDelete(List<MonHoc> listMonHoc)
        {
            string errorMessage = "ID môn học phải đúng format (PRF192)";
            while (true)
            {
                String s = Console.ReadLine().ToUpper();
                Regex regex = new Regex(@"^[A-Z]{3}[0-9]{3}$");
                if (regex.IsMatch(s))
                {
                    if (listMonHoc.Exists(x => x.Idmh.Equals(s)))
                    {
                        return s;
                    }
                        
                    else
                    {
                        return "";
                    }
                }
                   

                else
                {
                    Console.WriteLine(errorMessage);
                    Console.Write("Vui lòng nhập lại: ");
                }
            }

        }

        public static string checkMaHocKy()
        {
            string errorMessage = "Mã học kỳ phải đúng format (SPxx / SUxx / FAxx)";
            while (true)
            {
                String s = Console.ReadLine().ToUpper();
                Regex regex = new Regex(@"[SP|SU|FA][0-9]{2}$");
                if (regex.IsMatch(s))
                    return s;
                else
                {
                    Console.WriteLine(errorMessage);
                    Console.Write("Vui lòng nhập lại: ");
                }
            }
        }

        public static string checkMaSoGV(List<GiangVien> listGiangVien)
        {
            string errorMessage = "Mã số giảng viên phải đúng format (GVxxx)";
            while (true)
            {
                String s = Console.ReadLine().ToUpper();
                Regex regex = new Regex(@"^GV[0-9]{3}$");
                if (regex.IsMatch(s))
                    if (!listGiangVien.Exists(x => x.MaGV == s))
                        return s;
                    else
                    {
                        Console.WriteLine("Mã số giảng viên đã tồn tại.");
                        Console.Write("Vui lòng nhập lại: ");
                    }

                else
                {
                    Console.WriteLine(errorMessage);
                    Console.Write("Vui lòng nhập lại: ");
                }
            }
        }

        public static string checkMaSoGVUpdateAndDelete(List<GiangVien> listGiangVien)
        {
            string errorMessage = "Mã số giảng viên phải đúng format (GVxxx)";
            while (true)
            {
                String s = Console.ReadLine().ToUpper();
                Regex regex = new Regex(@"^GV[0-9]{3}$");
                if (regex.IsMatch(s))
                    if (listGiangVien.Exists(x => x.MaGV == s))
                        return s;
                    else
                    {
                        return "";
                    }

                else
                {
                    Console.WriteLine(errorMessage);
                    Console.Write("Vui lòng nhập lại: ");
                }
            }
        }

        public static string checkTenGV()
        {
            string errorMessage = "Chuỗi không được phép rỗng hoặc có chứa kí tự đặc biệt.";
            string s;
            while (true)
            {
                s = Console.ReadLine().Trim();
                Regex regex = new Regex(@"^[a-zA-Z]+$");
                if (String.IsNullOrEmpty(s) && regex.IsMatch(s))
                {
                    Console.WriteLine(errorMessage);
                    Console.Write("Vui lòng nhập lại: ");
                }
                else
                {
                    return s;
                }
            }
        }

        public static int checkGioiTinhGV()
        {
            string errorMessage = "Số đã nhập phải là 1 hoặc 2.";
            int number;
            while (true)
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number < 1 || number > 2 )
                    {
                        Console.WriteLine(errorMessage);
                        Console.Write("Vui lòng nhập lại: ");
                    }
                    else
                        return number;
                }
                catch (Exception)
                {
                    Console.WriteLine(errorMessage);
                    Console.Write("Vui lòng nhập lại: ");
                }
            }
        }

        public static DateTime checkDOBGV()
        {
            string errorMessage = "Chuỗi nhập phải có dạng dd/MM/yyyy và ngày phải tồn tại";
            DateTime dob;
            while (true)
            {
                string line = Console.ReadLine();
                try
                {
                    if (!DateTime.TryParseExact(line, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dob))
                    {
                        Console.WriteLine(errorMessage);
                        Console.Write("Vui lòng nhập lại: ");
                    }
                    else
                    {
                        return dob;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine(errorMessage);
                    Console.Write("Vui lòng nhập lại: ");
                }
            }
        }

        public static string checkEmail()
        {
            string errorMessage = "Email chưa đúng format (abc@abc.abc(.abc))";
            string s;
            while (true)
            {
                s = Console.ReadLine().Trim();
                Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                if (String.IsNullOrEmpty(s) || !regex.IsMatch(s))
                {
                    Console.WriteLine(errorMessage);
                    Console.Write("Vui lòng nhập lại: ");
                }
                else
                {
                    return s;
                }
            }
        }

        public static string checkSdt()
        {
            string errorMessage = "Số điện thoại chưa đúng format (0833361360 / +84833361360)";
            string s;
            while (true)
            {
                s = Console.ReadLine().Trim();
                Regex regex = new Regex(@"^(\+84|0[3|5|7|8|9])+([0-9]{8})$");
                if (String.IsNullOrEmpty(s) || !regex.IsMatch(s))
                {
                    Console.WriteLine(errorMessage);
                    Console.Write("Vui lòng nhập lại: ");
                }
                else
                {
                    return s;
                }
            }
        }

        public static string checkMssv(List<DiemSV> listDiemSV)
        {
            string errorMessage = "Mã số sinh viên phải đúng format (CExxxxxx)";
            while (true)
            {
                String s = Console.ReadLine().ToUpper();
                Regex regex = new Regex(@"^C[E|S|A]1[3-6][0-9]{4}$");
                if (regex.IsMatch(s))
                    if (!listDiemSV.Exists(x => x.Mssv == s))
                        return s;
                    else
                    {
                        Console.WriteLine("Mã số sinh viên đã tồn tại.");
                        Console.Write("Vui lòng nhập lại: ");
                    }

                else
                {
                    Console.WriteLine(errorMessage);
                    Console.Write("Vui lòng nhập lại: ");
                }
            }
        }

        public static string checkMssvUpdateAndDelete(List<DiemSV> listDiemSV)
        {
            string errorMessage = "Mã số sinh viên phải đúng format (CExxxxxx)";
            while (true)
            {
                String s = Console.ReadLine().ToUpper();
                Regex regex = new Regex(@"^C[E|S|A]1[3-6][0-9]{4}$");
                if (regex.IsMatch(s))
                    if (listDiemSV.Exists(x => x.Mssv == s))
                        return s;
                    else
                    {
                        return "";
                    }

                else
                {
                    Console.WriteLine(errorMessage);
                    Console.Write("Vui lòng nhập lại: ");
                }
            }
        }

        public static double checkDiem()
        {
            string errorMessage = "Số điểm đã nhập phải trong khoảng từ 0-10.";
            double number;
            while (true)
            {
                try
                {
                    number = Convert.ToDouble(Console.ReadLine());
                    if (number < 0 || number > 10)
                    {
                        Console.WriteLine(errorMessage);
                        Console.Write("Vui lòng nhập lại: ");
                    }
                    else
                        return number;
                }
                catch (Exception)
                {
                    Console.WriteLine(errorMessage);
                    Console.Write("Vui lòng nhập lại: ");
                }
            }

        }

    }
}
