﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3.Entites {
    public class Category {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public Category(int categoryID, string categoryName)
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
        }
    }
}
