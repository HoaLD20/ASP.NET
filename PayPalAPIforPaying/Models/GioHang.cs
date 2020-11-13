using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PayPalAPIforPaying.Models
{
    public class GioHang : DataTable
    {
        private int MASP;
        private string TENSP;
        private int SOLUONG;
        private double GIABAN;
        private double GIAUSD;
        private string HINHANH;
        private double TONGGIA;
        private double TONGGIAUSD;
        private double _shipping;

        public int Ma
        {
            set { MASP = value; }
            get { return MASP; }
        }
        public string Ten
        {
            set { TENSP = value; }
            get { return TENSP; }
        }
        public int soluong
        {
            set
            {
                if (SOLUONG > 0)
                {
                    SOLUONG = value;
                }

            }
            get { return SOLUONG; }
        }
        public string anh
        {
            set { HINHANH = value; }
            get { return HINHANH; }
        }
        public double Gia
        {
            set { GIABAN = value; }
            get { return GIABAN; }
        }
        public double GiaUSD
        {
            set { GIAUSD = value; }
            get { return GIAUSD; }
        }
        public double Tong
        {
            set { TONGGIA = value; }
            get { return (GIABAN * SOLUONG); }
        }
        public double TongUSD
        {
            set { TONGGIAUSD = value; }
            get { return (GiaUSD * SOLUONG); }
        }
        public double Shipping
        {
            get
            {
                return _shipping;
            }
            set
            {
                _shipping = value;

            }
        }

        public GioHang()
        {
            this.Columns.Add("masp", typeof(int));
            this.Columns.Add("tensp", typeof(string));
            this.Columns.Add("soluong", typeof(int));
            this.Columns.Add("gia", typeof(int));
            this.Columns.Add("giaUSD", typeof(int));
            this.Columns.Add("hinhanh", typeof(string));
            this.Columns.Add("tonggia", typeof(double), "soluong*gia");
            this.Columns.Add("tonggiaUSD", typeof(double), "soluong*giaUSD");
            this.Columns.Add("_shipping", typeof(double), "2");
            this.PrimaryKey = new DataColumn[] { this.Columns["masp"] };
        }
        public GioHang(int _ma, string _ten, string _anh, int _soluong, double _gia, double _giaUSD)
        {
            this.MASP = _ma;
            this.TENSP = _ten;
            this.HINHANH = _anh;
            this.SOLUONG = _soluong;
            this.GIABAN = _gia;
            this.GIAUSD = _giaUSD;
            this.TONGGIA = _gia * _soluong;
            this.TONGGIAUSD = _giaUSD * _soluong;
        }
        public void themvaogiohang(int masp, string hinhanh, string tensp, int sl, int gia, int giaUSD)
        {
            DataRow tmp = this.NewRow();
            //neu san pham nay da co trong gio hang
            if (kt(masp))
            {
                for (int i = 0; i < this.Rows.Count; i++)
                {
                    if (masp == int.Parse(this.Rows[i]["masp"].ToString()))
                    {
                        this.Rows[i]["soluong"] = int.Parse(this.Rows[i]["soluong"].ToString()) + 1;
                    }
                }
            }
            //nguoc lai add them 1 dong moi
            else
            {
                tmp["masp"] = masp;
                tmp["hinhanh"] = hinhanh;
                tmp["tensp"] = tensp;
                tmp["soluong"] = sl;
                tmp["gia"] = gia;
                tmp["giaUSD"] = giaUSD;
                this.Rows.Add(tmp);
            }

        }
        //kien tra san pham nay da co trong gio hang chua
        public bool kt(int masp)
        {
            bool ok = false;
            if (this.Rows.Count > 0)
            {
                for (int i = 0; i < this.Rows.Count; i++)
                {
                    if (masp == Convert.ToInt16(this.Rows[i]["masp"].ToString()))
                        ok = true;
                }
            }
            return ok;
        }
        public double tongtien()
        {
            double g = 0;
            for (int i = 0; i < this.Rows.Count; i++)
            {
                g = g + Convert.ToInt64(this.Rows[i]["tonggia"]);
            }
            return g;
        }
        public double tongtienUSD()
        {
            double g = 0;
            for (int i = 0; i < this.Rows.Count; i++)
            {
                g = g + Convert.ToInt64(this.Rows[i]["tonggiaUSD"]);
            }
            return g;
        }
        public int tongsoluong()
        {
            int s = 0;
            for (int i = 0; i < this.Rows.Count; i++)
            {
                s = s + Convert.ToInt32(this.Rows[i]["soluong"]);
            }
            return s;
        }


        public void updatesoluong(int sl, int masp)
        {
            try
            {

                for (int i = 0; i < this.Rows.Count; i++)
                {
                    if (masp == Convert.ToInt64(this.Rows[i]["masp"].ToString()))
                    {
                        this.Rows[i]["soluong"] = sl;


                    }
                }
            }
            catch (Exception ex) { }
        }
        public void xoagiohang(int masp)
        {
            try
            {
                DataRow dr = this.Rows.Find(masp);
                this.Rows.Remove(dr);
            }
            catch (Exception ex) { }

        }

    }
}