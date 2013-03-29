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
    public class MeetingController : Controller
    {
        private EFDbContext db = new EFDbContext();

        //
        // GET: /Meeting/

        public ActionResult Index()
        {
            return View(db.Meetings.ToList());
        }

        //
        // GET: /Meeting/Details/5

        public ActionResult Details(int id = 0)
        {
            Meeting meeting = db.Meetings.Find(id);
            if (meeting == null)
            {
                return HttpNotFound();
            }
            return View(meeting);
        }

        //
        // GET: /Meeting/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Meeting/Create

        [HttpPost]
        public ActionResult Create(Meeting meeting)
        {
            if (ModelState.IsValid)
            {
                db.Meetings.Add(meeting);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(meeting);
        }

        //
        // GET: /Meeting/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Meeting meeting = db.Meetings.Find(id);
            if (meeting == null)
            {
                return HttpNotFound();
            }
            return View(meeting);
        }

        //
        // POST: /Meeting/Edit/5

        [HttpPost]
        public ActionResult Edit(Meeting meeting)
        {
            if (ModelState.IsValid)
            {
                db.Entry(meeting).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(meeting);
        }

        //
        // GET: /Meeting/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Meeting meeting = db.Meetings.Find(id);
            if (meeting == null)
            {
                return HttpNotFound();
            }
            return View(meeting);
        }

        //
        // POST: /Meeting/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Meeting meeting = db.Meetings.Find(id);
            db.Meetings.Remove(meeting);
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