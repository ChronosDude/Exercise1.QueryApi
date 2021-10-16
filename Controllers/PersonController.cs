using System.Collections;
using Microsoft.AspNetCore.Mvc;
using QueryApi.Repositories;
using QueryApi.Domain;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var repository = new PersonRepository();
            var persons = repository.SkipPerson();
            return Ok(persons);
        } 

        [HttpGet]
        [Route("Fields")]
        public IActionResult GetFields()
        {
            var repository = new PersonRepository();
            var persons = repository.GetFields();
            return Ok(persons);
        }

        [HttpGet]
        [Route("ByGender")]
        public IActionResult GetByGender()
        {
            var repository = new PersonRepository();
            var persons = repository.GetByGender();
            return Ok(persons);
        }

        [HttpGet]
        [Route("MinusAge")]
        public IActionResult GetMinusAge()
        {
            var repository = new PersonRepository();
            var persons = repository.GetMinusAge();
            return Ok(persons);
        }

        [HttpGet]
        [Route("Diference")]
        public IActionResult GetDiference()
        {
            var repository = new PersonRepository();
            var persons = repository.GetDiference();
            return Ok(persons);
        }

        [HttpGet]
        [Route("Jobs")]
        public IActionResult GetJobs()
        {
            var repository = new PersonRepository();
            var persons = repository.GetJobs();
            return Ok(persons);
        }

        [HttpGet]
        [Route("StartWith")]
        public IActionResult GetStartWith()
        {
            var repository = new PersonRepository();
            var persons = repository.GetStartWith();
            return Ok(persons);
        }

        [HttpGet]
        [Route("Contains")]
        public IActionResult GetContains()
        {
            var repository = new PersonRepository();
            var persons = repository.GetContains();
            return Ok(persons);
        }

        [HttpGet]
        [Route("ByList")]
        public IActionResult GetByList()
        {
            var repository = new PersonRepository();
            var persons = repository.GetByList();
            return Ok(persons);
        }
        
        [HttpGet]
        [Route("Ordered")]
        public IActionResult GetOrdered()
        {
            var repository = new PersonRepository();
            var persons = repository.GetOrdered();
            return Ok(persons);
        }

        [HttpGet]
        [Route("OrderedDesc")]
        public IActionResult GetOrderedDesc()
        {
            var repository = new PersonRepository();
            var persons = repository.GetOrderedDesc();
            return Ok(persons);
        }

        [HttpGet]
        [Route("CountPerson")]
        public IActionResult CountPerson()
        {
            var repository = new PersonRepository();
            var persons = repository.CountPerson();
            return Ok(persons);
        }

        [HttpGet]
        [Route("ExistPerson")]
        public IActionResult ExistPerson()
        {
            var repository = new PersonRepository();
            var persons = repository.ExistPerson();
            return Ok(persons);
        }

        [HttpGet]
        [Route("AnyPerson")]
        public IActionResult AnyPerson()
        {
            var repository = new PersonRepository();
            var persons = repository.AnyPerson();
            return Ok(persons);
        }

        [HttpGet]
        [Route("First")]
        public IActionResult GetFirst()
        {
            var repository = new PersonRepository();
            var persons = repository.GetFirst();
            return Ok(persons);
        }

        [HttpGet]
        [Route("TakePerson")]
        public IActionResult TakePerson()
        {
            var repository = new PersonRepository();
            var persons = repository.TakePerson();
            return Ok(persons);
        }

        [HttpGet]
        [Route("SkipPerson")]
        public IActionResult SkipPerson()
        {
            var repository = new PersonRepository();
            var persons = repository.SkipPerson();
            return Ok(persons);
        }
    }
}