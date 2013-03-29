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
    public class MeetingEventController : Controller
    {
        private EFDbContext db = new EFDbContext();

        //
        // GET: /MeetingEvent/

        public ActionResult Index()
        {
            var meetingevents = db.MeetingEvents.Include(m => m.Event).Include(m => m.Meeting);
            return View(meetingevents.ToList());
        }

        //
        // GET: /MeetingEvent/Details/5

        public ActionResult Details(int id = 0)
        {
            MeetingEvent meetingevent = db.MeetingEvents.Find(id);
            if (meetingevent == null)
            {
                return HttpNotFound();
            }
            return View(meetingevent);
        }

        //
        // GET: /MeetingEvent/Create

        public ActionResult Create()
        {
            ViewBag.EventId = new SelectList(db.Events, "EventId", "Name");
            ViewBag.MeetingId = new SelectList(db.Meetings, "MeetingId", "Adress");
            return View();
        }

        //
        // POST: /MeetingEvent/Create

        [HttpPost]
        public ActionResult Create(MeetingEvent meetingevent)
        {
            if (ModelState.IsValid)
            {
                db.MeetingEvents.Add(meetingevent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EventId = new SelectList(db.Events, "EventId", "Name", meetingevent.EventId);
            ViewBag.MeetingId = new SelectList(db.Meetings, "MeetingId", "Adress", meetingevent.MeetingId);
            return View(meetingevent);
        }

        //
        // GET: /MeetingEvent/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MeetingEvent meetingevent = db.MeetingEvents.Find(id);
            if (meetingevent == null)
            {
                return HttpNotFound();
            }
            ViewBag.EventId = new SelectList(db.Events, "EventId", "Name", meetingevent.EventId);
            ViewBag.MeetingId = new SelectList(db.Meetings, "MeetingId", "Adress", meetingevent.MeetingId);
            return View(meetingevent);
        }

        //
        // POST: /MeetingEvent/Edit/5

        [HttpPost]
        public ActionResult Edit(MeetingEvent meetingevent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(meetingevent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EventId = new SelectList(db.Events, "EventId", "Name", meetingevent.EventId);
            ViewBag.MeetingId = new SelectList(db.Meetings, "MeetingId", "Adress", meetingevent.MeetingId);
            return View(meetingevent);
        }

        //
        // GET: /MeetingEvent/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MeetingEvent meetingevent = db.MeetingEvents.Find(id);
            if (meetingevent == null)
            {
                return HttpNotFound();
            }
            return View(meetingevent);
        }

        //
        // POST: /MeetingEvent/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            MeetingEvent meetingevent = db.MeetingEvents.Find(id);
            db.MeetingEvents.Remove(meetingevent);
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