using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Angular4DotNetMVC.Controllers
{
    public class CoursesController : Controller
    {
        public ActionResult Index()
        {
            return View("Index", "", GetSerializedCourseVms());
        }

        public string GetSerializedCourseVms()
        {
            var courses = new[]
            {
                new CourseVm {Number = "CS101", Name = "Course Name 1", Instructor = "instructor1"},
                new CourseVm {Number = "CS202", Name = "Course Name 2", Instructor = "instructor2"},
                new CourseVm {Number = "CS303", Name = "Course Name 3", Instructor = "instructor3"}
            };
            var settings = new JsonSerializerSettings {ContractResolver = new CamelCasePropertyNamesContractResolver()};
            return JsonConvert.SerializeObject(courses, Formatting.None, settings);
        }

    }



    public class CourseVm
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public string Instructor { get; set; }
    }
}


