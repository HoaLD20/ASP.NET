using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NhomTriTin.Models;

namespace NhomTriTin.Controllers
{
    public class SinhVienController : Controller
    {
        // GET: SinhVien
        public ActionResult Index()
        {
            using(SINH_VIENEntities sinhvienE = new SINH_VIENEntities())
            {
                return View(sinhvienE.DiemSVs.ToList());
            }
        }

        // GET: SinhVien/Details/5
        public ActionResult Details(String MSSV)
        {
            using(SINH_VIENEntities sve = new SINH_VIENEntities())
            {
                return View(sve.DiemSVs.Where(x => x.Equals(MSSV)).FirstOrDefault());
            }
        }

        // GET: SinhVien/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SinhVien/Create
        [HttpPost]
        public ActionResult Create(DiemSV diemsv)
        {

            using (SINH_VIENEntities sinhvienE = new SINH_VIENEntities())
            {
                if (sinhvienE.DiemSVs.Any(x => x.MSSV.Equals(diemsv.MSSV)))
                {
                    ModelState.AddModelError("SV", "Ma sinh vien da ton tai");
                }
                else
                {
                    sinhvienE.DiemSVs.Add(diemsv);
                    sinhvienE.SaveChanges();
                }


                try
                {
                    // TODO: Add insert logic here

                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }
        }
        // GET: SinhVien/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SinhVien/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {

           


            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SinhVien/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SinhVien/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
