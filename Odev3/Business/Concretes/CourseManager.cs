using Odev3.Business.Abstracts;
using Odev3.DataAccess.Abstracts;
using Odev3.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3.Business.Concretes {
    public class CourseManager : ICourseManager {
        ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void PrintAllCourses() {
            List<Course> courses = _courseDal.GetAll();

            foreach (Course course in courses) {
                Console.WriteLine($"{course.Name} | {course.Description}");
            }
        }
        
        public void AddCourse(Course course) {
            _courseDal.AddCourse(course);
        }

        public void RemoveCourse(Course course) {
            _courseDal.RemoveCourse(course);
        }

        public void UpdateName(int id, string name) {
            _courseDal.UpdateName(id, name);
        }

        public void UpdateDescription(int id, string description) {
            _courseDal.UpdateDescription(id, description);
        }

        public void UpdateCategory(int id, int categoryID) {
            _courseDal.UpdateCategory(id, categoryID);
        }

        public void UpdateInstructor(int id, int instructorID) {
            _courseDal.UpdateInstructor(id, instructorID);
        }
    }
}
