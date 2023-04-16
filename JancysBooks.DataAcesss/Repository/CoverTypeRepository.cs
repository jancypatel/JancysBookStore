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
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType coverType)
        {
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null) //Save changes if not null
            {
                objFromDb.Name = coverType.Name;
                //_db.SaveChanges();
            }

        }
    }
}