using Microsoft.EntityFrameworkCore.Storage;
using Web.Models;

namespace Web.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Category> Category { get; }
        IGenericRepository<Product> Product { get; }
        IGenericRepository<ProductImage> ProductImage { get; }
        IGenericRepository<Cart> Cart { get; }
        IGenericRepository<Order> Order { get; }
        IGenericRepository<OrderDetail> OrderDetail { get; }
        Task Save();
        IDbContextTransaction BeginTransaction();
    }
}
