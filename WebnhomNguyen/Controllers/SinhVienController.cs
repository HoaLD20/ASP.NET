using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using P5WF;
using WebnhomNguyen.DAO;

namespace WebnhomNguyen.Models
{
    public class SinhVienController : Controller
    {
        // GET: SinhVien
        public ActionResult getListSV()
        {
            DBConnection conn =  new DBConnection();
            List<sinh_vien> sinhvien = new List<sinh_vien>();
            return ;
            
        }
        public ActionResult Show()
        {
            return View();
        }

    }
}