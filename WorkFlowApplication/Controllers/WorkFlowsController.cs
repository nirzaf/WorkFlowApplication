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
    public class WorkFlowsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: WorkFlows
        public ActionResult Index()
        {
            return View(db.WorkFlows.ToList());
        }

        // GET: WorkFlows/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkFlow workFlow = db.WorkFlows.Find(id);
            if (workFlow == null)
            {
                return HttpNotFound();
            }
            return View(workFlow);
        }

        // GET: WorkFlows/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorkFlows/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Work_Flow_ID,Work_FlowName,Work_Flow_Primary_Owner,Work_Flow_Entry_Criteria,Total_Entities,Work_Flow_Status")] WorkFlow workFlow)
        {
            if (ModelState.IsValid)
            {
                db.WorkFlows.Add(workFlow);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(workFlow);
        }

        // GET: WorkFlows/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkFlow workFlow = db.WorkFlows.Find(id);
            if (workFlow == null)
            {
                return HttpNotFound();
            }
            return View(workFlow);
        }

        // POST: WorkFlows/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Work_Flow_ID,Work_FlowName,Work_Flow_Primary_Owner,Work_Flow_Entry_Criteria,Total_Entities,Work_Flow_Status")] WorkFlow workFlow)
        {
            if (ModelState.IsValid)
            {
                db.Entry(workFlow).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(workFlow);
        }

        // GET: WorkFlows/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkFlow workFlow = db.WorkFlows.Find(id);
            if (workFlow == null)
            {
                return HttpNotFound();
            }
            return View(workFlow);
        }

        // POST: WorkFlows/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WorkFlow workFlow = db.WorkFlows.Find(id);
            db.WorkFlows.Remove(workFlow);
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
