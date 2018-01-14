using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyWebAPI.Repositories;

namespace MyWebAPI.Controllers 
{
    [Route("api/blogs")]
    public class BlogsController : Controller
    {
        private IBlogRepository _repository;

        public BlogsController(IBlogRepository repository)
        {
            _repository = repository;
        }

        public IActionResult GetAllBlogs()
        {
            var allBlogs = _repository.GetAll().ToList();

            return Ok(allBlogs);
        }
    }
}