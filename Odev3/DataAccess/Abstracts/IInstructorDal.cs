using Odev3.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3.DataAccess.Abstracts {
    public interface IInstructorDal {
        public List<Instructor> GetAll();
        public void AddInstructor(Instructor instructor);
        public void RemoveCInstructor(Instructor instructor);
        public void UpdateInstructorFirstName(int id, string firstName);
        public void UpdateInstructorLastName(int id, string lastName);

    }
}
