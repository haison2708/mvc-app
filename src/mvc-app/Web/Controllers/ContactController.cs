using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Web.IRepository;

namespace Web.Controllers
{
    public class ContactController : BaseController
    {
        public ContactController(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
