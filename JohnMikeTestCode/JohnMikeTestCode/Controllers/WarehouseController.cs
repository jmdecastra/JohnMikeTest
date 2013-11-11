using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JohnMikeTestCode.Models;

namespace JohnMikeTestCode.Controllers
{
    public class WarehouseController : Controller
    {
        private Test db = new Test();

        //
        // GET: /Warehouse/

        public ActionResult Index()
        {
            return View(db.ELSTWAREHOUSEs.ToList());
        }

        //
        // GET: /Warehouse/Details/5

        public ActionResult Details(string id = null)
        {
            ELSTWAREHOUSE elstwarehouse = db.ELSTWAREHOUSEs.Find(id);
            if (elstwarehouse == null)
            {
                return HttpNotFound();
            }
            return View(elstwarehouse);
        }

        //
        // GET: /Warehouse/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Warehouse/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ELSTWAREHOUSE elstwarehouse)
        {
            if (ModelState.IsValid)
            {
                db.ELSTWAREHOUSEs.Add(elstwarehouse);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(elstwarehouse);
        }

        //
        // GET: /Warehouse/Edit/5

        public ActionResult Edit(string id = null)
        {
            ELSTWAREHOUSE elstwarehouse = db.ELSTWAREHOUSEs.Find(id);
            if (elstwarehouse == null)
            {
                return HttpNotFound();
            }
            return View(elstwarehouse);
        }

        //
        // POST: /Warehouse/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ELSTWAREHOUSE elstwarehouse)
        {
            if (ModelState.IsValid)
            {
                db.Entry(elstwarehouse).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(elstwarehouse);
        }

        //
        // GET: /Warehouse/Delete/5

        public ActionResult Delete(string id = null)
        {
            ELSTWAREHOUSE elstwarehouse = db.ELSTWAREHOUSEs.Find(id);
            if (elstwarehouse == null)
            {
                return HttpNotFound();
            }
            return View(elstwarehouse);
        }

        //
        // POST: /Warehouse/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ELSTWAREHOUSE elstwarehouse = db.ELSTWAREHOUSEs.Find(id);
            db.ELSTWAREHOUSEs.Remove(elstwarehouse);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}