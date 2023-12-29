using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccesse_Layer;
using Microsoft.Extensions.Configuration;


namespace MVC__with_CRUD.Controllers
{
    
    public class LoginController : Controller
    {
       
       
        public IActionResult Index()
        {
            try
            {

                return View("View");
               
               
            }
            catch
            {
                return View();
            }
        }
        public IActionResult Index(Login ad)
        {
            try
            {

                return View("View", new Login());


            }
            catch
            {
                return View();
            }
        }

        public IActionResult Details(Login ad)
        {
            try
            {
                if (ad.Password == "Siva")
                {

                    return View();
                }
                return View();
               
            }
            catch
            {
                return View();
            }
        }
    }
}
