﻿using ECommerceProject.Interfaces.IRepositories;
using ECommerceProject.Models;

namespace ECommerceProject.Interfaces.IConfiguration
{
    public interface IUnitOfWork
    {
        public IProductRepository Products { get; }
        public IUserRepository Users { get; }
        public IOrderRepository Orders { get; }
        public IOrderDetailRepository OrderDetails { get; }
        public IReviewRepository Reviews { get; }

        Task CompleteAsync();
    }
}