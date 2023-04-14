using JancysBooks.DataAcesss.Repository.IRepository;
using JancysBooks.Models;
using JancysBookStore.DataAcesss.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using JancysBooks.DataAccess.Repository;

namespace JancysBooks.DataAcesss.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            //Use .NET LINQ to retrieve the first or default category object,
            //Then pass the id as a generic entity which matches the category ID

            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null) //Save changes if not null
            {
                objFromDb.Name = category.Name;
                //_db.SaveChanges();

            }

        }
    }
}
