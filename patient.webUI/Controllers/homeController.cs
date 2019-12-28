using DocumentFormat.OpenXml.Spreadsheet;
using patient.webUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Table = patient.webUI.Models.Table;

namespace patient.webUI.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        private Database1Entities _db = new Database1Entities();
       
        public ActionResult Index()
        {
            return View(_db.Tables.ToList());
        }

        // GET: home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: home/Create
        [HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        public ActionResult Create([Bind(Exclude = "Id")]Table movieToCreate)

        {

            if (!ModelState.IsValid)

                return View();

            _db.Tables.Add(movieToCreate);

            _db.SaveChanges();

            return RedirectToAction("Index");

        }



        //public ActionResult CreatePatient()
        //{
        //    return View();
        //}


        //public ActionResult CreatePatient([Bind(Exclude = "Id")] patientTable movieToCreate)

        //{

        //    if (!ModelState.IsValid)

        //        return View();

        //    _db.Tables.Add(movieToCreate);

        //    _db.SaveChanges();

        //    return RedirectToAction("Index");

        //}









        // GET: home/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: home/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

    //    public ActionResult Edit(int id)

    //    {

    //        var movieToEdit = (from m in _db.Tables

    //                       where m.Id == id

    //                       select m).First(); 

    //return View(movieToEdit);

    //}

    //

    // POST: /Home/Edit/5 

    [AcceptVerbs(HttpVerbs.Post)]

    //public ActionResult Edit(Table movieToEdit)

    //{

    //    var originalMovie = (from m in _db.Tables

    //                         where m.Id == movieToEdit.Id

    //                         select m).First();

    //    if (!ModelState.IsValid)

    //        return View(originalMovie);

    //    _db.ApplyPropertyChanges(originalMovie.EntityKey, movieToEdit);

    //    _db.SaveChanges();

    //    return RedirectToAction("Index");

    //}








    // GET: home/Delete/5
    public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
