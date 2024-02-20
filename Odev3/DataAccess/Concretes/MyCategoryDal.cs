using Odev3.DataAccess.Abstracts;
using Odev3.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3.DataAccess.Concretes {
    public class MyCategoryDal : ICategoryDal {
        List<Category> categories;

        public void AddCategory(Category category) {
            categories.Add(category);
        }

        public List<Category> GetAll() {
            return categories;
        }

        public void RemoveCategory(Category category) {
            categories.Remove(category);
        }

        public void UpdateCategoryName(int id, string categoryName) {
            Category categoryFound = categories.Where(category => category.CategoryID == id).SingleOrDefault();

            if (categoryFound != null) {
                categoryFound.CategoryName = categoryName;
            } else {
                throw new Exception($"No such Category with ID = {id}");
            }
        }
    }
}
