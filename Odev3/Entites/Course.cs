using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3.Entites {
    public class Course {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public int InstructorID { get; set; }

        public Course(int id, string name, string description, int categoryID, int instructorID) { 
            ID = id;
            Name = name;
            Description = description;
            CategoryID = categoryID;
            InstructorID = instructorID;
        }
    }
}
