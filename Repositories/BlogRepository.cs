
using System.Linq;
using MyWebAPI.Entities;

namespace MyWebAPI.Repositories
{
    public class BlogRepository : IBlogRepository
    {

        private RDSContext _context;

        public BlogRepository(RDSContext context)
        {
            _context = context;
        }
        
        public IQueryable<Blog> GetAll()
        {
            return _context.Blogs;
        }

        public IQueryable<Blog> GetByText(string text)
        {
            var blogs = 
                from b in _context.Blogs
                where b.Url.ToLower().Contains(text.ToLower())
                select b;

            return blogs;
        }
    }
}