using PhanHe6.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhanHe6.Model
{
    class DiemSV
    {
        private string mssv;
        private string idmh;
        private string maGV;
        private string ma_hk;
        private double diemLan1;
        private double diemLan2;
        private double diemTichLuy;
        private string diemChu;

        public DiemSV() { }

        public DiemSV(string mssv, string idmh, string maGV, string ma_hk, double diemLan1, double diemLan2, double diemTichLuy, string diemChu)
        {
            this.Mssv = mssv;
            this.Idmh = idmh;
            this.MaGV = maGV;
            this.Ma_hk = ma_hk;
            this.DiemLan1 = diemLan1;
            this.DiemLan2 = diemLan2;
            this.DiemTichLuy = diemTichLuy;
            this.DiemChu = diemChu;
        }

        public string Mssv { get => mssv; set => mssv = value; }
        public string Idmh { get => idmh; set => idmh = value; }
        public string MaGV { get => maGV; set => maGV = value; }
        public string Ma_hk { get => ma_hk; set => ma_hk = value; }
        public double DiemLan1 { get => diemLan1; set => diemLan1 = value; }
        public double DiemLan2 { get => diemLan2; set => diemLan2 = value; }
        public double DiemTichLuy { get => diemTichLuy; set => diemTichLuy = value; }
        public string DiemChu { get => diemChu; set => diemChu = value; }

        public override string ToString()
        {
            return Mssv + "$" + Idmh + "$" + MaGV + "$" + Ma_hk + "$" + DiemLan1 + "$" + DiemLan2 + "$" + DiemTichLuy + "$" + DiemChu;
        }

        public void show()
        {
            Console.WriteLine("Mã số sinh viên: {0}", Mssv);
            Console.WriteLine("ID môn học: {0}", Idmh);
            Console.WriteLine("Mã số giáo viên: {0}", MaGV);
            Console.WriteLine("Mã học kỳ: {0}", Ma_hk);
            Console.WriteLine("Điểm lần 1: {0}", DiemLan1);
            Console.WriteLine("Điểm lần 2: {0}", DiemLan2);
            Console.WriteLine("Điểm tích luỹ: {0}", DiemTichLuy);
            Console.WriteLine("Điểm chữ: {0}", DiemChu);
        }

        public void input(List<DiemSV> listDiemSV, List<GiangVien> listGiangVien, List<MonHoc> listMonHoc)
        {
            Console.WriteLine("Nhập thông tin về điểm số của sinh viên");
            Console.Write("Nhập mã số sinh viên: ");
            mssv = Validation.checkMssv(listDiemSV);
            Console.Write("Nhập ID môn học: ");
            do
            {
                idmh = Validation.checkIDMonHocUpdateAndDelete(listMonHoc);
                if (String.IsNullOrEmpty(idmh))
                {
                    Console.WriteLine("ID môn học không tồn tại");
                    Console.Write("Vui lòng nhập lại: ");
                }

            } while (String.IsNullOrEmpty(idmh));

            Console.Write("Nhập mã số giáo viên: ");
            do
            {
                maGV = Validation.checkMaSoGVUpdateAndDelete(listGiangVien);
                if (String.IsNullOrEmpty(maGV))
                {
                    Console.WriteLine("Mã số giảng viên không tồn tại");
                    Console.Write("Vui lòng nhập lại: ");
                }

            } while (String.IsNullOrEmpty(maGV));
            Console.Write("Nhập mã học kỳ: ");
            ma_hk = Validation.checkMaHocKy();
            Console.Write("Nhập điểm lần 1: ");
            diemLan1 = Validation.checkDiem();
            Console.Write("Nhập điểm lần 2: ");
            diemLan2 = Validation.checkDiem();
            Console.Write("Nhập điểm tích luỹ: ");
            diemTichLuy = Validation.checkDiem();
            Console.Write("Nhập điểm chữ: ");
            diemChu = Validation.checkEmptyString();
            Console.WriteLine("Thông tin về điểm số của sinh viên đã được thêm thành công");
            
        }

        public List<DiemSV> update(List<DiemSV> listDiemSV, List<GiangVien> listGiangVien, List<MonHoc> listMonHoc)
        {
            Console.Write("Nhập mã số sinh viên cần thay đổi điểm: ");
            mssv = Validation.checkMssvUpdateAndDelete(listDiemSV);
            if (!String.IsNullOrEmpty(mssv))
            {
                int index = listDiemSV.FindIndex(x => x.Mssv.Equals(mssv));
                DiemSV obj = listDiemSV[index];
                Console.Write("Nhập ID môn học: ");
                do
                {
                    obj.Idmh = Validation.checkIDMonHocUpdateAndDelete(listMonHoc);
                    if (String.IsNullOrEmpty(obj.Idmh))
                    {
                        Console.WriteLine("ID môn học không tồn tại");
                        Console.Write("Vui lòng nhập lại: ");
                    }
                        
                } while (String.IsNullOrEmpty(obj.Idmh));

                Console.Write("Nhập mã số giáo viên: ");
                do
                {
                    obj.MaGV = Validation.checkMaSoGVUpdateAndDelete(listGiangVien);
                    if (String.IsNullOrEmpty(obj.MaGV))
                    {
                        Console.WriteLine("Mã số giảng viên không tồn tại");
                        Console.Write("Vui lòng nhập lại: ");
                    }

                } while (String.IsNullOrEmpty(obj.MaGV));
                Console.Write("Nhập mã học kỳ: ");
                obj.Ma_hk = Validation.checkMaHocKy();
                Console.Write("Nhập điểm lần 1: ");
                obj.DiemLan1 = Validation.checkDiem();
                Console.Write("Nhập điểm lần 2: ");
                obj.DiemLan2 = Validation.checkDiem();
                Console.Write("Nhập điểm tích luỹ: ");
                obj.DiemTichLuy = Validation.checkDiem();
                Console.Write("Nhập điểm chữ: ");
                obj.DiemChu = Validation.checkEmptyString();
                listDiemSV[index] = obj;
                Console.WriteLine("Thông tin về điểm sinh viên đã được thay đổi thành công!");
            }
            else
            {
                Console.WriteLine("Mã số sinh viên không tồn tại");
            }
            return listDiemSV;

        }

        public List<DiemSV> delete(List<DiemSV> listDiemSV)
        {
            Console.Write("Nhập mã số sinh viên cần xoá thông tin về điểm số: ");
            mssv = Validation.checkMssvUpdateAndDelete(listDiemSV);
            if (!String.IsNullOrEmpty(mssv))
            {
                int index = listDiemSV.FindIndex(x => x.Mssv.Equals(mssv));
                DiemSV obj = listDiemSV[index];
                Console.WriteLine("Thông tin về điểm sinh viên mà bạn sắp xoá: ");
                obj.show();
                Console.Write("Bạn có chắc chắn muốn xoá thông tin về điểm số này (Y để xoá, kí tự khác để huỷ): ");
                String choice = Console.ReadLine();

                if (choice.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    listDiemSV.RemoveAt(index);
                    Console.WriteLine("Thông tin về điểm số của sinh viên này đã được xoá thành công.");
                }
                else
                {
                    Console.WriteLine("Huỷ thành công");
                }


            }
            else
            {
                Console.WriteLine("Mã số sinh viên không tồn tại");
            }
            return listDiemSV;

        }


    }

}
