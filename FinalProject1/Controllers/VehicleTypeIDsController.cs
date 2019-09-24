using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalProject1.Models;

namespace FinalProject1.Controllers
{
    public class VehicleTypeIDsController : Controller
    {
        private DataContext db = new DataContext();

        // GET: VehicleTypeIDs
        public ActionResult Index()
        {
            return View(db.VehicleTypeIDs.ToList());
        }

        // GET: VehicleTypeIDs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleTypeID vehicleTypeID = db.VehicleTypeIDs.Find(id);
            if (vehicleTypeID == null)
            {
                return HttpNotFound();
            }
            return View(vehicleTypeID);
        }

        // GET: VehicleTypeIDs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VehicleTypeIDs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VehicleTypeID1,Name")] VehicleTypeID vehicleTypeID)
        {
            if (ModelState.IsValid)
            {
                db.VehicleTypeIDs.Add(vehicleTypeID);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vehicleTypeID);
        }

        // GET: VehicleTypeIDs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleTypeID vehicleTypeID = db.VehicleTypeIDs.Find(id);
            if (vehicleTypeID == null)
            {
                return HttpNotFound();
            }
            return View(vehicleTypeID);
        }

        // POST: VehicleTypeIDs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VehicleTypeID1,Name")] VehicleTypeID vehicleTypeID)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vehicleTypeID).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vehicleTypeID);
        }

        // GET: VehicleTypeIDs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleTypeID vehicleTypeID = db.VehicleTypeIDs.Find(id);
            if (vehicleTypeID == null)
            {
                return HttpNotFound();
            }
            return View(vehicleTypeID);
        }

        // POST: VehicleTypeIDs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VehicleTypeID vehicleTypeID = db.VehicleTypeIDs.Find(id);
            db.VehicleTypeIDs.Remove(vehicleTypeID);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
