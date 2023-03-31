using JancysBooks.DataAcesss.Repository.IRepository;
using JancysBooks.Models;
using JancysBookStore.DataAcesss.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace JancysBooks.DataAcesss.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepositry
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db; 
        }
    }
}
