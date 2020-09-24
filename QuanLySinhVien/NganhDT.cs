using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien
{

    /**
     * 
     * Class nay de luu thong tin cua nganh dao tao
     * 
     */

    class NganhDT
    {
        private string manganh;
        private string IDBDT;
        private string tennganh;

        public NganhDT()
        {

        }
        public NganhDT(string manganh, string iDBDT, string tennganh)
        {
            this.manganh = manganh;
            IDBDT = iDBDT;
            this.tennganh = tennganh;
        }

        public string Manganh { get => manganh; set => manganh = value; }
        public string IDBDT1 { get => IDBDT; set => IDBDT = value; }
        public string Tennganh { get => tennganh; set => tennganh = value; }
    }
}
