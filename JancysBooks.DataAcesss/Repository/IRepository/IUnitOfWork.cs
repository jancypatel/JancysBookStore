using JancysBooks.DataAcesss.Repository.IRepository;
using JancysBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JancysBooks.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ICoverTypeRepository CoverType { get; }
        ISP_Call SP_Call { get; }

        void Save();
    }
}
