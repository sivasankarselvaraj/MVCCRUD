using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccesse_Layer;
namespace MVC__with_CRUD.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly IDoctorsRepository Result;
        public DoctorsController()
        {
            Result =new DoctorsRepository();
        }
        // GET: DoctorsController
        public ActionResult Index()
        {
            var Obj = Result.GetAll();
            return View("View",Obj);
        }

        // GET: DoctorsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DoctorsController/Create
        public ActionResult Create()
        {
            
            return View("Create", new Doctors());
        }

        // POST: DoctorsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Doctors add)
        {
            try
            {
                Result.Insert(add);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DoctorsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DoctorsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DoctorsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DoctorsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
