using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Models;
using System.Threading.Tasks;

namespace DAL.API
{
    public interface ICrudOrder: ICrud<Order>
    {
    }
}
