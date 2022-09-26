using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Web.IRepository;

namespace Web.Controllers
{
    public class NotFoundController : BaseController
    {
        public NotFoundController(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
