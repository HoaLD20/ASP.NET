using System;
using System.Collections.Generic;
using System.Text;

namespace PhanHe6NhomNghia.Model
{
    class GiangVien
    {
        private string magv;
        private string tengv;
        private int gioitinh;
        private DateTime namsinhgv;
        private string trinhdogv;
        private string emailgv;
        private string sdt;

        public GiangVien()
        {
        }

        public GiangVien(string magv, string tengv, int gioitinh, DateTime namsinhgv, string trinhdogv, string emailgv, string sdt)
        {
            this.Magv = magv;
            this.Tengv = tengv;
            this.Gioitinh = gioitinh;
            this.Namsinhgv = namsinhgv;
            this.Trinhdogv = trinhdogv;
            this.Emailgv = emailgv;
            this.Sdt = sdt;
        }

        public string Magv { get => magv; set => magv = value; }
        public string Tengv { get => tengv; set => tengv = value; }
        public int Gioitinh { get => gioitinh; set => gioitinh = value; }
        public DateTime Namsinhgv { get => namsinhgv; set => namsinhgv = value; }
        public string Trinhdogv { get => trinhdogv; set => trinhdogv = value; }
        public string Emailgv { get => emailgv; set => emailgv = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
