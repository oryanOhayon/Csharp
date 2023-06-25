using DAL.API;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IMPLEMENTATION
{
    public class PersonDal : IPersonCrud
    { 
        MyContext context=new MyContext();
        public bool Create(Person item)
        {
            context.Persons.Add(item);
            int x = context.SaveChanges();
            return x == 0;
        }

        public List<Person> GetAll()
        {
            return context.Persons.toList();
        }

        public void Delete(Person item)
        {
            //context.Persons.Remove(item);
            var emp = context.Persons.Where(e => e.Equals(item)).FirstOrDefault();

            if (emp != null)
            {
                context.Person.Remove(item);
                context.SaveChanges();
            }
        }
        public void Update(int personId, string addressToChange, string cityToChange)
        {
            var emp = context.Persons.Where(p => p.PersonId == personId).FirstOrDefault();
            if (emp != null)
            {  
                emp.Address = addressToChange;
                emp.City = cityToChange;
                context.SaveChanges();
            }
        }

    }

    public interface IPersonCrud
    {
    }
}
