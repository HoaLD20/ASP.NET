using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace BaiThucHanhLab_1
{
    class Product
    {
        string idPro;
        string namePro;
        double price;
        double quantity;

        public Product()
        {
        }

        public Product(string idPro, string namePro, double price, double quantity)
        {
            this.idPro = idPro;
            this.namePro = namePro;
            this.price = price;
            this.quantity = quantity;
        }

        public string IdPro { get => idPro; set => idPro = value; }
        public string NamePro { get => namePro; set => namePro = value; }
        public double Price { get => price; set => price = value; }
        public double Quantity { get => quantity; set => quantity = value; }

        



    }

   

}
