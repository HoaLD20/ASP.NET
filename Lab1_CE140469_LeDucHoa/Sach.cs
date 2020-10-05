using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_CE140469_LeDucHoa
{
    class Sach
    {
        private string idSach;
        private string tieuDe;
        private DateTime namXB;
        private string datetacGia;
        private double giaTien;

        public Sach()
        {

        }

        public Sach(string idSach, string tieuDe, DateTime namXB, string datetacGia, double giaTien)
        {
            this.IdSach = idSach;
            this.TieuDe = tieuDe;
            this.NamXB = namXB;
            this.DatetacGia = datetacGia;
            this.GiaTien = giaTien;
        }

        public string IdSach { get => idSach; set => idSach = value; }
        public string TieuDe { get => tieuDe; set => tieuDe = value; }
        public DateTime NamXB { get => namXB; set => namXB = value; }
        public string DatetacGia { get => datetacGia; set => datetacGia = value; }
        public double GiaTien { get => giaTien; set => giaTien = value; }
    }
}
