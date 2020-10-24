using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestAuthorize20201024.Common;
using TestAuthorize20201024.Models;

namespace TestAuthorize20201024.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Check(UserModel reqModel)
        {
            if(reqModel.Name=="kmm" && reqModel.Password=="123")
            {
                HttpContext.Session["Name"] = reqModel.Name;
                return RedirectToAction("Auth");
            }
            return View("Index");
        }

        [CustomAuthorize]
        public ActionResult Auth()
        {
            return View();
        }
    }
}