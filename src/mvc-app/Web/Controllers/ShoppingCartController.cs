using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Web.IRepository;
using Web.Models;
using Web.Requests;

namespace Web.Controllers
{
    [Authorize]
    public class ShoppingCartController : BaseController
    {
        public ShoppingCartController(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var carts = await UnitOfWork.Cart.GetAll(x => String.Equals(x.UserId, userId) && x.IsDeleted == false && x.IsOrder == false, include: x => x.Include(c => c.Product));
            return View(new { Carts = carts });
        }

        [HttpGet]
        public async Task<IActionResult> AddCart([FromQuery] CreateCart request)
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var existCart = await UnitOfWork.Cart.Get(x => String.Equals(x.UserId, userId) 
                    && x.ProductId == request.ProductId && x.IsOrder == false && x.IsDeleted == false);
                if (existCart != null)
                {
                    existCart.Quantity += request.Quantity;
                }
                else
                    await UnitOfWork.Cart.Insert(new Cart
                    {
                        UserId = userId,
                        ProductId = request.ProductId,
                        Quantity = request.Quantity,
                        IsDeleted = false,
                        IsOrder = false
                    });
                await UnitOfWork.Save();
            }
            catch (Exception)
            {
                RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCart(IFormCollection request)
        {
            try
            {
                var list = new List<Cart>();
                for (int i = 0; i < request["CartId"].Count; i++)
                {
                    list.Add(new Cart
                    {
                        ProductId = int.Parse(request["ProductId"][i]),
                        Quantity = int.Parse(request["Quantity"][i]),
                        Id = int.Parse(request["CartId"][i])
                    });
                }
                var listCart = await UnitOfWork.Cart.GetAll(x => request["CartId"].Contains(x.Id.ToString()));
                foreach (var item in listCart)
                {
                    foreach (var i in list)
                    {
                        if (item.Id == i.Id)
                        {
                            item.Quantity = i.Quantity;
                        }
                    }
                }
                ;
                await UnitOfWork.Save();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public async Task<IActionResult> DeleteCart(int id)
        {
            try
            {
                var cart = await UnitOfWork.Cart.Get(x => x.Id == id);
                cart.IsDeleted = true;
                await UnitOfWork.Save();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }

        }

    }
}
