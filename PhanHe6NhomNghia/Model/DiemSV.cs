using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace PhanHe6NhomNghia.Model
{
    class DiemSV_mgt
    {
        private string mssv;
        private string idmh;
        private string magv;
        private string ma_hk;
        private float diemlan1;
        private float diemlan2;
        private float diemtichluy;
        private char diemchu;

        public DiemSV_mgt()
        {
        }

        public DiemSV_mgt(string mssv, string idmh, string magv, string ma_hk, float diemlan1, float diemlan2, float diemtichluy, char diemchu)
        {
            this.Mssv = mssv;
            this.Idmh = idmh;
            this.Magv = magv;
            this.Ma_hk = ma_hk;
            this.Diemlan1 = diemlan1;
            this.Diemlan2 = diemlan2;
            this.Diemtichluy = diemtichluy;
            this.Diemchu = diemchu;
        }

        public string Mssv { get => mssv; set => mssv = value; }
        public string Idmh { get => idmh; set => idmh = value; }
        public string Magv { get => magv; set => magv = value; }
        public string Ma_hk { get => ma_hk; set => ma_hk = value; }
        public float Diemlan1 { get => diemlan1; set => diemlan1 = value; }
        public float Diemlan2 { get => diemlan2; set => diemlan2 = value; }
        public float Diemtichluy { get => diemtichluy; set => diemtichluy = value; }
        public char Diemchu { get => diemchu; set => diemchu = value; }
    }
}
