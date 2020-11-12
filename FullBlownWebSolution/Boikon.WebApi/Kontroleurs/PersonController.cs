using Boikon.Entities;
using Boikon.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Boikon.WebApi.Kontroleurs
{
    [Route("person")]
    public class PersonController: ControllerBase
    {
        private IPersonRepository _repository;

        public PersonController(IPersonRepository repo)
        {
            _repository = repo;
        }

        [HttpGet]
        [Route("all")]
        public IActionResult GetAll(int page = 0, int size=10)
        {
            int skip = page * size;
            var query = _repository.Get().Skip(skip).Take(size);
            return Ok(query.ToList());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            Person p = _repository.Get().FirstOrDefault(x => x.ID == id);
            return Ok(p);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Person p)
        {
            _repository.Insert(p);

            return CreatedAtAction(nameof(Get),  new { id = p.ID }, p);
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromRoute]int id, [FromBody]Person p)
        {
            bool ok = _repository.Update(id, p);
            if (ok)
            {
                return Ok();
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute]int id)
        {
            var ok = _repository.Delete(id);
            if (ok)
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
