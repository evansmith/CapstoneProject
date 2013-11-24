using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapstoneProject.DAL;

namespace CapstoneProject.Controllers
{
    public class SoundController : Controller
    {

        private SoundContext db = new SoundContext();
        //
        // GET: /Sound/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Sound/Details/5

        public JsonResult Details(int id)
        {
            return null;
        }

        //
        // GET: /Sound/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Sound/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
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

        //
        // GET: /Sound/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Sound/Edit/5

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

        //
        // GET: /Sound/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Sound/Delete/5

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
