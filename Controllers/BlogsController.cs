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

        [HttpGet]
        public IActionResult GetAllBlogs()
        {
            var allBlogs = _repository.GetAll().ToList();

            return Ok(allBlogs);
        }

        [Route("allWith/{text}")]
        [HttpGet]
        public IActionResult GetAllBlogsWith(string text)
        {
            if(string.IsNullOrWhiteSpace(text))
            {
                return BadRequest("not a valid text parameter");
            }

            return Ok(_repository.GetByText(text));
        }
    }
}