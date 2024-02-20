using Odev3.Business.Abstracts;
using Odev3.DataAccess.Abstracts;
using Odev3.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3.Business.Concretes {
    public class InstructorManager : IInstructorManager {
        IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal) {
            _instructorDal = instructorDal;
        }

        public void PrintAllInstructors() {
            foreach (Instructor instructor in _instructorDal.GetAll()) {
                Console.WriteLine($"{instructor.FirstName} {instructor.LastName}");
            }
        }

        public void AddInstructor(Instructor instructor) {
            _instructorDal.AddInstructor(instructor);
        }

        public void RemoveInstructor(Instructor instructor) {
            _instructorDal.RemoveCInstructor(instructor);
        }

        public void ChangeName(int id, string firstName, string lastName) {
            _instructorDal.UpdateInstructorFirstName(id, firstName);
            _instructorDal.UpdateInstructorLastName(id, lastName);
        }
    }
}
