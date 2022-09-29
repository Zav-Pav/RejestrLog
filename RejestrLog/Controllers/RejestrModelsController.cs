using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RejestrLog.DAL;
using RejestrLog.Models;

namespace RejestrLog.Controllers
{
    public class RejestrModelsController : Controller
    {
        private RejestrContext db = new RejestrContext();

        // GET: RejestrModels
        public ActionResult Index()
        {
            return View(db.RejestrModels.ToList());
        }

        // GET: RejestrModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RejestrModel rejestrModel = db.RejestrModels.Find(id);
            if (rejestrModel == null)
            {
                return HttpNotFound();
            }
            return View(rejestrModel);
        }

        // GET: RejestrModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RejestrModels/Create
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Działanie,Poddziałanie,NrProjektu,TytułProjektu,Beneficjent,Zespół,RodzajKontroli,TerminKontroli,DataZakończenia,WizytaMonitoringowa,Pzp,Konkurencyjnosc,RozeznanieRynku,DataPierwszejInformacji,ZastrzezeniaDoInf,DataOstatecznejInfo,DataPodpisaniaInfo,DataWpisuDoSL,UchybieniaNIeprawidlowoci,Zalecenia,DataWykonaniaZalecen,KontrolaZakonczona")] RejestrModel rejestrModel)
        {
            if (ModelState.IsValid)
            {
                db.RejestrModels.Add(rejestrModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rejestrModel);
        }

        // GET: RejestrModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RejestrModel rejestrModel = db.RejestrModels.Find(id);
            if (rejestrModel == null)
            {
                return HttpNotFound();
            }
            return View(rejestrModel);
        }

        // POST: RejestrModels/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Działanie,Poddziałanie,NrProjektu,TytułProjektu,Beneficjent,Zespół,RodzajKontroli,TerminKontroli,DataZakończenia,WizytaMonitoringowa,Pzp,Konkurencyjnosc,RozeznanieRynku,DataPierwszejInformacji,ZastrzezeniaDoInf,DataOstatecznejInfo,DataPodpisaniaInfo,DataWpisuDoSL,UchybieniaNIeprawidlowoci,Zalecenia,DataWykonaniaZalecen,KontrolaZakonczona")] RejestrModel rejestrModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rejestrModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rejestrModel);
        }

        // GET: RejestrModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RejestrModel rejestrModel = db.RejestrModels.Find(id);
            if (rejestrModel == null)
            {
                return HttpNotFound();
            }
            return View(rejestrModel);
        }

        // POST: RejestrModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RejestrModel rejestrModel = db.RejestrModels.Find(id);
            db.RejestrModels.Remove(rejestrModel);
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
