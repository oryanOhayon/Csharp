using BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.API
{
    internal interface IPersonCrud : ICrud<Person>
    {
        public void SendMail();
    }
}
