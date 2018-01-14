
using System.Linq;
using MyWebAPI.Entities;

namespace MyWebAPI.Repositories
{
    public interface IBlogRepository
    {        
        IQueryable<Blog> GetAll();
    }
}