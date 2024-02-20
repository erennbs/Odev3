using Odev3.DataAccess.Abstracts;
using Odev3.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3.DataAccess.Concretes {
    public class MyInstructorDal : IInstructorDal {
        List<Instructor> instructors;
        
        public void AddInstructor(Instructor instructor) {
            instructors.Add(instructor);
        }

        public List<Instructor> GetAll() {
            return instructors;
        }

        public void RemoveCInstructor(Instructor instructor) {
            instructors.Remove(instructor);
        }

        public void UpdateInstructorFirstName(int id, string firstName) {
            Instructor instructorFound= instructors.Where(instructor => instructor.ID == id).SingleOrDefault();

            if (instructorFound != null) {
                instructorFound.FirstName = firstName;
            }
            else {
                throw new Exception($"No such Instructor with ID = {id}");
            }
        }

        public void UpdateInstructorLastName(int id, string lastName) {
            Instructor instructorFound = instructors.Where(instructor => instructor.ID == id).SingleOrDefault();

            if (instructorFound != null) {
                instructorFound.LastName = lastName;
            }
            else {
                throw new Exception($"No such Instructor with ID = {id}");
            }
        }
    }
}
