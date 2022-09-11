using Microsoft.EntityFrameworkCore.Storage;
using Web.Data;
using Web.IRepository;
using Web.Models;

namespace WebAPI.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyDbContext _context;
        private IGenericRepository<Category> category;
        private IGenericRepository<Product> product;
        private IGenericRepository<ProductImage> productImage;
        private IGenericRepository<Cart> cart;
        private IGenericRepository<Order> order;
        private IGenericRepository<OrderDetail> orderDetail;

        public UnitOfWork(MyDbContext myDbContext) { _context = myDbContext; }
        public IGenericRepository<Category> Category => category ??= new GenericRepository<Category>(_context);

        public IGenericRepository<Product> Product => product ??= new GenericRepository<Product>(_context);

        public IGenericRepository<ProductImage> ProductImage => productImage ??= new GenericRepository<ProductImage>(_context);

        public IGenericRepository<Cart> Cart => cart ??= new GenericRepository<Cart>(_context);

        public IGenericRepository<Order> Order => order ??= new GenericRepository<Order>(_context);

        public IGenericRepository<OrderDetail> OrderDetail => orderDetail ??= new GenericRepository<OrderDetail>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public IDbContextTransaction BeginTransaction()
        {
            return _context.Database.BeginTransaction();
        }
    }
}
