using Odev3.DataAccess.Abstracts;
using Odev3.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3.DataAccess.Concretes {
    public class MyCourseDal : ICourseDal {
        List<Course> courses;

        public List<Course> GetAll() {
            return courses;
        }

        public void AddCourse(Course course) {
            courses.Add(course);
        }

        public void RemoveCourse(Course course) {
            courses.Remove(course);
        }

        public void UpdateCategory(int CourseID, int categoryID) {
            Course course = courses.Where(course => course.ID == CourseID).SingleOrDefault();
            
            if (course != null) {
                course.CategoryID = categoryID;
            } else {
                throw new Exception($"No such Course with ID = {CourseID}");
            }
        }

        public void UpdateDescription(int CourseID, string description) {
            Course course = courses.Where(course => course.ID == CourseID).SingleOrDefault();

            if (course != null) {
                course.Description = description;
            }
            else {
                throw new Exception($"No such Course with ID = {CourseID}");
            }
        }

        public void UpdateInstructor(int CourseID, int instructorID) {
            Course course = courses.Where(course => course.ID == CourseID).SingleOrDefault();

            if (course != null) {
                course.InstructorID = instructorID;
            }
            else {
                throw new Exception($"No such Course with ID = {CourseID}");
            }
        }

        public void UpdateName(int CourseID, string name) {
            Course course = courses.Where(course => course.ID == CourseID).SingleOrDefault();

            if (course != null) {
                course.Name = name;
            }
            else {
                throw new Exception($"No such Course with ID = {CourseID}");
            }
        }
    }
}
