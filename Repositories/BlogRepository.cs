
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
    }
}