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
        public DoctorsController(IDoctorsRepository injectobject, IConfiguration service)
        {
            Result = injectobject;
            Connection = service.GetConnectionString("Dbconnection");
        }
        // GET: DoctorsController
        public ActionResult Index()
        {
            try
            {
                var Obj = Result.GetAll();
                return View("View", Obj);
            }
            catch
            {
                return View();
            }
        }

        // GET: DoctorsController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                var obj = Result.GetbyID(id);
                return View("Details", obj);
            }
            catch
            {
                return View();
            }
        }

        // GET: DoctorsController/Create
        public ActionResult Create()
        {
            try
            {
                return View("Create", new Doctors());
            }
            catch
            {
                return View();
            }
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
            try
            {
                var obj = Result.GetbyID(id);
                return View("Update", obj);
            }
            catch
            {
                return View();
            }
        }

        // POST: DoctorsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(long id, Doctors replace)
        {
            try
            {
                Result.Update(id, replace);   
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("View");
            }
        }

        // GET: DoctorsController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                var Get = Result.GetbyID(id);
                return View("Delete", Get);
            }
            catch 
            {
                return View();
            }
        }

        // POST: DoctorsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete1(int DoctorsID)
        {
            try
            {
                Result.Delete(DoctorsID);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("error");
            }
        }
        public ActionResult LogIN()
        {
            return View("Login", new Doctors());
        }

    }
}
