using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.API.ICrudOrder;
namespace DAL.IMPLEMENTATION
{
    public class OrderDal : ICrudOrder
    {
        MyContext context = new MyContext();
        public bool Create(Order order)
        {
            context.Orders.Add(order);
            int x = context.SaveChanges();
            return x == 0;
        }
       

        public List<Order> GetAll()
        {
            return context.Orders.toList();
        }

        public void Delete(Order item)
        {
            //context.Persons.Remove(item);
            var emp = context.Orders.Where(e => e.Equals(item)).FirstOrDefault();

            if (emp != null)
            {
                context.Orders.Remove(item);
                context.SaveChanges();
            }
        }
        public void Update(int orderid, int personId)
        {
            var emp = context.Persons.Where(p => p.Orderid == orderid).FirstOrDefault();
            if (emp != null)
            {
                emp.PersonId = personId;         
                context.SaveChanges();
            }
        }

    }
}
