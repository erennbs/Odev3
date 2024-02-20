using Odev3.DataAccess.Abstracts;
using Odev3.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3.Business.Abstracts {
    public interface IInstructorManager {
        public void PrintAllInstructors(); 
        public void AddInstructor(Instructor instructor);
        public void RemoveInstructor(Instructor instructor);
        public void ChangeName(int id, string firstName, string lastName);
    }
}
