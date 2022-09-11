using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.IRepository;
using Web.ViewModels;

namespace Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IActionResult> Index()
        {
            var products = await UnitOfWork.Product.GetAll(include: x => x.Include(p => p.Category));
            return View(new { Products = Mapper.Map<IList<ProductViewModel>>(products) });
        }
    }
}