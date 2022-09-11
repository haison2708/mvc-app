using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Web.IRepository;

namespace Web.Controllers
{
    [Route("{controller}")]
    public class ShopController : BaseController
    {
        public ShopController(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IActionResult> Index(int pageIndex = 1)
        {
            var skip = pageIndex == 1 ? 6 : 9 * pageIndex - 3;
            var products = await UnitOfWork.Product.GetAll(orderBy: x => x.OrderByDescending(p => p.CreatedAt));
            return View(new { LatedProduct1 = products.Take(3), LatedProduct2 = products.Skip(3).Take(3),
                Products = products.Skip(skip).Take(9), Count = products.Skip(6).Count() / 9 + 1
            });
        }

        [Route("Category/{categoryId:int}")]
        public async Task<IActionResult> GetProductByCategory(int categoryId)
        {
            var products = await UnitOfWork.Product.GetAll(x => x.CategoryId == categoryId, orderBy: x => x.OrderByDescending(p => p.CreatedAt));
            return View(new
            {
                Products = products
            });
        }

        [Route("Product/{id:int}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await UnitOfWork.Product.Get(x => x.Id == id);
            var relatedProduct = await UnitOfWork.Product.GetAll(x => x.CategoryId == product.CategoryId && x.Id != product.Id
            , orderBy: x => x.OrderByDescending(p => p.CreatedAt));
            return View(new { Product = product, RelatedProduct = relatedProduct.Take(4) });
        }

        [Route("Product")]
        public async Task<IActionResult> GetProductByName(string productName)
        {
            var product = await UnitOfWork.Product.GetAll(x => x.Name.ToLower().Contains(productName.ToLower().Trim()));
            return View(new { Products = product });
        }
    }
}
