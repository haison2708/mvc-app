using AutoMapper;
using Web.Models;
using Web.ViewModels;

namespace Web.Data
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Category, CategoryViewModel>();
            CreateMap<Product, ProductViewModel>();
            CreateMap<Cart, CartViewModel>();
        }
    }
}
