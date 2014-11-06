using Angular4DotNetMVC.Models.Courses;
using Angular4DotNetMVC.Models.Instructors;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Angular4DotNetMVC.Models.Registration
{
    public class RegistrationVmBuilder
    {
        public RegistrationVm BuildRegistrationVm()
        {
            var registrationVm = new RegistrationVm
            {
                Courses = GetSerializedCourses(),
                Instructors = GetSerializedInstructors()
            };

            return registrationVm;
        }
        public string GetSerializedCourses()
        {
            var courses = new[]
            {
                new CourseVm {Number = "CS101", Name = "Course Name 1", Instructor = "instructor1"},
                new CourseVm {Number = "CS202", Name = "Course Name 2", Instructor = "instructor2"},
                new CourseVm {Number = "CS303", Name = "Course Name 3", Instructor = "instructor3"}
            };
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            var serializedCourses = JsonConvert.SerializeObject(courses, Formatting.None, settings);
            return serializedCourses;
        }

        public string GetSerializedInstructors()
        {
            var instructors = new[]
            {
                new InstructorVm {Name = "instructor1", Email = "instructor1@email.com", RoomNumber = "100"},
                new InstructorVm {Name = "instructor2", Email = "instructor2@email.com", RoomNumber = "200"},
                new InstructorVm {Name = "instructor3", Email = "instructor3@email.com", RoomNumber = "300"}
            };
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            var serialiedInstructors = JsonConvert.SerializeObject(instructors, Formatting.None, settings);
            return serialiedInstructors;
        }
         
    }
}