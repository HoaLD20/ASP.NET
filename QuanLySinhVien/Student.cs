using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien
{

    /**
     * Class nay de luu thong tin cua sinh vien
     */
    class Student
    {
        private string mssv;
        private string mangang;
        private string malop;
        private string hoten;
        private DateTime ngaysinh;
        private string gioitinh;
        private string diachi;
        private string sdt;

        public Student()
        {

        }
        public Student(string mssv, string mangang, string malop, string hoten, DateTime ngaysinh, string gioitinh, string diachi, string sdt)
        {
            this.mssv = mssv;
            this.mangang = mangang;
            this.malop = malop;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.sdt = sdt;
        }

        public string Mssv { get => mssv; set => mssv = value; }
        public string Mangang { get => mangang; set => mangang = value; }
        public string Malop { get => malop; set => malop = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
