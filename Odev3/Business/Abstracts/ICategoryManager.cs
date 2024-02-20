using Odev3.DataAccess.Abstracts;
using Odev3.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3.Business.Abstracts {
    public interface ICategoryManager {
        public void PrintAll();
        public void AddCategoty(Category category);
        public void RemoveCategoty(Category category);
        public void UpdateName(int id, string name);
    }
}
