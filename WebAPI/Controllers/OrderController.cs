using Microsoft.AspNetCore.Mvc;
using BL.Models;
using BL.IMPLEMENTATION;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : Controller
    {

        OrderService orderBl = new OrderService();

        [HttpGet(Name = "GetOrders")]
        public List<OrderService> Get()
        {
            return orderBl.GetAll();
        }

        [HttpGet(Name = "InsertOrder")]
        public bool InsertOrder(Order order)
        {
            orderBl.Create(order);
            return true ;
        }
        public bool DeleteAOrder(Order order)
        {
            orderBl.Delete(order);
        }
        public void Update(int orderid, int personId)
        {
            orderBl.Update(orderid, personId);
        }

    }
}
