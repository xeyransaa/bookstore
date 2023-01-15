using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCategoryDal : EFEntityRepositoryBase<BookStoreDbContext, Category>, ICategoryDal
    {
        public async Task<List<Category>> GetAllAsync()
        {
            using BookStoreDbContext context = new ();
            var categories = context.Categories.ToListAsync();
            return await categories;
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            using BookStoreDbContext context = new ();
            var category = await context.Categories.FirstOrDefaultAsync(c => c.Id == id);
            return category;
        }

        public void Update(int id, Category category)
        {
            using BookStoreDbContext context = new();
            category.Id = id;
            var cat = GetByIdAsync(id);
            context.Categories.Update(category);
            context.SaveChanges();
        }
    }
}
