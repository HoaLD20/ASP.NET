using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLab
{
    class SinhVien
    {
        private String Id;
        private String Name;
        private DateTime NamSinh;
        private String IdLop;
        private double Diem;
        public SinhVien()
        {

        }

        public SinhVien(string id, string name, DateTime namSinh, string idLop, double diem)
        {
            Id = id;
            Name = name;
            NamSinh = namSinh;
            IdLop = idLop;
            Diem = diem;
        }

        public string Id1 { get => Id; set => Id = value; }
        public string Name1 { get => Name; set => Name = value; }
        public DateTime NamSinh1 { get => NamSinh; set => NamSinh = value; }
        public string IdLop1 { get => IdLop; set => IdLop = value; }
        public double Diem1 { get => Diem; set => Diem = value; }
    }
}
