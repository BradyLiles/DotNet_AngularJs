using Angular4DotNetMVC.Models.Courses;
using Angular4DotNetMVC.Models.Instructors;

namespace Angular4DotNetMVC.Models.Registration
{
    public class RegistrationVmBuilder
    {
        public CourseVm[] GetCourseVms()
        {
            var courses = new[]
            {
                new CourseVm {Number = "CS101", Name = "Course Name 1", Instructor = "instructor1"},
                new CourseVm {Number = "CS202", Name = "Course Name 2", Instructor = "instructor2"},
                new CourseVm {Number = "CS303", Name = "Course Name 3", Instructor = "instructor3"}
            };
            return courses;
        }

        public InstructorVm[] GetInstructorVms()
        {
            var instructors = new[]
            {
                new InstructorVm {Name = "instructor1", Email = "instructor1@email.com", RoomNumber = "100"},
                new InstructorVm {Name = "instructor2", Email = "instructor2@email.com", RoomNumber = "200"},
                new InstructorVm {Name = "instructor3", Email = "instructor3@email.com", RoomNumber = "300"}
            };

            return instructors;
        }
         
    }
}