using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Data;
using Web.IRepository;
using Web.Models;

namespace Web.Controllers
{
    public class OrderController :  BaseController
    {
        public OrderController(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var listOrder = await UnitOfWork.Order.GetAll(x => x.UserId == userId, 
                include: x => x.Include(o => o.OrderDetails!).ThenInclude(o => o.Product), orderBy: x => x.OrderBy(o => o.CreatedAt));
            return View(new {Order = listOrder});
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(IFormCollection request)
        {

            try
            {
                var total = 0;
                var orderDetails = new List<OrderDetail>();
                var products = await UnitOfWork.Product.GetAll(x => request["ProductId"].Any(a => a == x.Id.ToString()));
                var carts = await UnitOfWork.Cart.GetAll(x => request["CartId"].Any(a => a == x.Id.ToString()));
                for (var i = 0; i < request["ProductId"].Count; i++)
                {
                    carts.FirstOrDefault(x => x.Id == int.Parse(request["CartId"][i]))!.IsOrder = true;
                    total += int.Parse(request["Quantity"][i]) * products.FirstOrDefault(
                        x => x.Id == int.Parse(request["ProductId"][i]))!.Price;
                    orderDetails.Add(new OrderDetail
                    {
                        ProductId = int.Parse(request["ProductId"][i]),
                        Quantity = int.Parse(request["Quantity"][i])
                    });
                }
                var order = new Order
                {
                    Address = request["Address"],
                    UserId = User.FindFirstValue(ClaimTypes.NameIdentifier),
                    OrderDetails = orderDetails,
                    Total = total,
                    Status = Status.WaitingForConfirmation
                };
                await UnitOfWork.Order.Insert(order);
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
