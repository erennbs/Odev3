using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3.Entites {
    public class Instructor {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Instructor(int id, string firstName, string lastName)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
