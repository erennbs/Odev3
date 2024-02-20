using Odev3.Business.Abstracts;
using Odev3.DataAccess.Abstracts;
using Odev3.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3.Business.Concretes {
    public class CategoryManager : ICategoryManager {
        ICategoryDal _categryDal;

        public CategoryManager(ICategoryDal categoryDal) { 
            _categryDal = categoryDal;
        }

        public void PrintAll() {
            foreach (Category category in _categryDal.GetAll()) {
                Console.WriteLine(category.CategoryName);
            }
        }
        
        public void AddCategoty(Category category) {
            _categryDal.AddCategory(category);   
        }

        public void RemoveCategoty(Category category) {
            _categryDal.RemoveCategory(category);
        }

        public void UpdateName(int id, string name) {
            _categryDal.UpdateCategoryName(id, name);
        }
    }
}
