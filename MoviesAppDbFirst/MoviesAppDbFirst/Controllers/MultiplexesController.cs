using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MoviesAppDbFirst.Models;

namespace MoviesAppDbFirst.Controllers
{
    public class MultiplexesController : Controller
    {
        private MovieEntitiesEntities db = new MovieEntitiesEntities();

        // GET: Multiplexes
        public ActionResult Index()
        {
            var multiplexes = db.Multiplexes.Include(m => m.Movie);
            return View(multiplexes.ToList());
        }

        // GET: Multiplexes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Multiplex multiplex = db.Multiplexes.Find(id);
            if (multiplex == null)
            {
                return HttpNotFound();
            }
            return View(multiplex);
        }

        // GET: Multiplexes/Create
        public ActionResult Create()
        {
            ViewBag.MovieId = new SelectList(db.Movies, "MovieId", "MovieName");
            return View();
        }

        // POST: Multiplexes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MultiplexId,MultiplexName,Location,Screen,MovieId")] Multiplex multiplex)
        {
            if (ModelState.IsValid)
            {
                db.Multiplexes.Add(multiplex);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MovieId = new SelectList(db.Movies, "MovieId", "MovieName", multiplex.MovieId);
            return View(multiplex);
        }

        // GET: Multiplexes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Multiplex multiplex = db.Multiplexes.Find(id);
            if (multiplex == null)
            {
                return HttpNotFound();
            }
            ViewBag.MovieId = new SelectList(db.Movies, "MovieId", "MovieName", multiplex.MovieId);
            return View(multiplex);
        }

        // POST: Multiplexes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MultiplexId,MultiplexName,Location,Screen,MovieId")] Multiplex multiplex)
        {
            if (ModelState.IsValid)
            {
                db.Entry(multiplex).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MovieId = new SelectList(db.Movies, "MovieId", "MovieName", multiplex.MovieId);
            return View(multiplex);
        }

        // GET: Multiplexes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Multiplex multiplex = db.Multiplexes.Find(id);
            if (multiplex == null)
            {
                return HttpNotFound();
            }
            return View(multiplex);
        }

        // POST: Multiplexes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Multiplex multiplex = db.Multiplexes.Find(id);
            db.Multiplexes.Remove(multiplex);
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
