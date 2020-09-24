using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien
{

    /**
     * Class nay de luu thong tin cua Bac Dao Tao
     * 
     */

    class BacDT
    {
        private string IDBDT;
        private string tenbacDT;

        public BacDT()
        {

        }
        public BacDT(string iDBDT, string tenbacDT)
        {
            IDBDT = iDBDT;
            this.tenbacDT = tenbacDT;
        }

        public string IDBDT1 { get => IDBDT; set => IDBDT = value; }
        public string TenbacDT { get => tenbacDT; set => tenbacDT = value; }
    }
}
