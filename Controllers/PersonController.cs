using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using kinderkultur.Models;

namespace kinderkultur.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }


        [HttpGet]
        public IEnumerable<Person> GetAll()
        {
            return _personRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetPerson")]
        public IActionResult GetById(long id)
        {
            var item = _personRepository.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
    }
}
