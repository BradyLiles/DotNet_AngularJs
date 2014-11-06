using System.Web.Mvc;
using Angular4DotNetMVC.Models.Registration;

namespace Angular4DotNetMVC.Controllers
{
    public class RegistrationController : Controller
    {
        private RegistrationVmBuilder _registrationVmBuilder = new RegistrationVmBuilder();

        public ActionResult Index()
        {
            return View(_registrationVmBuilder.BuildRegistrationVm());
        }

    }
}
