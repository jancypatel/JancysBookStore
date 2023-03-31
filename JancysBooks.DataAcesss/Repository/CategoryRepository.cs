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
            throw new NotImplementedException();
        }
    }
}
