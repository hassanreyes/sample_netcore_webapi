﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyWebAPI.Repositories;

namespace MyWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        IBlogRepository _blogRepository = null;
        ILoggerFactory _loggerFactory = null;

        public ValuesController(IBlogRepository blogRepository, ILoggerFactory loggerFactory)
        {
            _blogRepository = blogRepository;
            _loggerFactory = loggerFactory;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value, [FromBody]string url, [FromBody]int n)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
