using BL.IMPLEMENTATION;
using BL.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("API/controller")]
    [ApiController]
    public class PersonController : Controller
    {
        PersonService p = new PersonService();
        [HttpGet(Name = "GetAll")]
        public List<Person> GetAll()
        {
            return p.GetAll();
        }
        [HttpGet(Name = "CreatPerson")]
        public void Create(Person item)
        {
            p.Create(item);
        }

        [HttpGet(Name = "DeletePerson")]
        public void Delete(Person item)
        {
            p.Delete(item);
        }
        public void Update(int personId, string addressToChange, string cityToChange)
        {
            p.Update(personId, addressToChange, cityToChange);
        }
    }
}
