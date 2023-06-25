using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.API
{
    // מתאר פעולות שאפשר לעשות בנתונים
    public interface ICrud<T>
    {
        public bool Create(T item);
        public List<T> GetAll();
    }
}
