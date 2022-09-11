using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Web.IRepository;
using Web.ViewModels;

namespace Web.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IUnitOfWork UnitOfWork;
        protected readonly IMapper Mapper;
        public BaseController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            UnitOfWork = unitOfWork;
            Mapper = mapper;
        }

        public override async void OnActionExecuting(ActionExecutingContext context)
        {
            var categories = Mapper.Map<IList<CategoryViewModel>>(await UnitOfWork.Category.GetAll());
            var parent = categories.Where(x => x.ParentId == 0).ToList();
            var child = categories.Where(x => x.ParentId != 0).ToList();
            foreach (var category in parent)
            {
                category.Categories = new List<CategoryViewModel>();
                foreach (var categoryViewModel in child)
                {
                    if (categoryViewModel.ParentId == category.Id)
                    {
                        category.Categories.Add(categoryViewModel);
                        categories.Remove(categoryViewModel);
                    }
                }
            }
            ViewData["categories"] = parent;

            base.OnActionExecuting(context);
        }
    }
}
