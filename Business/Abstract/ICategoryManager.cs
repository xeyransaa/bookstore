using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryManager
    {
        void Add(Category Category);
        Task<Category> GetById(int Id);
        Task<List<Category>> GetAll();
        void Update(int id, Category Category);
    }
}
