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
        public IActionResult GetAll()
        {
            var query = _repository.Get().Take(10);
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
    }
}
