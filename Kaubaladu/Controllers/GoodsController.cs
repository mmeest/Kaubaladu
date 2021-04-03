using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Kaubaladu;

namespace Kaubaladu.Controllers
{
    [Authorize]
    public class GoodsController : Controller
    {
        private KaubaladuEntities db = new KaubaladuEntities();

        // GET: Goods
        public ActionResult Index(string name, string serial, string cathegory, string origin, string owner)
        {            
            if(User.Identity.Name == "admin")
            {
                //if (name != null)
                if (!String.IsNullOrEmpty(name))
                {
                    var query = from Good in db.Goods
                            where Good.Name == name
                            select Good;
                    return View(query.ToList());
                }
                //else if (serial != null)
                else if(!String.IsNullOrEmpty(serial))
                {
                    var query = from Good in db.Goods
                                where Good.Serial == serial
                                select Good;
                    return View(query.ToList());
                }
                else if (!String.IsNullOrEmpty(cathegory))
                {
                    var query = from Good in db.Goods
                                where Good.Cathegory == cathegory
                                select Good;
                    return View(query.ToList());
                }
                else if (!String.IsNullOrEmpty(origin))
                {
                    var query = from Good in db.Goods
                                where Good.Origin == origin
                                select Good;
                    return View(query.ToList());
                }
                else if (!String.IsNullOrEmpty(owner))
                {
                    var query = from Good in db.Goods
                                where Good.Owner == owner
                                select Good;
                    return View(query.ToList());
                }
                else
                {
                    var query = from Good in db.Goods
                                select Good;
                    return View(query.ToList());
                }
            }
            else
            {
                var query = from Good in db.Goods
                            where Good.Owner == User.Identity.Name
                            select Good;
                return View(query.ToList());
            }
        }


        // GET: Goods/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Good good = db.Goods.Find(id);
            if (good == null)
            {
                return HttpNotFound();
            }
            return View(good);
        }

        // GET: Goods/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Goods/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Img,FileName,Name,Serial,Cathegory,Origin,Unit,Amount,Owner")] Good good, HttpPostedFileBase file)
        {
            // HttpPostedFileBase fileUpload = Request.Files["file"] as HttpPostedFileBase;

            if (ModelState.IsValid)            
            {
                string fileName = Path.GetFileNameWithoutExtension(file.FileName);          // failinimi
                string extension = Path.GetExtension(file.FileName);                        // faili laiend
                fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;       // lisatakse kellaaeg
                good.Img = "../Images/" + fileName;                                         // andmebaas
                fileName = Path.Combine(Server.MapPath("../Images/"), fileName);
                file.SaveAs(fileName);

                db.Goods.Add(good);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(good);
        }

        // GET: Goods/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Good good = db.Goods.Find(id);
            if (good == null)
            {
                return HttpNotFound();
            }
            return View(good);

        }

        // POST: Goods/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Serial,Cathegory,Origin,Unit,Amount,Owner,Img")] Good good)
        {
            if (ModelState.IsValid)
            {
                db.Entry(good).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(good);
        }

        // GET: Goods/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Good good = db.Goods.Find(id);
            if (good == null)
            {
                return HttpNotFound();
            }
            return View(good);
        }

        // POST: Goods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Good good = db.Goods.Find(id);
            db.Goods.Remove(good);
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
