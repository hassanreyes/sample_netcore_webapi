using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MyWebAPI.Entities
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        public List<Post> Posts { get; set; }
    }
}