using Odev3.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3.DataAccess.Abstracts {
    public interface ICourseDal {
        public List<Course> GetAll();
        public void AddCourse(Course course);
        public void RemoveCourse(Course course);
        public void UpdateName(int CourseID, string name);
        public void UpdateDescription(int CourseID, string description);
        public void UpdateCategory(int CourseID, int categoryID);
        public void UpdateInstructor(int CourseID, int instructorID);



    }
}
