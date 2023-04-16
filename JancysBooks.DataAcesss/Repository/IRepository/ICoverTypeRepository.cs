using JancysBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;
using JancysBooks.Models;
using JancysBooks.DataAcesss.Repository.iRepository;

namespace JancysBooks.DataAcesss.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}