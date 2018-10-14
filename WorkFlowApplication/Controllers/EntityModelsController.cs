using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WorkFlowApplication.Models;

namespace WorkFlowApplication.Controllers
{
    public class EntityModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EntityModels
        public ActionResult Index()
        {
            return View(db.EntityModels.ToList());
        }

        // GET: EntityModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntityModel entityModel = db.EntityModels.Find(id);
            if (entityModel == null)
            {
                return HttpNotFound();
            }
            return View(entityModel);
        }

        // GET: EntityModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EntityModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EntityID,EntityOwner,EntityCriteria,ActionRequired,ExitCriteria,EntityCreatedDate,EntityCloseDate,EntityAge,EntityApproved")] EntityModel entityModel)
        {
            if (ModelState.IsValid)
            {
                db.EntityModels.Add(entityModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(entityModel);
        }

        // GET: EntityModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntityModel entityModel = db.EntityModels.Find(id);
            if (entityModel == null)
            {
                return HttpNotFound();
            }
            return View(entityModel);
        }

        // POST: EntityModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EntityID,EntityOwner,EntityCriteria,ActionRequired,ExitCriteria,EntityCreatedDate,EntityCloseDate,EntityAge,EntityApproved")] EntityModel entityModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entityModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(entityModel);
        }

        // GET: EntityModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntityModel entityModel = db.EntityModels.Find(id);
            if (entityModel == null)
            {
                return HttpNotFound();
            }
            return View(entityModel);
        }

        // POST: EntityModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EntityModel entityModel = db.EntityModels.Find(id);
            db.EntityModels.Remove(entityModel);
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
