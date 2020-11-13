using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PayPalAPIforPaying.Controllers
{
    public partial class NguoiDung_TTPaypal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GioHang _cart = (GioHang)Session["GioHang"];
            string strAdd = "";
            if (_cart.Rows.Count > 0)
            {
                for (int i = 0; i < _cart.Rows.Count; i++)
                {
                    strAdd = "<input type=\"hidden\" value=\"" + _cart.Rows[i]["TENSP"].ToString() + "\" name=\"item_name_" + (i + 1) + "\">";
                    plHej.Controls.Add(new System.Web.UI.LiteralControl(strAdd));
                    strAdd = "<input type=\"hidden\" value=\"" + _cart.Rows[i]["GIAUSD"].ToString() + "\" name=\"amount_" + (i + 1) + "\">";
                    plHej.Controls.Add(new System.Web.UI.LiteralControl(strAdd));
                    strAdd = "<input type=\"hidden\" value=\"" + _cart.Rows[i]["SOLUONG"].ToString() + "\" name=\"quantity_" + (i + 1) + "\">";
                    plHej.Controls.Add(new System.Web.UI.LiteralControl(strAdd));
                    strAdd = "<input type=\"hidden\" value=\"" + _cart.Rows[0]["_shipping"].ToString() + "\" name=\"shipping_" + 1 + "\">";
                    plHej.Controls.Add(new System.Web.UI.LiteralControl(strAdd));

                }

            }
        }
    }
}