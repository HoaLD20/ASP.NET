using PhanHe6.Utilities;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace PhanHe6.Model
{
    class MonHoc
    {
        private string idmh;
        private string ma_hk;
        private string tenMH;
        private int soTC;
        private int lyThuyet;
        private int thucHanh;

        public MonHoc() { }

        public MonHoc(string idmh, string ma_hk, string tenMH, int soTC, int lyThuyet, int thucHanh)
        {
            this.Idmh = idmh;
            this.Ma_hk = ma_hk;
            this.TenMH = tenMH;
            this.SoTC = soTC;
            this.LyThuyet = lyThuyet;
            this.ThucHanh = thucHanh;
        }

        public string Idmh { get => idmh; set => idmh = value; }
        public string Ma_hk { get => ma_hk; set => ma_hk = value; }
        public string TenMH { get => tenMH; set => tenMH = value; }
        public int SoTC { get => soTC; set => soTC = value; }
        public int LyThuyet { get => lyThuyet; set => lyThuyet = value; }
        public int ThucHanh { get => thucHanh; set => thucHanh = value; }

        public override string ToString()
        {
            return Idmh + "$" + Ma_hk + "$" + TenMH + "$" + SoTC + "$" + LyThuyet + "$" + ThucHanh;
        }

        public void show()
        {
            Console.WriteLine("ID môn học: {0}", Idmh);
            Console.WriteLine("Mã học kỳ: {0}", Ma_hk);
            Console.WriteLine("Tên môn học: {0}", TenMH);
            Console.WriteLine("Số tín chỉ: {0}", SoTC);
            Console.WriteLine("Số tiết lí thuyết: {0}", LyThuyet);
            Console.WriteLine("Số tiết thực hành: {0}", ThucHanh);
        }

        public void input(List<MonHoc> listMonHoc)
        {
            Console.WriteLine("Nhập thông tin môn học");
            Console.Write("Nhập ID môn học: ");
            idmh = Validation.checkIDMonHoc(listMonHoc);
            Console.Write("Nhập mã học kỳ: ");
            ma_hk = Validation.checkMaHocKy();
            Console.Write("Nhập tên môn học: ");
            tenMH = Validation.checkEmptyString();
            Console.Write("Nhập số tín chỉ: ");
            soTC = Validation.checkPositiveNumber();
            Console.Write("Nhập số tiết lí thuyết: ");
            lyThuyet = Validation.checkPositiveNumber();
            Console.Write("Nhập số tiết thực hành: ");
            thucHanh = Validation.checkPositiveNumber();
            Console.WriteLine("Thông tin môn học được thêm thành công");
        }

        /**
         * update mon hoc
         *
         */
        public List<MonHoc> update(List<MonHoc> listMonHoc)
        {
            Console.Write("Nhập ID môn học cần thay đổi: ");
            idmh = Validation.checkIDMonHocUpdateAndDelete(listMonHoc);
            if (!String.IsNullOrEmpty(idmh))
            {
                int index = listMonHoc.FindIndex(x => x.Idmh.Equals(idmh));
                MonHoc obj = listMonHoc[index];

                Console.Write("Nhập mã học kỳ: ");
                obj.Ma_hk = Validation.checkMaHocKy();
                Console.Write("Nhập tên môn học: ");
                obj.TenMH = Validation.checkEmptyString();
                Console.Write("Nhập số tín chỉ: ");
                obj.SoTC = Validation.checkPositiveNumber();
                Console.Write("Nhập số tiết lí thuyết: ");
                obj.LyThuyet = Validation.checkPositiveNumber();
                Console.Write("Nhập số tiết thực hành: ");
                obj.ThucHanh = Validation.checkPositiveNumber();
                listMonHoc[index] = obj;
                Console.WriteLine("Thông tin môn học đã được thay đổi thành công!");
            }
            else
            {
                Console.WriteLine("ID môn học không tồn tại");
            }
            return listMonHoc;
            
        }

        public List<MonHoc> delete(List<MonHoc> listMonHoc)
        {
            Console.Write("Nhập ID môn học cần xoá: ");
            idmh = Validation.checkIDMonHocUpdateAndDelete(listMonHoc);
            if (!String.IsNullOrEmpty(idmh))
            {
                int index = listMonHoc.FindIndex(x => x.Idmh.Equals(idmh));
                MonHoc obj = listMonHoc[index];
                Console.WriteLine("Thông tin môn học mà bạn sắp xoá: ");
                obj.show();
                Console.Write("Bạn có chắc chắn muốn xoá môn học này (Y để xoá, kí tự khác để huỷ): ");
                String choice = Console.ReadLine();

                if (choice.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    listMonHoc.RemoveAt(index);
                    Console.WriteLine("Thông tin của môn học đã được xoá thành công.");
                }
                else
                {
                    Console.WriteLine("Huỷ thành công");
                }
               
                
            }
            else
            {
                Console.WriteLine("ID môn học không tồn tại");
            }
            return listMonHoc;

        }
    }
}
