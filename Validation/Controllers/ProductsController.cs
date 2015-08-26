using ProductWithValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace ProductWithValidation.Controllers {
    public class ProductsController : Controller {
        // GET: Products
        public ActionResult Index() {
            return View();
        }

        // GET: Products/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: Products/Create
        public ActionResult Create() {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(Product collection) {
            if (ModelState.IsValid) {

                // do stuff like add to the database, etc.
                return RedirectToAction("Index");
            }
            else {
                return View();
            }
        }

        [HttpPost]
        public ActionResult ValidateName(string name) {
            return Json(new Regex(@"^\D*$").IsMatch(name));
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: Products/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection) {
            try {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch {
                return View();
            }
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: Products/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection) {
            try {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch {
                return View();
            }
        }
    }
}
