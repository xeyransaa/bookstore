using Core;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
        public Task<Category> GetByIdAsync(int id);
        public Task<List<Category>> GetAllAsync();
        public void Update(int id, Category category);
    }
}
