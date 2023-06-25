using BL.API;
using BL.Models;
using DAL.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IMPLEMENTATION;

namespace BL.IMPLEMENTATION
{
    public class OrderService: ICrudOrder 
    {
        OrderDal orderDal = new OrderDal() ;
        public bool Create(Order ordr)
        {
            return orderDal.Create(ordr) ;
        }

        public List<Person> GetAll()
        {
            return orderDal.GetAll();
        }
        public void Delete(Order item)
        {
            orderDal.Delete(item);
        }
        public void Update(int orderid, int personId)
        {
            orderDal.Update(orderid, personId);
        }
    }
}
