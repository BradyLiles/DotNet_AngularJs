﻿using System.Net;
using System.Web.Mvc;

namespace Angular4DotNetMVC.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public ActionResult Save(StudentVm student)
        {
           //_studentRegistrationService.Register(student);
            return new HttpStatusCodeResult(HttpStatusCode.InternalServerError);
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}
