using Odev3.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3.Business.Abstracts {
    public interface ICourseManager {
        public void PrintAllCourses();

        public void AddCourse(Course course);

        public void RemoveCourse(Course course);

        public void UpdateName(int id, string name);

        public void UpdateDescription(int id, string description);

        public void UpdateCategory(int id, int categoryID);

        public void UpdateInstructor(int id, int instructorID);
    }
}
