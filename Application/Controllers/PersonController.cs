using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Application.Models;

namespace Application.Controllers
{
    public class PersonController : Controller
    {

        // GET: Person
        public ActionResult Index()
        {
            PersonModel person = new PersonModel();

            person.ID = 23;
            person.Name = "Laura";
            person.LastName = "Michel";
            person.Age = 22;
            person.Address = "Villa de Alvarez";
            return View(person);
        }

        public ActionResult Content(int PersonId) {

            return Content(String.Format("ID: {0}", PersonId));
        }

        public ActionResult EmptyResult() {
            return new EmptyResult();
        }

        public ActionResult RedirectToAction() {
            return RedirectToAction("Index", "Home");
        }

        public ActionResult ViewResult() {
            return new ViewResult();
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Person/Delete/5
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
