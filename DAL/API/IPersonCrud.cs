using DAL.API;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.API
{
    public interface IPersonCurd : ICrud<Person>
    {
        public void SendMail();
    }
}
