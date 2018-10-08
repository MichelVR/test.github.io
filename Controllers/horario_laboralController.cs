using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Proyecto_RadixWeb.Models;

namespace Proyecto_RadixWeb.Controllers
{
    public class horario_laboralController : Controller
    {
        private radixEntities db = new radixEntities();



        public ActionResult HorarioSemanal(int? Car_Id)
        {

            ViewBag.cargo = Car_Id;
             var diaslista = db.diassemanales.ToList();
            var horario_laboral = db.horario_laboral.Where(h=>h.Car_Id==Car_Id).ToList();

            var multiple = new MultipleHorario
            {
                objDias = diaslista,
                objHorario = horario_laboral
            };


            return View(multiple);
        }


                // GET: horario_laboral
        public ActionResult Index()
        {
            var horario_laboral = db.horario_laboral.Include(h => h.cargos).Include(h => h.diassemanales);
            return View(horario_laboral.ToList());
        }

        // GET: horario_laboral/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            horario_laboral horario_laboral = db.horario_laboral.Find(id);
            if (horario_laboral == null)
            {
                return HttpNotFound();
            }
            return View(horario_laboral);
        }

        // GET: horario_laboral/Create
        public ActionResult Create()
        {
            ViewBag.Car_Id = new SelectList(db.cargos, "Car_Id", "Car_Nom");
            ViewBag.Ds_Id = new SelectList(db.diassemanales, "Ds_id", "Ds_Nom");
            return View();
        }

        // POST: horario_laboral/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Hl_Id,Car_Id,Ds_Id,Hl_Inicio,Hl_Termino")] horario_laboral horario_laboral)
        {
            if (ModelState.IsValid)
            {
                db.horario_laboral.Add(horario_laboral);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Car_Id = new SelectList(db.cargos, "Car_Id", "Car_Nom", horario_laboral.Car_Id);
            ViewBag.Ds_Id = new SelectList(db.diassemanales, "Ds_id", "Ds_Nom", horario_laboral.Ds_Id);
            return View(horario_laboral);
        }

        // GET: horario_laboral/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            horario_laboral horario_laboral = db.horario_laboral.Find(id);
            if (horario_laboral == null)
            {
                return HttpNotFound();
            }
            ViewBag.Car_Id = new SelectList(db.cargos, "Car_Id", "Car_Nom", horario_laboral.Car_Id);
            ViewBag.Ds_Id = new SelectList(db.diassemanales, "Ds_id", "Ds_Nom", horario_laboral.Ds_Id);
            return View(horario_laboral);
        }

        // POST: horario_laboral/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Hl_Id,Car_Id,Ds_Id,Hl_Inicio,Hl_Termino")] horario_laboral horario_laboral)
        {
            if (ModelState.IsValid)
            {
                db.Entry(horario_laboral).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Car_Id = new SelectList(db.cargos, "Car_Id", "Car_Nom", horario_laboral.Car_Id);
            ViewBag.Ds_Id = new SelectList(db.diassemanales, "Ds_id", "Ds_Nom", horario_laboral.Ds_Id);
            return View(horario_laboral);
        }

        // GET: horario_laboral/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            horario_laboral horario_laboral = db.horario_laboral.Find(id);
            if (horario_laboral == null)
            {
                return HttpNotFound();
            }
            return View(horario_laboral);
        }

        // POST: horario_laboral/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            horario_laboral horario_laboral = db.horario_laboral.Find(id);
            db.horario_laboral.Remove(horario_laboral);
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
