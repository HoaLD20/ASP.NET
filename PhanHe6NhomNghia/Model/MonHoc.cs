using System;
using System.Collections.Generic;
using System.Text;

namespace PhanHe6NhomNghia.Model
{
    class MonHoc
    {
        private string idmh;
        private string ma_hk;
        private string tenmh;
        private int sotc;
        private int lythuyet;
        private int thuchanh;

        public MonHoc()
        {
        }

        public MonHoc(string idmh, string ma_hk, string tenmh, int sotc, int lythuyet, int thuchanh)
        {
            this.Idmh = idmh;
            this.Ma_hk = ma_hk;
            this.Tenmh = tenmh;
            this.Sotc = sotc;
            this.Lythuyet = lythuyet;
            this.Thuchanh = thuchanh;
        }

        public string Idmh { get => idmh; set => idmh = value; }
        public string Ma_hk { get => ma_hk; set => ma_hk = value; }
        public string Tenmh { get => tenmh; set => tenmh = value; }
        public int Sotc { get => sotc; set => sotc = value; }
        public int Lythuyet { get => lythuyet; set => lythuyet = value; }
        public int Thuchanh { get => thuchanh; set => thuchanh = value; }

        public void show()
        {
            Console.WriteLine("ID mon hoc: {0}", idmh);

        }

    }
}
