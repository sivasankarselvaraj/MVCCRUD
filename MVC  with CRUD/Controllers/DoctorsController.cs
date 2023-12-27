using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using DataAccesse_Layer;
namespace MVC__with_CRUD.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly IDoctorsRepository Result;
        private readonly string Connection;
        public DoctorsController(IDoctorsRepository Obj, IConfiguration service)
        {
            Result = Obj;
            Connection = service.GetConnectionString("Dbconnection");
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
          var obj= Result.GetbyID(id);
            return View("Details",obj);
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
                if (ModelState.IsValid)
                {
                    Result.Insert(add);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View("Create", add);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: DoctorsController/Edit/5
        public ActionResult Edit(long id)
        {
            var Obj = Result.GetbyID(id);
            return View("Update",Obj);
        }

        // POST: DoctorsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(long id, Doctors Pro)
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
            var Get = Result.GetbyID(id);
            return View("Delete",Get);
        }

        // POST: DoctorsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,Doctors Get)
        {
            try
            {
                Result.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult LogIN()
        {
            return View("Login", new Doctors());
        }

    }
}
