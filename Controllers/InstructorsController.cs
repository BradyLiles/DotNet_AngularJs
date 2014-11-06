using System.Web.Mvc;
using Angular4DotNetMVC.Models.Registration;

namespace Angular4DotNetMVC.Controllers
{
    public class InstructorsController : JsonController
    {
        private readonly RegistrationVmBuilder _registrationVmBuilder = new RegistrationVmBuilder();

        public ActionResult Index()
        {
            return Json(_registrationVmBuilder.GetInstructorVms(), JsonRequestBehavior.AllowGet);
        }
    }
}