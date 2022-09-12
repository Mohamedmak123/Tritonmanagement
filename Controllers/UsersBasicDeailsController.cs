﻿using Attanance.IRepo;
using Attanance.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Attanance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersBasicDeailsController : ControllerBase
    {
        private readonly IUsers _users;

        public UsersBasicDeailsController(IUsers users)
        {
            _users = users;
        }
        // GET: api/<UsersBasicDeailsController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var responce = await _users.GetUserList();
            return Ok(responce);
        }

        // GET api/<UsersBasicDeailsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsersBasicDeailsController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserBasicDetailsViewModel userBasicDetailsViewModel)
        {
           var result = await _users.CreateUser(userBasicDetailsViewModel);
            return Ok(result);
        }
        [HttpPost("Attanance")]
        public async Task<IActionResult> CreateAttanance([FromBody] AttanancesViewModel attanancesViewModel)
        {
            var result = await _users.CreateAttanance(attanancesViewModel);
            return Ok(result);
        }
        // PUT api/<UsersBasicDeailsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersBasicDeailsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
