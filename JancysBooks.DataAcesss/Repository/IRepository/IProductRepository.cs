using JancysBooks.DataAcesss.Repository.iRepository;
using JancysBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JancysBooks.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}