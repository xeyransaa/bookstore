using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryManager
    {
        private readonly ICategoryDal _dal;

        public CategoryManager(ICategoryDal dal)
        {
            _dal = dal;
        }

        public void Add(Category Category)
        {
            _dal.Add(Category);
        }

        public async Task<List<Category>> GetAll()
        {
            return await _dal.GetAllAsync();
        }

        public async Task<Category> GetById(int Id)
        {
            return await _dal.GetByIdAsync(Id);
        }

        public void Update(int id, Category Category)
        {
           _dal.Update(id, Category);
        }
    }
}
