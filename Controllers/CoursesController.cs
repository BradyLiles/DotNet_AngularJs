﻿using System.Web.Mvc;
using Angular4DotNetMVC.Models.Registration;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Angular4DotNetMVC.Controllers
{
    public class CoursesController : Controller
    {
        private readonly RegistrationVmBuilder _registrationVmBuilder = new RegistrationVmBuilder();

        public ActionResult Index()
        {
            return View("Index", "", _registrationVmBuilder.GetSerializedCourses());

        }
    }
}


