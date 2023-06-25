using BL.API;
using BL.Models;
using DAL.IMPLEMENTATION;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IMPLEMENTATION;

namespace BL.IMPLEMENTATION
{
    public class PersonService
    {
        PersonDal personDal=new PersonDal();
        public bool Create(Person item)
        {
           return personDal.Create(item);
        }

        public List<Person> GetAll()
        {
           personDal.GetAll();
        }

        public void Delete(Person p)
        {
            personDal.Delete(p);
        }
      
        public void Update(int personId, string addressToChange, string cityToChange)
        {
            personDal.Update(personId, addressToChange, cityToChange);
        }

    }
}
