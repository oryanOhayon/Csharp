using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.API
{
    // מתאר פעולות שאפשר לעשות בנתונים
    public interface ICrud<T>
    {
        public void Create(T item);
        public List<T> GetAll();
    }
}
