using Odev3.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3.DataAccess.Abstracts {
    public interface ICategoryDal {
        public List<Category> GetAll();
        public void AddCategory(Category category);
        public void RemoveCategory(Category category);
        public void UpdateCategoryName(int id, string categoryName);
    }
}
