using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project_isf.Domain.POCO;
using project_isf.Domain.Concrete;

namespace project_isf.Controllers
{
    public class ISFEventController : Controller
    {
        private EFDbContext db = new EFDbContext();

        //
        // GET: /ISFEvent/

        public ActionResult Index()
        {
            return View(db.Events.ToList());
        }

        //
        // GET: /ISFEvent/Details/5

        public ActionResult Details(int id = 0)
        {
            ISFEvent isfevent = db.Events.Find(id);
            if (isfevent == null)
            {
                return HttpNotFound();
            }
            return View(isfevent);
        }

        //
        // GET: /ISFEvent/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ISFEvent/Create

        [HttpPost]
        public ActionResult Create(ISFEvent isfevent)
        {
            if (ModelState.IsValid)
            {
                db.Events.Add(isfevent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(isfevent);
        }

        //
        // GET: /ISFEvent/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ISFEvent isfevent = db.Events.Find(id);
            if (isfevent == null)
            {
                return HttpNotFound();
            }
            return View(isfevent);
        }

        //
        // POST: /ISFEvent/Edit/5

        [HttpPost]
        public ActionResult Edit(ISFEvent isfevent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(isfevent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(isfevent);
        }

        //
        // GET: /ISFEvent/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ISFEvent isfevent = db.Events.Find(id);
            if (isfevent == null)
            {
                return HttpNotFound();
            }
            return View(isfevent);
        }

        //
        // POST: /ISFEvent/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ISFEvent isfevent = db.Events.Find(id);
            db.Events.Remove(isfevent);
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