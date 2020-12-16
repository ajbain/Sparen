using Sparen.Models;
using Sparen.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sparen.Controllers
{
    public class CheckingController : Controller
    {
        // GET: Checking
        public ActionResult Index()
        {
            var service = new CheckingAccountService();
            var model = service.GetCheckingAccounts();
            return View(model);
        }

        // GET: Checking/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: Checking/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Checking/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CheckingAccountCreate model)
        {
            if (!ModelState.IsValid) return View(model);
            var service = CreateCheckingAccountService();
            
            if (service.CreateCheckingAccount(model))
            {
                ViewBag.SaveResult = "Your Checking Account was created!";
                return RedirectToAction("Index");
            };
            ModelState.AddModelError("", "Checking Account couldn't be created.");
            return View(model); 
        }
        private CheckingAccountService CreateCheckingAccountService()
        {
            var service = new CheckingAccountService();
            return service;
        }
        

        //// GET: Checking/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Checking/Edit/5
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

        //// GET: Checking/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Checking/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
