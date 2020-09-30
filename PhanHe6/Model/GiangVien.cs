using PhanHe6.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhanHe6.Model
{
    class GiangVien
    {
        private string maGV;
        private string tenGV;
        private int gioiTinhGV;
        private DateTime namSinhGV;
        private string trinhDoGV;
        private string emailGV;
        private string sdt;

        public GiangVien() { }

        public GiangVien(string maGV, string tenGV, int gioiTinhGV, DateTime namSinhGV, string trinhDoGV, string emailGV, string sdt)
        {
            this.MaGV = maGV;
            this.TenGV = tenGV;
            this.GioiTinhGV = gioiTinhGV;
            this.NamSinhGV = namSinhGV;
            this.TrinhDoGV = trinhDoGV;
            this.EmailGV = emailGV;
            this.Sdt = sdt;
        }

        public string MaGV { get => maGV; set => maGV = value; }
        public string TenGV { get => tenGV; set => tenGV = value; }
        public int GioiTinhGV { get => gioiTinhGV; set => gioiTinhGV = value; }
        public DateTime NamSinhGV { get => namSinhGV; set => namSinhGV = value; }
        public string TrinhDoGV { get => trinhDoGV; set => trinhDoGV = value; }
        public string EmailGV { get => emailGV; set => emailGV = value; }
        public string Sdt { get => sdt; set => sdt = value; }

        public override string ToString()
        {
            return MaGV + "$" + TenGV + "$" + GioiTinhGV + "$" + NamSinhGV + "$" + TrinhDoGV + "$" + EmailGV + "$" + Sdt;
        }

        public void input(List<GiangVien> listGiangVien)
        {
            Console.Write("Nhập mã số giảng viên: ");
            maGV = Validation.checkMaSoGV(listGiangVien);
            Console.Write("Nhập tên giảng viên: ");
            tenGV = Validation.checkTenGV();
            Console.Write("Nhập giới tính giảng viên (1: Nam, 2: Nữ): ");
            gioiTinhGV = Validation.checkGioiTinhGV();
            Console.Write("Nhập ngày tháng năm sinh giảng viên: ");
            namSinhGV = Validation.checkDOBGV();
            Console.Write("Nhập trình độ giảng viên: ");
            trinhDoGV = Validation.checkEmptyString();
            Console.Write("Nhập email giảng viên: ");
            emailGV = Validation.checkEmail();
            Console.Write("Nhập số điện thoại giảng viên: ");
            sdt = Validation.checkSdt();
            Console.WriteLine("Thông tin của giảng viên đã được thêm thành công");

        }

        public List<GiangVien> update(List<GiangVien> listGiangVien)
        {
            Console.Write("Nhập mã giảng viên cần thay đổi: ");
            maGV = Validation.checkMaSoGVUpdateAndDelete(listGiangVien);
            if (!String.IsNullOrEmpty(maGV))
            {
                int index = listGiangVien.FindIndex(x => x.MaGV.Equals(maGV));
                GiangVien obj = listGiangVien[index];

                Console.Write("Nhập tên giảng viên: ");
                obj.TenGV = Validation.checkTenGV();
                Console.Write("Nhập giới tính giảng viên (1: Nam, 2: Nữ): ");
                obj.GioiTinhGV = Validation.checkGioiTinhGV();
                Console.Write("Nhập ngày tháng năm sinh giảng viên: ");
                obj.NamSinhGV = Validation.checkDOBGV();
                Console.Write("Nhập trình độ giảng viên: ");
                obj.TrinhDoGV = Validation.checkEmptyString();
                Console.Write("Nhập email giảng viên: ");
                obj.EmailGV = Validation.checkEmail();
                Console.Write("Nhập số điện thoại giảng viên: ");
                obj.Sdt = Validation.checkSdt();
                listGiangVien[index] = obj;
                Console.WriteLine("Thông tin giảng viên đã được thay đổi thành công!");
            }
            else
            {
                Console.WriteLine("Mã giảng viên không tồn tại");
            }
            return listGiangVien;

        }

        public List<GiangVien> delete(List<GiangVien> listGiangVien)
        {
            Console.Write("Nhập mã giảng viên cần xoá: ");
            maGV = Validation.checkMaSoGVUpdateAndDelete(listGiangVien);
            if (!String.IsNullOrEmpty(maGV))
            {
                int index = listGiangVien.FindIndex(x => x.MaGV.Equals(maGV));
                GiangVien obj = listGiangVien[index];
                Console.WriteLine("Thông tin giảng viên mà bạn sắp xoá: ");
                obj.show();
                Console.Write("Bạn có chắc chắn muốn xoá môn học này (Y để xoá, kí tự khác để huỷ): ");
                String choice = Console.ReadLine();

                if (choice.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    listGiangVien.RemoveAt(index);
                    Console.WriteLine("Thông tin của giảng viên đã được xoá thành công.");
                }
                else
                {
                    Console.WriteLine("Huỷ thành công");
                }


            }
            else
            {
                Console.WriteLine("Mã giảng viên không tồn tại");
            }
            return listGiangVien;

        }

        public void show()
        {
            Console.WriteLine("Mã số giảng viên: {0}", MaGV);
            Console.WriteLine("Tên giảng viên: {0}", TenGV);
            Console.WriteLine("Giới tính giảng viên: {0}", GioiTinhGV==1?"Nam":"Nữ");
            Console.WriteLine("Năm sinh giảng viên: {0}", NamSinhGV.Year);
            Console.WriteLine("Trình độ giảng viên: {0}", TrinhDoGV);
            Console.WriteLine("Email giảng viên: {0}", EmailGV);
            Console.WriteLine("SĐT giảng viên: {0}", Sdt);
        }
    }
}
